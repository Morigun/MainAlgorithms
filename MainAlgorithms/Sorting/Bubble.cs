using MainAlgorithms.Services;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainAlgorithms.Sorting
{
    public class Bubble : BaseAlgorithm, ISort
    {
        public Bubble(IStat statService) : base(statService, nameof(Bubble)) { }

        public bool CanMore100K()
        {
            return false;
        }

        /// <summary>
        /// Bubble sort
        /// - Bad O(n^2)
        /// - Avg O(n^2)
        /// - Best O(n)
        /// - 2 цикла, первый по всем элементам, контролирует размер второго цикла, 
        ///   второй цикл сравнивает элемент итерации и следующий, 
        ///   если следующий меньше текущего, меняет местами
        /// </summary>
        /// <param name="list"></param>
        public void Sort(List<int> list)
        {
            _stat!.GetSW().Start();
            for (int i = 0; i + 1 < list.Count; _stat.Iteration(i++))
                for(int j = 0; j + 1 < list.Count - i; _stat.Iteration(j++))
                    if (list[j + 1] < list[j])
                        list.SwapWithNextRight(j);
            _stat.GetSW().Stop();
            _stat.SetAlgorithmSize(list.Count);
            _stat.PrintStat();
        }
    }
}
