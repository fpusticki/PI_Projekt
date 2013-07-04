using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Aplikacija.Administrator
{
    public partial class frmDodajUslugu : Form
    {
        public frmDodajUslugu()
        {
            InitializeComponent();
        }

        private void frmDodajUslugu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bazaDataSet.Mjerna_jedinica' table. You can move, or remove it, as needed.
            this.mjerna_jedinicaTableAdapter.Fill(this.bazaDataSet.Mjerna_jedinica);
            // TODO: This line of code loads data into the 'bazaDataSet.Usluga' table. You can move, or remove it, as needed.
            //this.uslugaTableAdapter.Fill(this.bazaDataSet.Usluga);
            uslugaBindingSource.AddNew();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.uslugaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bazaDataSet);
            this.Close();
        }

        private void btnPonisti_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
