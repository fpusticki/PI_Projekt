﻿using System;
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
    public partial class frmDodajKorisnika : Form
    {
        public frmDodajKorisnika()
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
                this.korisnikBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.bazaDataSet);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Iznimka: " + ex.Message);
            }
        }

        private void frmDodajKorisnika_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bazaDataSet.Korisnik' table. You can move, or remove it, as needed.
            this.korisnikTableAdapter.Fill(this.bazaDataSet.Korisnik);
            korisnikBindingSource.AddNew();
        }
    }
}
