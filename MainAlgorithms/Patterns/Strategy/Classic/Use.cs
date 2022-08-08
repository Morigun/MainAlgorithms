using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainAlgorithms.Patterns.Strategy.Classic
{
    public class Use
    {
        public void Run()
        {
            Context context = new Context(new ConcreteStrategyA());
            context.Process();
            context = new Context(new ConcreteStrategyB());
            context.Process();
        }
    }
}
