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
    public partial class frmNoviCjenik : Form
    {
        public int ID_novog_cjenika { get; set; }

        public frmNoviCjenik(int id_novog_cjenika)
        {
            InitializeComponent();          
            this.ID_novog_cjenika = id_novog_cjenika;
        }

        private void frmNoviCjenik_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bazaDataSet.Cjenik' table. You can move, or remove it, as needed.
            this.cjenikTableAdapter.Fill(this.bazaDataSet.Cjenik);
            // TODO: This line of code loads data into the 'bazaDataSet.Stavka_cjenika' table. You can move, or remove it, as needed.
            this.stavka_cjenikaTableAdapter.FillByID_cjenika(this.bazaDataSet.Stavka_cjenika, this.ID_novog_cjenika);
            // TODO: This line of code loads data into the 'bazaDataSet.Mjerna_jedinica' table. You can move, or remove it, as needed.
            this.mjerna_jedinicaTableAdapter.Fill(this.bazaDataSet.Mjerna_jedinica);
            // TODO: This line of code loads data into the 'bazaDataSet.Usluga' table. You can move, or remove it, as needed.
            this.uslugaTableAdapter.Fill(this.bazaDataSet.Usluga);

            datumDateTimePicker.Value = DateTime.Today;
            iD_cjenikaTextBox.Text = ID_novog_cjenika.ToString();
        }

        private void btnPonisti_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {

            //------------------------------------------ ne sprema cjenik
            this.Validate();
            this.cjenikBindingSource.EndEdit();
            this.stavkacjenikaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bazaDataSet);
            this.Close();
        }

        private void dgvPopisUsluga_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //--------------------------------------------------------------------------popraviti
                stavkacjenikaBindingSource.AddNew();
                
                dgvOdabraneUsluge.Rows.Add(dgvPopisUsluga.CurrentRow.Index);
                dgvOdabraneUsluge.Rows[0].Cells[0].Value = ID_novog_cjenika;
                //iDcjenikaDataGridViewTextBoxColumn
                stavkacjenikaBindingSource.Insert(Convert.ToInt32(dgvOdabraneUsluge.Rows[0].Cells["ID_cjenika"]), ID_novog_cjenika);
                //------------------------------------------------------------------------
            }
            catch (Exception ex)
            {
                MessageBox.Show("Iznimka: " + ex.Message);
            }
        }
    }
}
