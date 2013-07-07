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
        private bool Editing { get; set; }
        public int ID_cjenika { get; set; }

        public frmDodajCjenik()
        {
            InitializeComponent();
            ID_cjenika = -10;
        }

        public frmDodajCjenik(int id_cjenika)
        {
            InitializeComponent();
            this.ID_cjenika = id_cjenika;
            this.Editing = true;
        }

        private void frmDodajCjenik_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bazaDataSet.Cjenik' table. You can move, or remove it, as needed.
            // this.cjenikTableAdapter.Fill(this.bazaDataSet.Cjenik);
            if (this.ID_cjenika != -10)
            {
                // tu treba provjeriti !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                this.cjenikTableAdapter.Fill(this.bazaDataSet.Cjenik);
            }
            else
            {
                cjenikBindingSource.AddNew();
            }
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
        }

        private void btnDodajStavke_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cjenikBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bazaDataSet);

            int ID_cjenika = (int)bazaDataSet.Cjenik.Rows[0]["ID_cjenika"];
            frmDodajStavkuCjenika novaStavkaCjenika = new frmDodajStavkuCjenika(ID_cjenika);
            if (Editing) novaStavkaCjenika.Editing = true;
            novaStavkaCjenika.ShowDialog();
        }

        private void chbVazeci_CheckedChanged(object sender, EventArgs e)
        {
        }
    }
}
