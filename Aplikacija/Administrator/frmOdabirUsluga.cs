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
    public partial class frmOdabirUsluga : Form
    {
        public int Usluga { get; set; }
        public float Cijena_usluge { get; set; }
        public string Naziv_usluge { get; set; }
        public string Opis_usluge { get; set; }
        public string Mjerna_jedinica_usluge { get; set; }

        public frmOdabirUsluga()
        {
            InitializeComponent();
        }

        private void frmOdabirUsluga_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bazaDataSet.Mjerna_jedinica' table. You can move, or remove it, as needed.
            this.mjerna_jedinicaTableAdapter.Fill(this.bazaDataSet.Mjerna_jedinica);
            // TODO: This line of code loads data into the 'bazaDataSet.Usluga' table. You can move, or remove it, as needed.
            this.uslugaTableAdapter.Fill(this.bazaDataSet.Usluga);

        }

        private void btnPonisti_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvUsluge_SelectionChanged(object sender, EventArgs e)
        {
            this.Usluga = int.Parse(dgvUsluge["dataGridViewTextBoxColumn1", dgvUsluge.CurrentRow.Index].Value.ToString());
            this.Cijena_usluge = float.Parse(dgvUsluge["cijenaDataGridViewTextBoxColumn", dgvUsluge.CurrentRow.Index].Value.ToString());
            this.Naziv_usluge = dgvUsluge["nazivDataGridViewTextBoxColumn", dgvUsluge.CurrentRow.Index].Value.ToString();
            this.Opis_usluge = dgvUsluge["opisDataGridViewTextBoxColumn", dgvUsluge.CurrentRow.Index].Value.ToString();
            this.Mjerna_jedinica_usluge = dgvUsluge["iDmjernejediniceDataGridViewTextBoxColumn", dgvUsluge.CurrentRow.Index].Value.ToString();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
