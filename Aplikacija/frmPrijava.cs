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

namespace Aplikacija
{
    public partial class frmPrijava : Form
    {
        public frmPrijava()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            bool login1 = false;
            bool login2 = false;

            SqlConnection sc = new SqlConnection();
            sc.ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Baza\Baza.mdf;Integrated Security=True;Connect Timeout=30";
            string upit = "SELECT * FROM Admin";

            SqlConnection sc2 = new SqlConnection();
            sc2.ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Baza\Baza.mdf;Integrated Security=True;Connect Timeout=30";
            string upit2 = "SELECT * FROM Korisnik";

            if (txtKorisnickoIme.Text == "" || txtLozinka.Text == "")
            {
                login1 = true;
                login2 = true;
                    MessageBox.Show("Unesite podatke!");
                    txtKorisnickoIme.Text = null;
                    txtLozinka.Text = null;
                    txtKorisnickoIme.Focus();
            }
            else
            {
                        sc.Open();
                        using (var cmd = new SqlCommand(upit, sc))
                        {
                            SqlDataReader dr = null;
                            dr = cmd.ExecuteReader();
                            while (dr.Read())
                            {
                                if (txtKorisnickoIme.Text == dr["username"].ToString() && txtLozinka.Text == dr["lozinka"].ToString())
                                {
                                    login1 = true;
                                    //this.Hide();
                                    MessageBox.Show("Logiran kao admin: " + dr["ime"].ToString() + " " + dr["prezime"].ToString());
                                    Properties.Settings.Default.BrojPoslanihMailova = 0;
                                    frmAdministrator admin = new frmAdministrator();
                                    admin.Show();
                                }
                            }
                            sc.Close();
                        }
                        sc2.Open();
                        using (var cmd = new SqlCommand(upit2, sc2))
                        {
                            SqlDataReader dr2 = null;
                            dr2 = cmd.ExecuteReader();
                            while (dr2.Read())
                            {
                                if (txtKorisnickoIme.Text == dr2["username"].ToString() && txtLozinka.Text == dr2["lozinka"].ToString())
                                {
                                    login2 = true;
                                    //this.Hide();
                                    MessageBox.Show("Logiran kao korisnik: " + dr2["ime"].ToString() + " " + dr2["prezime"].ToString());
                                    frmKorisnik korisnik = new frmKorisnik();
                                    korisnik.Show();
                                }
                            }
                            sc2.Close();
                        }
                }
            if ((login1 == false) && (login2 == false))
            {
                    MessageBox.Show("Unijeli ste pogrešne podatke!");
                    txtKorisnickoIme.Text = null;
                    txtLozinka.Text = null;
                    txtKorisnickoIme.Focus();
            }
        }
    }
}
