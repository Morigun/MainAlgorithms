using Microsoft.VisualStudio.TestTools.UnitTesting;
using MainAlgorithms.Reserch;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainAlgorithms.Reserch.Tests
{
    [TestClass()]
    public class BaseTestTests
    {
        [TestMethod()]
        public void TestTest()
        {
            Assert.IsTrue(new BaseTest().Test());
        }
    }
}