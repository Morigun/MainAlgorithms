using MainAlgorithms.Services;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainAlgorithms.Shuffle
{
    public class GuidShuffle : BaseAlgorithm, IShuffle
    {
        public GuidShuffle(IStat statService) : base(statService, nameof(GuidShuffle)) { }
        /// <summary>
        /// Guid shuffle
        /// - Bad O(n)
        /// - Avg O(n)
        /// - Best O(n)
        /// </summary>
        /// <param name="list"></param>
        public void Shuffle(List<int> list)
        {
            _stat!.GetSW().Start();
            list.OrderBy(a => _stat.Iteration(Guid.NewGuid()))
                .Select((a, i) => new {a, i = _stat.Iteration(i)})
                .ToList()
                .ForEach(val => list[_stat.Iteration(val.i)] = val.a);
            _stat.GetSW().Stop();
            _stat.SetAlgorithmSize(list.Count);
            _stat.PrintStat();
        }
    }
}
