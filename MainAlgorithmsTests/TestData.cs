using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainAlgorithmsTests
{
    internal class TestData
    {
        enum TypeArray { POSITIVE, NEGATIVE, ALL_SIGNS }
        public static List<int> Exp1ArrPositive = new List<int> { 0 };
        public static List<int> Exp1ArrNegative = new List<int> { -1 };
        public static List<int> Exp10ArrPositive = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        public static List<int> Exp10ArrNegative = new List<int> { -9, -8, -7, -6, -5, -4, -3, -2, -1 };
        public static List<int> Exp10ArrAllSigns = new List<int> { -9, -8, -7, -6, -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        public static List<int> Exp100ArrPositive => GetArray(100, TypeArray.POSITIVE).ToList();
        public static List<int> Exp100ArrNegative => GetArray(100, TypeArray.NEGATIVE).ToList();
        public static List<int> Exp100ArrAllSigns => GetArray(100, TypeArray.ALL_SIGNS).ToList();
        public static List<int> Exp1000ArrPositive => GetArray(1000, TypeArray.POSITIVE).ToList();
        public static List<int> Exp1000ArrNegative => GetArray(1000, TypeArray.NEGATIVE).ToList();
        public static List<int> Exp1000ArrAllSigns => GetArray(1000, TypeArray.ALL_SIGNS).ToList();
        public static List<int> Exp10000ArrPositive => GetArray(10000, TypeArray.POSITIVE).ToList();
        public static List<int> Exp10000ArrNegative => GetArray(10000, TypeArray.NEGATIVE).ToList();
        public static List<int> Exp10000ArrAllSigns => GetArray(10000, TypeArray.ALL_SIGNS).ToList();
        public static List<int> Exp100000ArrPositive => GetArray(100000, TypeArray.POSITIVE).ToList();
        public static List<int> Exp100000ArrNegative => GetArray(100000, TypeArray.NEGATIVE).ToList();
        public static List<int> Exp100000ArrAllSigns => GetArray(100000, TypeArray.ALL_SIGNS).ToList();
        public static bool CompareArrays(List<int> arr1, List<int> arr2)
        {
            for (int i = 0; i < arr1.Count; i++)
                if (arr1[i] != arr2[i])
                    return false;
            return true;
        }
        private static IEnumerable<int> GetArray(int size, TypeArray type)
        {
            if (type == TypeArray.POSITIVE)
                for (int i = 0; i < size; i++)
                    yield return i;
            else if (type == TypeArray.NEGATIVE)
                for (int i = -(size - 1); i < 0; i++)
                    yield return i;
            else
                for (int i = -(size / 2 - 1); i < (size / 2); i++)
                    yield return i;
            yield break;
        }
    }
}
