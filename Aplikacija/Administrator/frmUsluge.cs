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
        public int ID_usluge { get; set; }
        public string naziv { get; set; }
        public string opis { get; set; }
        public float cijena { get; set; }

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
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvUsluge_SelectionChanged(object sender, EventArgs e)
        {
            this.ID_usluge = int.Parse(dgvUsluge["iDuslugeDataGridViewTextBoxColumn", dgvUsluge.CurrentRow.Index].Value.ToString());
            this.naziv = dgvUsluge["nazivDataGridViewTextBoxColumn", dgvUsluge.CurrentRow.Index].Value.ToString();
            this.opis = dgvUsluge["opisDataGridViewTextBoxColumn", dgvUsluge.CurrentRow.Index].Value.ToString();
            this.cijena = float.Parse(dgvUsluge["cijenaDataGridViewTextBoxColumn", dgvUsluge.CurrentRow.Index].Value.ToString());
        }
    }
}
