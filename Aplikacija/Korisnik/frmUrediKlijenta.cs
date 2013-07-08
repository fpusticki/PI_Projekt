using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikacija.Korisnik
{
    public partial class frmUrediKlijenta : Form
    {
        private frmKlijenti klijenti = null;

        public frmUrediKlijenta(frmKlijenti f)
        {
            InitializeComponent();
            klijenti = f;
        }

        private void frmUrediKlijenta_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bazaDataSet.Klijent' table. You can move, or remove it, as needed.
            //this.klijentTableAdapter.Fill(this.bazaDataSet.Klijent);

            imeTextBox.Text = klijenti.Ime.ToString();
            prezimeTextBox.Text = klijenti.Prezime.ToString();
            spolTextBox.Text = klijenti.Spol.ToString();
            emailTextBox.Text = klijenti.Email.ToString();
            telefonTextBox.Text = klijenti.Telefon.ToString();
            newsletterCheckBox.Checked = Convert.ToBoolean(klijenti.Newsletter);
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
                this.klijentBindingSource.EndEdit();
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
