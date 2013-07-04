using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacija
{
    class CRM:IDisposable
    {
        //
        private bool _disposed;
        private System.IO.Stream _resource;

        private int vrijeme_provjere;
        private int broj_dolazaka;
        private string opis_popusta;

        public int VrijemeProvjere { get { return vrijeme_provjere; } set { vrijeme_provjere = value;} }
        public int BrojDolazaka { get { return broj_dolazaka; } set { broj_dolazaka = value;} }
        public string OpisPopusta { get { return opis_popusta; } set { opis_popusta = value;} }

        public void Dispose()
        {
            Dispose(true);
            
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    if (_resource != null)
                        _resource.Dispose();
                }

                _resource = null;
                _disposed = true;
            }
        }
    }
}
