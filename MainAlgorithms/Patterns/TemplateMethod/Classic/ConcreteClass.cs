using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainAlgorithms.Patterns.TemplateMethod.Classic
{
    public class ConcreteClass : AbstractClass
    {
        public override void Operation1()
        {
            Console.WriteLine("Operation1");
        }

        public override void Operation2()
        {
            Console.WriteLine("Operation2");
        }
    }
}
