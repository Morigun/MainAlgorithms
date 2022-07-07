using MainAlgorithms.Services;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainAlgorithms.Sorting
{
    internal class Linq : BaseAlgorithm, ISort
    {
        public Linq(IStat? stat) : base(stat, nameof(Linq)){}

        public void Sort(List<int> list)
        {
            _stat!.GetSW().Start();
            var tmp = list.OrderBy(a => a).ToList();
            _stat.GetSW().Stop();
            for (int i = 0; i < tmp.Count; i++)
                list[i] = tmp[i];
            _stat.SetAlgorithmSize(list.Count);
            _stat.PrintStat();
        }
    }
}
