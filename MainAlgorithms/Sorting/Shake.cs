using MainAlgorithms.Services;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainAlgorithms.Sorting
{
    public class Shake : BaseAlgorithm, ISort
    {
        public Shake(IStat? statService) : base(statService, nameof(Shake)) { }
        /// <summary>
        /// Shake sort
        /// - Bad O(n^2)
        /// - Avg O(n^2)
        /// - Good O(n)
        /// </summary>
        /// <param name="list"></param>
        public void Sort(List<int> list)
        {
            _stat!.GetSW().Start();
            if (!list.Any())
                return;
            int left = 0;
            int right = list.Count - 1;
            while(left <= right)
            {
                for (int i = right; i > left; _stat.Iteration(--i))
                    if (list[i - 1] > list[i])
                        list.SwapWithPrevLeft(i);
                ++left;
                for (int i = left; i < right; _stat.Iteration(++i))
                    if (list[i] > list[i + 1])
                        list.SwapWithNextRight(i);
                _stat.Iteration(--right);
            }
            _stat.GetSW().Stop();
            _stat.SetAlgorithmSize(list.Count);
            _stat.PrintStat();
        }
    }
}
