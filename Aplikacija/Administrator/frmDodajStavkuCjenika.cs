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
    public partial class frmDodajStavkuCjenika : Form
    {
        public int ID_cjenika { get; set; }
        public bool Editing { get; set; }

        public frmDodajStavkuCjenika(int id_cjenika)
        {
            InitializeComponent();
            this.ID_cjenika = id_cjenika;
            Editing = false;
        }

        private void frmDodajStavkuCjenika_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bazaDataSet.Mjerna_jedinica' table. You can move, or remove it, as needed.
            this.mjerna_jedinicaTableAdapter.Fill(this.bazaDataSet.Mjerna_jedinica);
            // TODO: This line of code loads data into the 'bazaDataSet.Usluga' table. You can move, or remove it, as needed.
            this.uslugaTableAdapter.Fill(this.bazaDataSet.Usluga);
            // TODO: This line of code loads data into the 'bazaDataSet.Cjenik' table. You can move, or remove it, as needed.
            //this.cjenikTableAdapter.Fill(this.bazaDataSet.Cjenik);
            // TODO: This line of code loads data into the 'bazaDataSet.Stavka_cjenika' table. You can move, or remove it, as needed.
            this.stavka_cjenikaTableAdapter.FillByID_cjenika(this.bazaDataSet.Stavka_cjenika, ID_cjenika);
            //stavka_cjenikaBindingSource.AddNew();

            if (!Editing)
            {
                try
                {
                    this.stavka_cjenikaBindingSource.AddNew();
                    iD_cjenikaTextBox.Text = ID_cjenika.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Iznimka: " + ex.Message);
                }
            }
        }

        private void btnOdabir_Click(object sender, EventArgs e)
        {
            frmOdabirUsluga odabirUsluga = new frmOdabirUsluga();
            odabirUsluga.ShowDialog();

            iD_uslugeTextBox.Text = odabirUsluga.Usluga.ToString();
            cijenaTextBox.Text = odabirUsluga.Cijena_usluge.ToString();
            nazivTextBox.Text = odabirUsluga.Naziv_usluge.ToString();
            iD_mjerne_jediniceTextBox.Text = odabirUsluga.Mjerna_jedinica_usluge.ToString();
            opisTextBox.Text = odabirUsluga.Opis_usluge.ToString();
        }

        private void btnSpremi_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.stavka_cjenikaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bazaDataSet);
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                this.stavka_cjenikaBindingSource.AddNew();
                iD_cjenikaTextBox.Text = ID_cjenika.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Iznimka: " + ex.Message);
            }
        }

    }
}
