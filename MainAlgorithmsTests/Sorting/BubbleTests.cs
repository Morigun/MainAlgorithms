using Microsoft.VisualStudio.TestTools.UnitTesting;
using MainAlgorithms.Sorting;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainAlgorithms.Services;
using MainAlgorithmsTests;

namespace MainAlgorithms.Sorting.Tests
{
    [TestClass()]
    public class BubbleTests
    {
        [TestMethod()]
        public void TestPositive()
        {
            var arr = TestData.Exp10ArrPositive.ToList();
            arr.Reverse();
            new Bubble(new StatService()).Sort(arr);
            Assert.IsTrue(TestData.CompareArrays(TestData.Exp10ArrPositive, arr));
        }
        [TestMethod()]
        public void TestNegative()
        {
            var arr = TestData.Exp10ArrNegative.ToList();
            arr.Reverse();
            new Bubble(new StatService()).Sort(arr);
            Assert.IsTrue(TestData.CompareArrays(TestData.Exp10ArrNegative, arr));
        }
        [TestMethod()]
        public void TestAllSigns()
        {
            var arr = TestData.Exp10ArrAllSigns.ToList();
            arr.Reverse();
            new Bubble(new StatService()).Sort(arr);
            Assert.IsTrue(TestData.CompareArrays(TestData.Exp10ArrAllSigns, arr));
        }
    }
}