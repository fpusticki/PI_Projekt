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
    public partial class frmCjenik : Form
    {
        public frmCjenik()
        {
            InitializeComponent();
        }

        private void frmCjenik_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bazaDataSet.Mjerna_jedinica' table. You can move, or remove it, as needed.
            this.mjerna_jedinicaTableAdapter.Fill(this.bazaDataSet.Mjerna_jedinica);
            // TODO: This line of code loads data into the 'bazaDataSet.Usluga' table. You can move, or remove it, as needed.
            this.uslugaTableAdapter.Fill(this.bazaDataSet.Usluga);
            // TODO: This line of code loads data into the 'bazaDataSet.Stavka_cjenika' table. You can move, or remove it, as needed.
            //this.stavka_cjenikaTableAdapter.FillByID_cjenika(this.bazaDataSet.Stavka_cjenika, ID_cjenika);
            this.stavka_cjenikaTableAdapter.Fill(this.bazaDataSet.Stavka_cjenika);

        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
