using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainAlgorithms.Sorting
{
    interface ISort
    {
        void Sort(List<int> list);
        bool CanMore100K();
    }
}
