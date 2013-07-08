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
    public partial class frmKorisnici : Form
    {
        public string Ime_admina { get; set; }
        public string Prezime_admina { get; set; }
        public string Username_admina { get; set; }
        public string Lozinka_admina { get; set; }

        public string Ime_korisnika { get; set; }
        public string Prezime_korisnika { get; set; }
        public string Username_korisnika { get; set; }
        public string Lozinka_korisnika { get; set; }

        public frmKorisnici()
        {
            InitializeComponent();
        }

        private void frmKorisnici_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bazaDataSet.Admin' table. You can move, or remove it, as needed.
            this.adminTableAdapter.Fill(this.bazaDataSet.Admin);
            // TODO: This line of code loads data into the 'bazaDataSet.Korisnik' table. You can move, or remove it, as needed.
            this.korisnikTableAdapter.Fill(this.bazaDataSet.Korisnik);
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDodajAdmin_Click(object sender, EventArgs e)
        {
            frmDodajAdmina noviAdmin = new frmDodajAdmina();
            noviAdmin.ShowDialog();
            this.adminTableAdapter.Fill(this.bazaDataSet.Admin);
        }

        private void btnUrediAdmin_Click(object sender, EventArgs e)
        {
            frmUrediAdmina urediAdmina = new frmUrediAdmina(this);
            urediAdmina.ShowDialog();
            this.adminTableAdapter.Fill(this.bazaDataSet.Admin);
        }

        private void btnDodajKorisnik_Click(object sender, EventArgs e)
        {
            frmDodajKorisnika noviKorisnik = new frmDodajKorisnika();
            noviKorisnik.ShowDialog();
            this.korisnikTableAdapter.Fill(this.bazaDataSet.Korisnik);
        }

        private void btnUrediKorisnik_Click(object sender, EventArgs e)
        {
            frmUrediKorisnika urediKorisnika = new frmUrediKorisnika(this);
            urediKorisnika.ShowDialog();
            this.korisnikTableAdapter.Fill(this.bazaDataSet.Korisnik);
        }

        private void btnObrisiAdmin_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Želite li obrisati admina?", "Brisanje admina", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                dgvAdmin.Rows.RemoveAt(dgvAdmin.CurrentRow.Index);
            }
            this.Validate();
            this.adminBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bazaDataSet);
        }

        private void btnObrisiKorisnik_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Želite li obrisati korisnika?", "Brisanje korisnika", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                dgvKorisnici.Rows.RemoveAt(dgvKorisnici.CurrentRow.Index);
            }
            this.Validate();
            this.korisnikBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bazaDataSet);
        }

        private void dgvAdmin_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAdmin.SelectedRows.Count > 0)
            {
                this.Ime_admina = dgvAdmin["imeDataGridViewTextBoxColumn1", dgvAdmin.CurrentRow.Index].Value.ToString();
                this.Prezime_admina = dgvAdmin["prezimeDataGridViewTextBoxColumn1", dgvAdmin.CurrentRow.Index].Value.ToString();
                this.Username_admina = dgvAdmin["usernameDataGridViewTextBoxColumn1", dgvAdmin.CurrentRow.Index].Value.ToString();
                this.Lozinka_admina = dgvAdmin["lozinkaDataGridViewTextBoxColumn1", dgvAdmin.CurrentRow.Index].Value.ToString();
            }
            
        }

        private void dgvKorisnici_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvKorisnici.SelectedRows.Count > 0)
            {
                this.Ime_korisnika = dgvKorisnici["imeDataGridViewTextBoxColumn", dgvKorisnici.CurrentRow.Index].Value.ToString();
                this.Prezime_korisnika = dgvKorisnici["prezimeDataGridViewTextBoxColumn", dgvKorisnici.CurrentRow.Index].Value.ToString();
                this.Username_korisnika = dgvKorisnici["usernameDataGridViewTextBoxColumn", dgvKorisnici.CurrentRow.Index].Value.ToString();
                this.Lozinka_korisnika = dgvKorisnici["lozinkaDataGridViewTextBoxColumn", dgvKorisnici.CurrentRow.Index].Value.ToString();
            }  
        }
    }
}
