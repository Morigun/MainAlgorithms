using MainAlgorithms.Services;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainAlgorithms.Sorting
{
    public class Select : BaseAlgorithm, ISort
    {
        public Select(IStat? stat) : base(stat, nameof(Select)){}
        /// <summary>
        /// Select sort
        /// - Bad O(n^2)
        /// - Avg O(n^2)
        /// - Good O(n^2)
        /// </summary>
        /// <param name="list"></param>
        public void Sort(List<int> list)
        {
            _stat!.GetSW().Start();
            for(int i = 0; i < list.Count - 1; _stat.Iteration(i++))
            {
                int min = i;
                min = SearchMin(list, i, min);
                list.SwapTwoIndex(min, i);
            }
            _stat.GetSW().Stop();
            _stat.SetAlgorithmSize(list.Count);
            _stat.PrintStat();
        }

        private int SearchMin(List<int> list, int i, int min)
        {
            for (int j = i + 1; j < list.Count; _stat!.Iteration(j++))
                if (list[j] < list[min])
                    min = j;
            return min;
        }
    }
}
