using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainAlgorithms
{
    static class AlgorithmExtensions
    {
        public static void SwapWithNextLeft(this List<int> list, int idx)
        {
            (list[idx + 1], list[idx]) = (list[idx], list[idx + 1]);
        }
        public static void SwapWithNextRight(this List<int> list, int idx)
        {
            (list[idx], list[idx + 1]) = (list[idx + 1], list[idx]);
        }
        public static void SwapWithPrevLeft(this List<int> list, int idx)
        {
            (list[idx - 1], list[idx]) = (list[idx], list[idx - 1]);
        }
        public static void SwapWithPrevRight(this List<int> list, int idx)
        {
            (list[idx], list[idx - 1]) = (list[idx - 1], list[idx]);
        }
        public static void SwapTwoIndex(this List<int> list, int idx1, int idx2)
        {
            (list[idx1], list[idx2]) = (list[idx2], list[idx1]);
        }
        public static Random GetRandom()
        {
            return new Random(Environment.TickCount);
        }
    }
}
