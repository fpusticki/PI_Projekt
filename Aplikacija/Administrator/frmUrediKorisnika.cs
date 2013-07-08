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
    public partial class frmUrediKorisnika : Form
    {
        private frmKorisnici korisnici = null;

        public frmUrediKorisnika(frmKorisnici f)
        {
            InitializeComponent();
            korisnici = f;
        }

        private void frmUrediKorisnika_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bazaDataSet.Korisnik' table. You can move, or remove it, as needed.
            //this.korisnikTableAdapter.Fill(this.bazaDataSet.Korisnik);
            imeTextBox.Text = korisnici.Ime_korisnika.ToString();
            prezimeTextBox.Text = korisnici.Prezime_korisnika.ToString();
            usernameTextBox.Text = korisnici.Username_korisnika.ToString();
            lozinkaTextBox.Text = korisnici.Lozinka_korisnika.ToString();
        }

        private void btnPonisti_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.korisnikBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.bazaDataSet);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Iznimka: " + ex.Message);
            }
        }
    }
}
