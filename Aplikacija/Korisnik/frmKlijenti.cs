﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Aplikacija.Korisnik
{
    public partial class frmKlijenti : Form
    {
        public frmKlijenti()
        {
            InitializeComponent();

            btnUpdate.Click += (sender, e) =>
            {
                try
                {
                    SqlConnection conn = new SqlConnection();
                    conn.ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\PI_BAZA.mdf;Integrated Security=True";

                    string updateSql = "UPDATE CRM " + "SET opis_popusta = @opis_popusta, broj_dolazaka = @broj_dolazaka, vrijeme_provjere = @vrijeme_provjere " +
                "WHERE id_CRM = @id_CRM";
                    SqlCommand update = new SqlCommand(updateSql, conn);
             
                    update.Parameters.Add("@opis_popusta", SqlDbType.Text, 3000, "opis_popusta");
                    update.Parameters.Add("@broj_dolazaka", SqlDbType.Int, 50, "broj_dolazaka");
                    update.Parameters.Add("@vrijeme_provjere", SqlDbType.DateTime, 100, "vrijeme_provjere");

          //tu stavi u navodnike opis popusta
                    update.Parameters["@opis_popusta"].Value = "";
                    SqlDataReader usernameRdr = null;
                    usernameRdr = update.ExecuteReader();
                    while (usernameRdr.Read())
                    {
                        string dolasci = usernameRdr["broj_dolazaka"].ToString();
                        int brojDolazaka = Convert.ToInt32(dolasci);
                        brojDolazaka++;

                        update.Parameters["@broj_dolazaka"].Value = brojDolazaka;
                    }

                    update.Parameters["@vrijeme_provjere"].Value = DateTime.Now.Month + "/" + DateTime.Now.Day + "/" + DateTime.Now.Year + " " + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second;


                    update.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            };
        }

        private void frmKlijenti_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bazaDataSet.Klijent' table. You can move, or remove it, as needed.
            this.klijentTableAdapter.Fill(this.bazaDataSet.Klijent);

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            frmDodajKlijenta noviKlijent = new frmDodajKlijenta();
            noviKlijent.ShowDialog();
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            frmUrediKlijenta urediKlijenta = new frmUrediKlijenta();
            urediKlijenta.ShowDialog();
        }

        private void btnObriši_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Želite li obrisati klijenta?", "Brisanje klijenta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                dgvKlijenti.Rows.RemoveAt(dgvKlijenti.CurrentRow.Index);
            }
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
