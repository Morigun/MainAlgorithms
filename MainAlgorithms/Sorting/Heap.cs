using MainAlgorithms.Services;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainAlgorithms.Sorting
{
    public class Heap : BaseAlgorithm, ISort
    {
        public Heap(IStat? stat) : base(stat, nameof(Heap)){}
        /// <summary>
        /// Sort heap
        /// - Bad O(n log n)
        /// - Avg O(n log n)
        /// - Good O(n log n)
        /// </summary>
        /// <param name="list"></param>
        public void Sort(List<int> list)
        {
            _stat!.GetSW().Start();
            int len = list.Count;

            for (int i = len / 2 - 1; i >= 0; _stat.Iteration(i--))
                Heapify(list, len, i);

            for (int i = len - 1; i >= 0; _stat.Iteration(i--))
            {
                list.SwapTwoIndex(0, i);
                Heapify(list, i, 0);
            }
            _stat.GetSW().Stop();
            _stat.SetAlgorithmSize(list.Count);
            _stat.PrintStat();
        }

        void Heapify(List<int> list, int len, int i)
        {
            int max = i;

            int left = 2 * i + 1;
            int right = 2 * i + 2;

            if (left < len && list[left] > list[max])
                max = left;

            if (right < len && list[right] > list[max])
                max = right;

            if (max != i)
            {
                list.SwapTwoIndex(i, max);
                Heapify(list, len, max);
            }
        }
    }
}
