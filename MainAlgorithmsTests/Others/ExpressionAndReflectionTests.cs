using Microsoft.VisualStudio.TestTools.UnitTesting;
using MainAlgorithms.Others;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainAlgorithms.Others.Tests
{
    [TestClass()]
    public class ExpressionAndReflectionTests
    {
        public class TestChildClass : ExpressionAndReflection.TestClass
        {
            public int? AddField { get; set; }
        }
        List<TestChildClass> outerTestData = new List<TestChildClass>
            {
                new TestChildClass
                {
                    ID = Guid.NewGuid(),
                    Date = DateTime.Now.Date,
                    AddField = 1
                },
                new TestChildClass
                {
                    ID = Guid.NewGuid(),
                    Date = DateTime.Now.Date,
                    AddField = 2
                },
            };
        [TestMethod()]
        public void RunTest()
        {
            List<Guid> testIDs = new List<Guid>
            {
                Guid.NewGuid(),
                outerTestData.First().ID,
                outerTestData.Last().ID,
            };

            var result = ExpressionAndReflection.LeftJoin(testIDs, outerTestData);

            Assert.IsTrue(result.Any());
        }

        [TestMethod()]
        public void LeftJoinAleterTest()
        {
            List<Guid> testIDs = new List<Guid>
            {
                Guid.NewGuid(),
                outerTestData.First().ID,
                outerTestData.Last().ID,
            };

            var result = ExpressionAndReflection.LeftJoinAleter(testIDs, 
                                                                outerTestData,
                                                                a => new { ID = a, Date = DateTime.Now },
                                                                b => new { ID = b.ID, Date = b.Date});

            Assert.IsTrue(result.Any());
        }
    }
}