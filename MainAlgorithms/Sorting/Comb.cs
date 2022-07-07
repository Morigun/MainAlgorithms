using MainAlgorithms.Services;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainAlgorithms.Sorting
{
    public class Comb : BaseAlgorithm, ISort
    {
        public Comb(IStat? statService) : base(statService, nameof(Comb)){}
        /// <summary>
        /// Sort comb
        /// - Bad O(n^2)
        /// - Avg Ω(n^2/2^p)
        /// - Good O(n log n)
        /// </summary>
        /// <param name="list"></param>
        public void Sort(List<int> list)
        {
            _stat!.GetSW().Start();
            int gap = list.Count; 
            bool swaps = true;

            while (_stat!.Iteration(gap > 1) || swaps)
            {
                gap = GetNextGap(gap);

                swaps = false;

                for (int i = 0; i < list.Count - gap; _stat.Iteration(i++))
                {
                    if (list[i] > list[i + gap])
                    {
                        list.SwapTwoIndex(i, i + gap);
                        swaps = true;
                    }
                }
            }
            _stat.GetSW().Stop();
            _stat.SetAlgorithmSize(list.Count);
            _stat.PrintStat();
        }

        private static int GetNextGap(int gap)
        {
            gap = (gap * 10) / 13;//Фактор уменьшения

            if (gap < 1)
                gap = 1;

            return gap;
        }
    }
}
