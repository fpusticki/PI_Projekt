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
    public partial class frmUsluge : Form
    {
        public frmUsluge()
        {
            InitializeComponent();
        }

        private void frmUsluge_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bazaDataSet.Mjerna_jedinica' table. You can move, or remove it, as needed.
            this.mjerna_jedinicaTableAdapter.Fill(this.bazaDataSet.Mjerna_jedinica);
            // TODO: This line of code loads data into the 'bazaDataSet.Usluga' table. You can move, or remove it, as needed.
            this.uslugaTableAdapter.Fill(this.bazaDataSet.Usluga);
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            frmDodajUslugu novaUsluga = new frmDodajUslugu();
            novaUsluga.ShowDialog();
            this.uslugaTableAdapter.Fill(this.bazaDataSet.Usluga);
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Želite li obrisati uslugu?", "Brisanje usluge", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                dgvUsluge.Rows.RemoveAt(dgvUsluge.CurrentRow.Index);
            }
            this.Validate();
            this.uslugaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bazaDataSet);
        }
    }
}
