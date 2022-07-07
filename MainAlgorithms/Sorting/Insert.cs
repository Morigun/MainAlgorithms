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
        public Insert(IStat? statService) : base(statService, nameof(Insert)){}
        /// <summary>
        /// Insert sort
        /// - Bad O(n^2)
        /// - Avg O(n^2)
        /// - Good O(n)
        /// </summary>
        /// <param name="list"></param>
        public void Sort(List<int> list)
        {
            _stat!.GetSW().Start();
            for (int i = 1; i < list.Count; _stat!.Iteration(i++))
            {
                int x = list[i];
                int j = i;
                while(_stat.Iteration(j > 0) && list[j - 1] > x)
                {
                    list[j] = list[j - 1];
                    --j;
                }
                list[j] = x;
            }
            _stat.GetSW().Stop();
            _stat.SetAlgorithmSize(list.Count);
            _stat.PrintStat();
        }
    }
}
