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
    public class BaseTests
    {
        [TestMethod()]
        public void PropertyTest()
        {
            Base B = new Base();
            Assert.AreEqual("Base", B.Property);
        }
        [TestMethod()]
        public void VirtualPropertyTest()
        {
            Base B = new Base();
            Assert.AreEqual("Base", B.VirtualProperty);
        }
        [TestMethod()]
        public void GetStringTest()
        {
            Base B = new Base();
            Assert.AreEqual("Base", B.GetString());
        }
        [TestMethod()]
        public void GetVirtualStringTest()
        {
            Base B = new Base();
            Assert.AreEqual("Base", B.GetVirtualString());
        }
    }
}