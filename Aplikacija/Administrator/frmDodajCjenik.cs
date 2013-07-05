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
    public partial class frmDodajCjenik : Form
    {
        public frmDodajCjenik()
        {
            InitializeComponent();
        }

        private void frmDodajCjenik_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bazaDataSet.Cjenik' table. You can move, or remove it, as needed.
            this.cjenikTableAdapter.Fill(this.bazaDataSet.Cjenik);
            cjenikBindingSource.AddNew();
        }

        private void btnPonisti_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cjenikBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bazaDataSet);
            this.Close();
        }

        private void btnDodajStavke_Click(object sender, EventArgs e)
        {          
        }

        private void chbVazeci_CheckedChanged(object sender, EventArgs e)
        {
        }
    }
}
