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
    public partial class frmDodajAdmina : Form
    {
        public frmDodajAdmina()
        {
            InitializeComponent();
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
                this.adminBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.bazaDataSet);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Iznimka: " + ex.Message);
            }
        }

        private void frmDodajAdmina_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bazaDataSet.Admin' table. You can move, or remove it, as needed.
            this.adminTableAdapter.Fill(this.bazaDataSet.Admin);
            adminBindingSource.AddNew();
        }
    }
}
