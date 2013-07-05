using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikacija.Administrator
{
    public partial class frmKorisnici : Form
    {
        public frmKorisnici()
        {
            InitializeComponent();
        }

        private void frmKorisnici_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bazaDataSet.Admin' table. You can move, or remove it, as needed.
            this.adminTableAdapter.Fill(this.bazaDataSet.Admin);
            // TODO: This line of code loads data into the 'bazaDataSet.Korisnik' table. You can move, or remove it, as needed.
            this.korisnikTableAdapter.Fill(this.bazaDataSet.Korisnik);
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDodajAdmin_Click(object sender, EventArgs e)
        {
            frmDodajAdmina noviAdmin = new frmDodajAdmina();
            noviAdmin.ShowDialog();
        }

        private void btnUrediAdmin_Click(object sender, EventArgs e)
        {

            frmUrediAdmina urediAdmina = new frmUrediAdmina();
            urediAdmina.ShowDialog();
        }

        private void btnDodajKorisnik_Click(object sender, EventArgs e)
        {
            frmDodajKorisnika noviKorisnik = new frmDodajKorisnika();
            noviKorisnik.ShowDialog();
        }

        private void btnUrediKorisnik_Click(object sender, EventArgs e)
        {
            frmUrediKorisnika urediKorisnika = new frmUrediKorisnika();
            urediKorisnika.ShowDialog();
        }
    }
}
