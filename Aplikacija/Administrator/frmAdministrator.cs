using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikacija
{
    public partial class frmAdministrator : Form
    {
        public frmAdministrator()
        {
            InitializeComponent();
        }

        private void miFileOdjava_Click(object sender, EventArgs e)
        {
            this.Close();
            Login.LoginForma.txtIme = null;
            Login.LoginForma.txtPassword = null;
            Login.LoginForma.Show();
        }

        private void miUsluge_Click(object sender, EventArgs e)
        {
            Administrator.frmUsluge usluge = new Administrator.frmUsluge();
            usluge.MdiParent = this;
            usluge.WindowState = FormWindowState.Maximized;
            usluge.Show();
            
        }

        private void miCjenici_Click(object sender, EventArgs e)
        {
            Administrator.frmCjenici cjenici = new Administrator.frmCjenici();
            cjenici.MdiParent = this;
            cjenici.WindowState = FormWindowState.Maximized;
            cjenici.Show();
        }

        private void miKorisnici_Click(object sender, EventArgs e)
        {
            Administrator.frmKorisnici korisnici = new Administrator.frmKorisnici();
            korisnici.MdiParent = this;
            korisnici.WindowState = FormWindowState.Maximized;
            korisnici.Show();
        }

        private void miCRM_Click(object sender, EventArgs e)
        {
            Administrator.frmCRM crm = new Administrator.frmCRM();
            crm.MdiParent = this;
            crm.WindowState = FormWindowState.Maximized;
            crm.Show();
        }

        private void miPostavke_Click(object sender, EventArgs e)
        {
            Administrator.frmPostavke postavke = new Administrator.frmPostavke();
            postavke.MdiParent = this;
            postavke.WindowState = FormWindowState.Maximized;
            postavke.Show();
        }

        private void frmAdministrator_Load(object sender, EventArgs e)
        {

        }



    }
}
