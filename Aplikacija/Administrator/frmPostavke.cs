using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aplikacija.Properties;

namespace Aplikacija.Administrator
{
    public partial class frmPostavke : Form
    {
        public frmPostavke()
        {
            InitializeComponent();
        }

        private void frmPostavke_Load(object sender, EventArgs e)
        {
            txtNazivPoduzeca.Text = Settings.Default["Naziv"].ToString();
            txtAdresa.Text = Settings.Default["Adresa"].ToString();
            txtOIB.Text = Settings.Default["OIB"].ToString();
            txtBrRcn.Text = Settings.Default["Broj_racuna"].ToString();
            txtBrTelefona.Text = Settings.Default["Broj_telefona"].ToString();
            txtPDV.Text = Settings.Default["PDV"].ToString();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            Settings.Default["Naziv"] = txtNazivPoduzeca.Text;
            Settings.Default["Adresa"] = txtAdresa.Text;
            Settings.Default["OIB"] = txtOIB.Text;
            Settings.Default["Broj_racuna"] = txtBrRcn.Text;
            Settings.Default["Broj_telefona"] = txtBrTelefona.Text;
            Settings.Default["PDV"] = txtPDV.Text;
            Settings.Default.Save();
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
