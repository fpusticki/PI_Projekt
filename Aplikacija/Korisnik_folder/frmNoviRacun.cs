﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikacija.Korisnik_folder
{
    public partial class frmNoviRacun : Form
    {
        public int ID_novi_racun { get; set; }

        public frmNoviRacun()
        {
            InitializeComponent();
        }

        private void frmNoviRacun_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bazaDataSet.Klijent' table. You can move, or remove it, as needed.
            this.klijentTableAdapter.Fill(this.bazaDataSet.Klijent);
            // TODO: This line of code loads data into the 'bazaDataSet.Racun' table. You can move, or remove it, as needed.
            this.racunTableAdapter.Fill(this.bazaDataSet.Racun);
            // TODO: This line of code loads data into the 'bazaDataSet.Mjerna_jedinica' table. You can move, or remove it, as needed.
            this.mjerna_jedinicaTableAdapter.Fill(this.bazaDataSet.Mjerna_jedinica);
            // TODO: This line of code loads data into the 'bazaDataSet.Usluga' table. You can move, or remove it, as needed.
            this.uslugaTableAdapter.Fill(this.bazaDataSet.Usluga);
            // TODO: This line of code loads data into the 'bazaDataSet.Stavka_racuna' table. You can move, or remove it, as needed.
            this.stavka_racunaTableAdapter.Fill(this.bazaDataSet.Stavka_racuna);
            // TODO: This line of code loads data into the 'bazaDataSet.Stavka_cjenika' table. You can move, or remove it, as needed.
            this.stavka_cjenikaTableAdapter.Fill(this.bazaDataSet.Stavka_cjenika);

        }

        private void btnPonisti_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
