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
        public frmDodajStavkuCjenika()
        {
            InitializeComponent();
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
            //this.stavka_cjenikaTableAdapter.FillByID_cjenika(this.bazaDataSet.Stavka_cjenika, ID_cjenika);
            stavka_cjenikaBindingSource.AddNew();
        }

        private void btnOdabir_Click(object sender, EventArgs e)
        {
            frmUsluge popisUsluga = new frmUsluge();
            popisUsluga.ShowDialog();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.stavka_cjenikaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bazaDataSet);
            Close();
        }

        private void btnPonisti_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
