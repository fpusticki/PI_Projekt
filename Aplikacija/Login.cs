using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikacija
{
    public class Login
    {
        private static frmPrijava _LoginForma;

        public static frmPrijava LoginForma
        {            
            get
            {
                if ( _LoginForma == null)
                {
                    _LoginForma = new frmPrijava();
                }
                return _LoginForma;
            }
        }
    }
}
