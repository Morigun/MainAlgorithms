using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MainAlgorithms.Others
{
    public class ExpressionAndReflection
    {
        public class TestClass
        {
            public Guid ID { get; set; }
            public DateTime Date { get; set; }
        }
        public class PreT<T>
        {
            public Guid ID { get; set; }
            public DateTime Date { get; set; }
            public T? Data { get; set; }
        }
        public class LRStruct<L, R>
        {
            public L? LeftData { get; set; }
            public R? RightData { get; set; }
        }
        public static List<T> LeftJoin<T>(List<Guid> ids, List<T> outerTestData) where T : TestClass
        {
            var res = from id in ids
                      join td in outerTestData on new { ID = id, Date = DateTime.Now.Date } equals new { td.ID, td.Date }
                      into tmpTD
                      from td in tmpTD.DefaultIfEmpty()
                      select new PreT<T>
                      {
                          ID = id,
                          Date = DateTime.Now.Date,
                          Data = td
                      };
            var tmp = res.Select(GetSelector<PreT<T>, T>(new List<string>(2) { "ID", "Date" })).ToList();
            return tmp;
        }
        public static List<TInner> LeftJoinAleter<TOuter, TInner, TKey>(List<TOuter> ids, 
                                                                                  List<TInner> outerTestData, 
                                                                                  Func<TOuter, TKey> outerKeySelector, 
                                                                                  Func<TInner, TKey> innerKeySelector) where TInner : TestClass
        {
            var prets = ids.GroupJoin(outerTestData,
                                      outerKeySelector,
                                      innerKeySelector,
                                      (a, b) => new { a, b })
                           .SelectMany(b => b.b.DefaultIfEmpty(),
                                       (a, b) => new LRStruct<TOuter, TInner>
                                       {
                                           LeftData = a.a,
                                           RightData = b
                                       });
            return prets.Select(GetSelector<LRStruct<TOuter, TInner>, TInner>(typeof(TOuter).GetProperties().Select(a => a.Name).ToList())).ToList();
        }
        public static Func<TSource, TResult> GetSelector<TSource, TResult>()
        {
            var expParameter = Expression.Parameter(typeof(TSource), "a"); // a =>
            var expNew = Expression.New(typeof(TResult)); // Expression type for binding

            var bindings = typeof(TSource).GetProperties().SelectMany(property =>
            {
                var tResultProperty = typeof(TResult).GetProperty(property.Name);
                if (tResultProperty != null) // Get special fields from up property
                    return new List<MemberAssignment>() { BindingProperty<TResult>(property, expParameter) };
                else
                    return BindingNestedProperty<TResult>(property, expParameter);
            });
            var expMemberInit = Expression.MemberInit(expNew, bindings);
            var expLambda = Expression.Lambda<Func<TSource, TResult>>(expMemberInit, expParameter);

            var body = expLambda.Body;

            return expLambda.Compile();
        }
        public static Func<TSource, TResult> GetSelector<TSource, TResult>(List<string> specialFields)
        {
            var expParameter = Expression.Parameter(typeof(TSource), "a"); // a =>
            var expNew = Expression.New(typeof(TResult)); // Expression type for binding

            var bindings = typeof(TSource).GetProperties().SelectMany(property =>
            {
                if (specialFields.Contains(property.Name)) // Get special fields from up property
                    return new List<MemberAssignment>() { BindingProperty<TResult>(property, expParameter) };
                else
                    return BindingNestedProperty<TResult>(property, expParameter, specialFields);
            });
            var expMemberInit = Expression.MemberInit(expNew, bindings);
            var expLambda = Expression.Lambda<Func<TSource, TResult>>(expMemberInit, expParameter);

            var body = expLambda.Body;

            return expLambda.Compile();
        }
        private static MemberAssignment BindingProperty<TResult>(PropertyInfo property, Expression expParameter, ConstantExpression? nullConstOuter = null)
        {
            var tResultProperty = typeof(TResult).GetProperty(property.Name);
            if (tResultProperty != null)
            {
                var memberAccess = Expression.MakeMemberAccess(expParameter, property); // Access to property
                if (IsNullable(memberAccess.Type))
                {
                    var nullConst = Expression.Constant(null, memberAccess.Type); // Constant null from property
                    var test = Expression.Equal(expParameter, nullConstOuter!); // Equals up type and null const
                    var cond = Expression.Condition(test, nullConst, memberAccess); // Set condition if up type is null then null else  up.property
                    return Expression.Bind(tResultProperty, cond); // Binding
                }
                return Expression.Bind(tResultProperty, memberAccess); // Binding
            }
            else
                throw new ArgumentNullException();
        }
        private static IEnumerable<MemberAssignment> BindingNestedProperty<TResult>(PropertyInfo property, ParameterExpression expParameter)
        {
            var innerExpParameter = Expression.Property(expParameter, property.Name); // Get property
            var nullConstOuter = Expression.Constant(null, innerExpParameter.Type); // Constant null for property for equals
            var expressions = property.PropertyType.GetProperties()
                                                   .Select(innProperty => BindingProperty<TResult>(innProperty, innerExpParameter, nullConstOuter));
            return expressions;
        }
        private static IEnumerable<MemberAssignment> BindingNestedProperty<TResult>(PropertyInfo property, ParameterExpression expParameter, List<string> specialFields)
        {
            var innerExpParameter = Expression.Property(expParameter, property.Name); // Get property            
            ConstantExpression? nullConstOuter;
            if (IsNullable(innerExpParameter.Type))
                nullConstOuter = Expression.Constant(null, innerExpParameter.Type); // Constant null for property for equals
            else
                nullConstOuter = null;
            var expressions = property.PropertyType.GetProperties()
                                                   .Where(a => !specialFields.Contains(a.Name))
                                                   .Select(innProperty => BindingProperty<TResult>(innProperty, innerExpParameter, nullConstOuter));
            return expressions;
        }
        private static bool IsNullable(Type type)
        {
            if (!type.IsValueType || (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>)))
                return true;
            return false;
        }
    }
}
