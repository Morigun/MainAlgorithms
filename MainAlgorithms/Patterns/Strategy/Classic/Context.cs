using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainAlgorithms.Patterns.Strategy.Classic
{
    public class Context
    {
        IStrategy _strategy;
        public Context(IStrategy strategy)
        {
            _strategy = strategy;
        }
        public void Process()
        {
            Console.WriteLine(_strategy.Algorithm().ToString());
        }
    }
}
