using MainAlgorithms.Services;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainAlgorithms.Shuffle
{
    public class FisherYeyts : BaseAlgorithm, IShuffle
    {
        public FisherYeyts(IStat statService) : base(statService, nameof(FisherYeyts)) { }
        /// <summary>
        /// Fisher yeyts shuffle
        /// - Bad - O(n)
        /// - Avg O(n)
        /// - Best O(n)
        /// </summary>
        /// <param name="list"></param>
        public void Shuffle(List<int> list)
        {
            _stat!.GetSW().Start();
            var rand = AlgorithmExtensions.GetRandom();
            for (int i = list.Count - 1; i >= 1; _stat.Iteration(i--))
            {
                int j = rand.Next() % (i + 1);
                list.SwapTwoIndex(i, j);
            }
            _stat.GetSW().Stop();
            _stat.SetAlgorithmSize(list.Count);
            _stat.PrintStat();
        }
    }
}
