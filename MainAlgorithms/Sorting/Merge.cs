using MainAlgorithms.Services;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainAlgorithms.Sorting
{
    public class Merge : BaseAlgorithm, ISort
    {
        public Merge(IStat? stat) : base(stat, nameof(Merge)){}
        public bool CanMore100K()
        {
            return true;
        }
        /// <summary>
        /// Merge sort
        /// - Bad O(n log n)
        /// - Avg O(n log n)
        /// - Good O(n log n)
        /// </summary>
        /// <param name="list"></param>
        public void Sort(List<int> list)
        {
            _stat!.GetSW().Start();
            if (list.Any())
            {
                int[] buffer = new int[list.Count];
                MergeSortImpl(list, buffer, 0, list.Count - 1);
            }
            _stat.GetSW().Stop();
            _stat.SetAlgorithmSize(list.Count);
            _stat.PrintStat();
        }
        void MergeSortImpl(List<int> list, int[] buffer, int left, int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;
                MergeSortImpl(list, buffer, left, mid);
                MergeSortImpl(list, buffer, mid + 1, right);
                int k = left;
                for (int i = left, j = mid + 1; i <= mid || j <= right;)
                {
                    if (_stat!.Iteration(j) > right || (i <= mid && list[i] < list[j]))
                    {
                        buffer[k] = list[i];
                        i++;
                    }
                    else
                    {
                        buffer[k] = list[j];
                        j++;
                    }
                    k++;
                }
                for (int i = left; i <= right; _stat!.Iteration(i++))
                    list[i] = buffer[i];
            }
        }
    }
}
