using MainAlgorithms.Services;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainAlgorithms.Sorting
{
    public class Insert : BaseAlgorithm, ISort
    {
        public Insert(IStat? stat) : base(stat, nameof(Insert)){}

        public void Sort(List<int> list)
        {
            throw new NotImplementedException();
        }
    }
}
