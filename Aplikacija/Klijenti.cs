using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacija
{
    class Klijenti:IDisposable
    {
        private bool _disposed;
        private System.IO.Stream _resource;

        private int dan;
        private int mjesec;
        private int godina;

        public int Dan { get { return dan; } set { dan = value; ;} }
        public int Mjesec { get { return mjesec; } set { mjesec = value; ;} }
        public int Godina { get { return godina; } set { godina = value; ;} }

        public void Dispose()
        {
            Dispose(true);

            // Use SupressFinalize in case a subclass 
            // of this type implements a finalizer.
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            // If you need thread safety, use a lock around these  
            // operations, as well as in your methods that use the resource. 
            if (!_disposed)
            {
                if (disposing)
                {
                    if (_resource != null)
                        _resource.Dispose();
                }

                // Indicate that the instance has been disposed.
                _resource = null;
                _disposed = true;
            }
        }

    }
}
