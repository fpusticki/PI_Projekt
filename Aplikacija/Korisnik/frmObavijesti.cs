using System;
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
    public partial class frmObavijesti : Form
    {
        public frmObavijesti()
        {
            InitializeComponent();

            AsyncObavijest();

            btnIsprazniListu.Click += (sender, e) =>
            {
                lstObavijesti.Text = null;
            };
        }

        public async void AsyncObavijest()
        {
            await Task.Run(() => Obavijest());
        }

        private void Obavijest()
        {
            SqlConnection sc = new SqlConnection();

            sc.ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Baza\Baza.mdf;Integrated Security=True";

            string selectUpit = "SELECT * FROM CRM";

            sc.Open();

            using (var command = new SqlCommand(selectUpit, sc))
            {
                SqlDataReader crmReader = null;

                crmReader = command.ExecuteReader();

                try
                {
                    while (crmReader.Read())
                    {
                        //klasa CRM implementira Dispose metodu s toga mora biti unutar using izjave kako bi se objekt
                        //prilikom završetka izjave sam uništio
                        //opis klase CRM pogledati u datoteci CRM.cs
                        using (CRM crm = new CRM())
                        {
                            int datum = Convert.ToInt32(crmReader["vrijeme_provjere"].ToString());
                            int dolasci = Convert.ToInt32(crmReader["broj_dolazaka"]);
                            string opis_popusta = crmReader["opis_popusta"].ToString();

                            //podaci iz baze iz stupaca vrijeme_provjere, broj_dolazaka i opis_popusta se spremaju
                            //u svojstva klase CRM
                            crm.VrijemeProvjere = datum;
                            crm.BrojDolazaka = dolasci;
                            crm.OpisPopusta = opis_popusta;

                            if (crm.VrijemeProvjere == 0)
                            {
                                MessageBox.Show("Ne postoje zapisi u bazi podataka");
                            }
                            else
                            {
                                lstObavijesti.Items.Add("Danas je poslano " + Properties.Settings.Default.BrojPoslanihMailova + " mailova.");
                            }
                        }
                    }
                    sc.Close();
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIsprazniListu_Click(object sender, EventArgs e)
        {
            lstObavijesti.Items.Clear();
        }
    }
}
