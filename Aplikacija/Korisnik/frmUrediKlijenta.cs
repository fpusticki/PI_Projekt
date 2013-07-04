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
        public frmUrediKlijenta()
        {
            InitializeComponent();
        }

        private void frmUrediKlijenta_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bazaDataSet.Klijent' table. You can move, or remove it, as needed.
            this.klijentTableAdapter.Fill(this.bazaDataSet.Klijent);

        }

        private void btnPonisti_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.klijentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bazaDataSet);
            this.Close();
        }
    }
}
