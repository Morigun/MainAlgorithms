using MainAlgorithms.Services;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainAlgorithms
{
    public abstract class BaseAlgorithm : IDisposable
    {
        protected IStat? _stat;
        public BaseAlgorithm(IStat? stat, string name)
        {
            _stat = stat;
            _stat!.SetAlgorithmName(name);
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
                _stat = null;
            }
            IsDisposed = true;
        }
        ~BaseAlgorithm()
        {
            Dispose(false);
        }
        #endregion
    }
}
