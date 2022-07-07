using MainAlgorithms.Services;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainAlgorithms.Sorting
{
    public class Quick : BaseAlgorithm, ISort
    {
        public Quick(IStat? stat) : base(stat, nameof(Quick)){}
        /// <summary>
        /// Quick sort
        /// - Bad O(n^2)
        /// - Avg O(n log n)
        /// - Good O(n)
        /// </summary>
        /// <param name="list"></param>
        public void Sort(List<int> list)
        {
            _stat!.GetSW().Start();
            if (list.Any())
                QuickSortImpl(list, 0, list.Count - 1);
            _stat.GetSW().Stop();
            _stat.SetAlgorithmSize(list.Count);
            _stat.PrintStat();
        }
        private int Partition(List<int> list, int left, int right)
        {
            int x = list[right];
            int less = left;
            for(int i = left; i < right; _stat!.Iteration(i++))
                if (list[i] <= x)
                    list.SwapTwoIndex(i, less++);
            list.SwapTwoIndex(less, right);
            return less;
        }
        void QuickSortImpl(List<int> list, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(list, left, right);
                QuickSortImpl(list, left, pivot - 1);
                QuickSortImpl(list, pivot + 1, right);
            }
        }
    }
}
