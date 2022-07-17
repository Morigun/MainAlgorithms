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
    public class ChildTests
    {
        [TestMethod()]
        public void PropertyTest()
        {
            Base C = new Child();
            Assert.AreEqual("Base", C.Property);
        }
        [TestMethod()]
        public void VirtualPropertyTest()
        {
            Child C = new Child();
            Assert.AreEqual("Child", C.VirtualProperty);
        }
        [TestMethod()]
        public void GetStringTest()
        {
            Base C = new Child();
            Assert.AreEqual("Base", C.GetString());

        }
        [TestMethod()]
        public void GetVirtualStringTest()
        {
            Child C = new Child();
            Assert.AreEqual("Child", C.GetVirtualString());

        }
    }
}