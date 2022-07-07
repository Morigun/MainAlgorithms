using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainAlgorithms.Services
{
    public interface IStat : IDisposable
    {
        Stopwatch GetSW();
        T Iteration<T>(T value);
        int GetCountIterations();
        void PrintStat();
        void SetAlgorithmName(string name);
        void SetAlgorithmSize(int size);
    }
}
