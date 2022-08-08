using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainAlgorithms.Patterns.Strategy.Delegate
{
    public class Use
    {
        public void Run()
        {
            Context context = new Context(() =>
            {
                return "Test strategy";
            });
            context.Process();
            context = new Context(() =>
            {
                return "Test next strategy";
            });
            context.Process();
        }
    }
}
