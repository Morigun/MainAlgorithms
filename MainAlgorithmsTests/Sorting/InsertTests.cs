using Microsoft.VisualStudio.TestTools.UnitTesting;
using MainAlgorithms.Sorting;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainAlgorithmsTests;
using MainAlgorithms.Services;

namespace MainAlgorithms.Sorting.Tests
{
    [TestClass()]
    public class InsertTests
    {
        [TestMethod()]
        public void TestPositive()
        {
            var arr = TestData.Exp10ArrPositive.ToList();
            arr.Reverse();
            new Insert(new StatService()).Sort(arr);
            Assert.IsTrue(TestData.CompareArrays(TestData.Exp10ArrPositive, arr));
        }
        [TestMethod()]
        public void TestNegative()
        {
            var arr = TestData.Exp10ArrNegative.ToList();
            arr.Reverse();
            new Insert(new StatService()).Sort(arr);
            Assert.IsTrue(TestData.CompareArrays(TestData.Exp10ArrNegative, arr));
        }
        [TestMethod()]
        public void TestAllSigns()
        {
            var arr = TestData.Exp10ArrAllSigns.ToList();
            arr.Reverse();
            new Insert(new StatService()).Sort(arr);
            Assert.IsTrue(TestData.CompareArrays(TestData.Exp10ArrAllSigns, arr));
        }
        [TestMethod()]
        public void Test1Positive()
        {
            var arr = TestData.Exp1ArrPositive.ToList();
            arr.Reverse();
            new Insert(new StatService()).Sort(arr);
            Assert.IsTrue(TestData.CompareArrays(TestData.Exp1ArrPositive, arr));
        }
        [TestMethod()]
        public void Test1Negative()
        {
            var arr = TestData.Exp1ArrNegative.ToList();
            arr.Reverse();
            new Insert(new StatService()).Sort(arr);
            Assert.IsTrue(TestData.CompareArrays(TestData.Exp1ArrNegative, arr));
        }
        [TestMethod()]
        public void Test100Positive()
        {
            var arr = TestData.Exp100ArrPositive.ToList();
            arr.Reverse();
            new Insert(new StatService()).Sort(arr);
            Assert.IsTrue(TestData.CompareArrays(TestData.Exp100ArrPositive, arr));
        }
        [TestMethod()]
        public void Test100Negative()
        {
            var arr = TestData.Exp100ArrNegative.ToList();
            arr.Reverse();
            new Insert(new StatService()).Sort(arr);
            Assert.IsTrue(TestData.CompareArrays(TestData.Exp100ArrNegative, arr));
        }
        [TestMethod()]
        public void Test100AllSigns()
        {
            var arr = TestData.Exp100ArrAllSigns.ToList();
            arr.Reverse();
            new Insert(new StatService()).Sort(arr);
            Assert.IsTrue(TestData.CompareArrays(TestData.Exp100ArrAllSigns, arr));
        }
        [TestMethod()]
        public void Test1000Positive()
        {
            var arr = TestData.Exp1000ArrPositive.ToList();
            arr.Reverse();
            new Insert(new StatService()).Sort(arr);
            Assert.IsTrue(TestData.CompareArrays(TestData.Exp1000ArrPositive, arr));
        }
        [TestMethod()]
        public void Test1000Negative()
        {
            var arr = TestData.Exp1000ArrNegative.ToList();
            arr.Reverse();
            new Insert(new StatService()).Sort(arr);
            Assert.IsTrue(TestData.CompareArrays(TestData.Exp1000ArrNegative, arr));
        }
        [TestMethod()]
        public void Test1000AllSigns()
        {
            var arr = TestData.Exp1000ArrAllSigns.ToList();
            arr.Reverse();
            new Insert(new StatService()).Sort(arr);
            Assert.IsTrue(TestData.CompareArrays(TestData.Exp1000ArrAllSigns, arr));
        }
        [TestMethod()]
        public void Test10000Positive()
        {
            var arr = TestData.Exp10000ArrPositive.ToList();
            arr.Reverse();
            new Insert(new StatService()).Sort(arr);
            Assert.IsTrue(TestData.CompareArrays(TestData.Exp10000ArrPositive, arr));
        }
        [TestMethod()]
        public void Test10000Negative()
        {
            var arr = TestData.Exp10000ArrNegative.ToList();
            arr.Reverse();
            new Insert(new StatService()).Sort(arr);
            Assert.IsTrue(TestData.CompareArrays(TestData.Exp10000ArrNegative, arr));
        }
        [TestMethod()]
        public void Test10000AllSigns()
        {
            var arr = TestData.Exp10000ArrAllSigns.ToList();
            arr.Reverse();
            new Insert(new StatService()).Sort(arr);
            Assert.IsTrue(TestData.CompareArrays(TestData.Exp10000ArrAllSigns, arr));
        }
    }
}