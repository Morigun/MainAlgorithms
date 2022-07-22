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
    public class ChildTestTests
    {
        [TestMethod()]
        public void InitTest()
        {
            Assert.IsFalse(new ChildTest().Test());
        }
    }
}