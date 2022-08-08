using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainAlgorithms.Patterns.Strategy.Delegate
{
    public class Context
    {
        Func<object> _algorithm;
        public Context(Func<object> Algorithm)
        {
            _algorithm = Algorithm;
        }
        public void Process()
        {
            Console.WriteLine(_algorithm().ToString());
        }
    }
}
