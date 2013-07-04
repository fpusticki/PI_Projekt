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

namespace Aplikacija.Administrator
{
    public partial class frmCRM : Form
    {
        //instanca klase CRM
        CRM crm = new CRM();

        public frmCRM()
        {
            InitializeComponent();

            string strSQL = "SELECT * FROM CRM";
            string strCon = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Baza\Baza.mdf;Integrated Security=True;Connect Timeout=30";
            //SqlDataAdapter dataAdapter = new SqlDataAdapter(strSQL, strCon);
            //SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

            //DataTable table = new DataTable();

            //table.Locale = System.Globalization.CultureInfo.InvariantCulture;

            //dataAdapter.Fill(table);

            //dataGridView1.DataSource = dataAdapter;

            using (SqlConnection myConnection = new SqlConnection(strCon))
            {
                using (SqlCommand sqlComm = new SqlCommand(strSQL, myConnection))
                {
                    sqlComm.CommandType = CommandType.Text;
                    myConnection.Open();
                    SqlDataReader reader = sqlComm.ExecuteReader();
                    DataSet ds = new DataSet();
                    DataTable dt = new DataTable();
                    ds.Tables.Add(dt);
                    ds.Load(reader, LoadOption.PreserveChanges, ds.Tables[0]);
                    dataGridView1.DataSource = ds.Tables[0];
                    myConnection.Close();
                }
            }


            //event handler za dohvaćanje svih ćelija unutar jednog retka
            dataGridView1.CellDoubleClick += (sender, e) =>
            {
                textBox1.Text = dataGridView1.Rows[dataGridView1.SelectedRows.Count].Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.Rows[dataGridView1.SelectedRows.Count].Cells[1].Value.ToString();
                textBox3.Text = dataGridView1.Rows[dataGridView1.SelectedRows.Count].Cells[2].Value.ToString();
                textBox4.Text = dataGridView1.Rows[dataGridView1.SelectedRows.Count].Cells[3].Value.ToString();
            };

            //event handler za ažuriranje nekog popusta unutar CRM tablice
            button1.Click += (sender, e) =>
            {
                if (textBox1.Text != "")
                {
                    try
                    {

                        SqlConnection conn = new SqlConnection();
                        conn.ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Baza\Baza.mdf;Integrated Security=True;Connect Timeout=30";
                        // 1. Create Command
                        // Sql Update Statement
                        string updateSql = "UPDATE CRM " + "SET opis_popusta = @opis_popusta, broj_dolazaka = @broj_dolazaka, vrijeme_provjere = @vrijeme_provjere " +
                    "WHERE id_CRM = " + textBox1.Text;
                        SqlCommand update = new SqlCommand(updateSql, conn);
                        // 2. Map Parameters               

                        update.Parameters.Add("@opis_popusta", SqlDbType.Text, 3000, textBox2.Text);
                        update.Parameters.Add("@broj_dolazaka", SqlDbType.Int, 50, textBox3.Text);
                        update.Parameters.Add("@vrijeme_provjere", SqlDbType.DateTime, 100, textBox4.Text);

                        //tu stavi u navodnike opis popusta

                        SqlDataReader usernameRdr = null;
                        update.Connection.Open();
                        usernameRdr = update.ExecuteReader();
                        while (usernameRdr.Read())
                        {
                            string dolasci = usernameRdr["broj_dolazaka"].ToString();
                            int brojDolazaka = Convert.ToInt32(dolasci);
                            brojDolazaka++;

                            update.Parameters["@broj_dolazaka"].Value = brojDolazaka;
                        }

                        update.Parameters["@vrijeme_provjere"].Value = textBox4.Text;


                        update.ExecuteNonQuery();
                        update.Connection.Close();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Niste odredili redak!");
                }

            };

            //event handler za spremanje novog popusta u CRM bazu
            button2.Click += (sender, e) =>
            {
                if (textBox1.Text != "")
                {
                    try
                    {
                        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Baza\Baza.mdf;Integrated Security=True;Connect Timeout=30");

                        // 1. Create Command
                        // Sql Update Statement
                        //string updateSql = "INSERT INTO CRM(id_CRM, opis_popusta, broj_dolazaka, vrijeme_provjere) VALUES(@id_CRM, @opis_popusta, @broj_dolazaka, @vrijeme_provjere)";

                        //SqlCommand update = new SqlCommand(updateSql, conn);
                        //// 2. Map Parameters               
                        //update.Parameters.Add("@id_CRM", SqlDbType.Int).Value = textBox1.Text;
                        //update.Parameters.Add("@opis_popusta", SqlDbType.Text).Value = textBox2.Text;

                        //update.Parameters.Add("@broj_dolazaka", SqlDbType.Int).Value = textBox3.Text;
                        //update.Parameters.Add("@vrijeme_provjere", SqlDbType.Int).Value = textBox4.Text;

                        //SqlCommand command = new SqlCommand("insert into CRM(id_CRM, opis_popusta, broj_dolazaka, vrijeme_provjere) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')", conn);
                        SqlCommand command = new SqlCommand("insert into CRM(id_CRM, opis_popusta, broj_dolazaka, vrijeme_provjere) values(" + textBox1.Text + ",'" + textBox2.Text + "'," + textBox3.Text + "," + textBox4.Text + ")", conn);
                        conn.Open();
                        command.ExecuteNonQuery();
                        conn.Close();


                        //update.Connection.Open();            
                        //update.ExecuteNonQuery();
                        //update.Connection.Close();

                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            };

            //event handler za brisanje podataka iz tablice CRM
            button3.Click += (sender, e) =>
            {
                if (textBox1.Text != "")
                {
                    try
                    {
                        SqlConnection conn = new SqlConnection();
                        conn.ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Baza\Baza.mdf;Integrated Security=True;Connect Timeout=30";

                        string updateSql = "DELETE FROM CRM WHERE id_CRM = " + textBox1.Text;
                        SqlCommand update = new SqlCommand(updateSql, conn);

                        conn.Open();
                        update.ExecuteNonQuery();
                        conn.Close();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            };
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
