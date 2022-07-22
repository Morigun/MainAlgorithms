using Microsoft.VisualStudio.TestTools.UnitTesting;
using MainAlgorithms.SOLID;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainAlgorithms.SOLID.Tests
{
    [TestClass()]
    public class RectangleTestTests
    {
        [TestMethod()]
        public void PerimetrTest()
        {
            var perimetr = new RectangleTest().Perimetr(5, 7);

            Assert.AreEqual(24, perimetr);
        }
    }
}