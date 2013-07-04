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
    public partial class frmCjenici : Form
    {
        public frmCjenici()
        {
            InitializeComponent();
        }

        private void frmCjenici_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bazaDataSet.Mjerna_jedinica' table. You can move, or remove it, as needed.
            this.mjerna_jedinicaTableAdapter.Fill(this.bazaDataSet.Mjerna_jedinica);
            // TODO: This line of code loads data into the 'bazaDataSet.Usluga' table. You can move, or remove it, as needed.
            this.uslugaTableAdapter.Fill(this.bazaDataSet.Usluga);
            // TODO: This line of code loads data into the 'bazaDataSet.Stavka_cjenika' table. You can move, or remove it, as needed.
            //this.stavka_cjenikaTableAdapter.Fill(this.bazaDataSet.Stavka_cjenika);
            // TODO: This line of code loads data into the 'bazaDataSet.Cjenik' table. You can move, or remove it, as needed.
            this.cjenikTableAdapter.Fill(this.bazaDataSet.Cjenik);
        }

        private void dgvCjenik_SelectionChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCjenik.RowCount > 0)
            {
                int ID_cjenika = int.Parse(dgvCjenik.CurrentRow.Cells[0].Value.ToString());
                this.stavka_cjenikaTableAdapter.FillByID_cjenika(this.bazaDataSet.Stavka_cjenika, ID_cjenika);
            }
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            frmDodajCjenik noviCjenik = new frmDodajCjenik();
            noviCjenik.ShowDialog();
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
        }
    }
}
