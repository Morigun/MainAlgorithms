using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainAlgorithms.Services
{
    public class StatService : IStat
    {
        int _countIterations = 0;
        Stopwatch? sw = new Stopwatch();
        string _algorithmName = string.Empty;
        int _size;

        public int GetCountIterations()
        {
            return _countIterations;
        }

        public Stopwatch GetSW()
        {
            return sw!;
        }

        public T Iteration<T>(T value)
        {
            _countIterations++;
            return value;
        }

        public void PrintStat()
        {
            Console.WriteLine();
            Console.WriteLine($"Name: {_algorithmName}");
            Console.WriteLine($"Count items:{_size}");
            Console.WriteLine($"Iterations:{_countIterations}");
            Console.WriteLine($"Time: {sw!.ElapsedMilliseconds}ms");
            Console.WriteLine();
        }

        public void SetAlgorithmName(string name)
        {
            _algorithmName = name;
        }

        public void SetAlgorithmSize(int size)
        {
            _size = size;
        }

        #region Disposing
        private bool IsDisposed = false;
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (IsDisposed) return;
            if (disposing)
            {
                sw = null;
            }
            IsDisposed = true;
        }
        ~StatService()
        {
            Dispose(false);
        }
        #endregion
    }
}
