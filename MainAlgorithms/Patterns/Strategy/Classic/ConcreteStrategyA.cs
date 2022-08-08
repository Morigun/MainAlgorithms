using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainAlgorithms.Patterns.Strategy.Classic
{
    public class ConcreteStrategyA : IStrategy
    {
        public object Algorithm()
        {
            return "ConcreteStrategyA";
        }
    }
}
