using MainAlgorithms.SOLID;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainAlgorithmsTests.SOLID
{
    [TestClass()]
    public class SquadTestTests
    {
        [TestMethod()]
        public void PerimetrTest()
        {
            var perimetr = new SquadTest().Perimetr(5, 7);

            Assert.AreEqual(24, perimetr);//Как мы видим периметр квадрата не равен периметру прямоугольника,
                                          //что является нарушением принципа подстановки лискова
        }
    }
}
