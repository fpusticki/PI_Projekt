namespace Aplikacija.Administrator
{
    partial class frmKorisnici
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvKorisnici = new System.Windows.Forms.DataGridView();
            this.korisnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bazaDataSet = new Aplikacija.BazaDataSet();
            this.btnDodajKorisnik = new System.Windows.Forms.Button();
            this.korisnikTableAdapter = new Aplikacija.BazaDataSetTableAdapters.KorisnikTableAdapter();
            this.tableAdapterManager = new Aplikacija.BazaDataSetTableAdapters.TableAdapterManager();
            this.adminTableAdapter = new Aplikacija.BazaDataSetTableAdapters.AdminTableAdapter();
            this.adminBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnNatrag = new System.Windows.Forms.Button();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.lblKorisnici = new System.Windows.Forms.Label();
            this.dgvAdmin = new System.Windows.Forms.DataGridView();
            this.btnDodajAdmin = new System.Windows.Forms.Button();
            this.btnUrediAdmin = new System.Windows.Forms.Button();
            this.btnUrediKorisnik = new System.Windows.Forms.Button();
            this.iDadminDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lozinkaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDkorisnikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lozinkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisnici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKorisnici
            // 
            this.dgvKorisnici.AllowUserToAddRows = false;
            this.dgvKorisnici.AllowUserToDeleteRows = false;
            this.dgvKorisnici.AutoGenerateColumns = false;
            this.dgvKorisnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKorisnici.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDkorisnikaDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.lozinkaDataGridViewTextBoxColumn});
            this.dgvKorisnici.DataSource = this.korisnikBindingSource;
            this.dgvKorisnici.Location = new System.Drawing.Point(12, 294);
            this.dgvKorisnici.Name = "dgvKorisnici";
            this.dgvKorisnici.ReadOnly = true;
            this.dgvKorisnici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKorisnici.Size = new System.Drawing.Size(760, 200);
            this.dgvKorisnici.TabIndex = 0;
            this.dgvKorisnici.SelectionChanged += new System.EventHandler(this.dgvKorisnici_SelectionChanged);
            // 
            // korisnikBindingSource
            // 
            this.korisnikBindingSource.DataMember = "Korisnik";
            this.korisnikBindingSource.DataSource = this.bazaDataSet;
            // 
            // bazaDataSet
            // 
            this.bazaDataSet.DataSetName = "BazaDataSet";
            this.bazaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnDodajKorisnik
            // 
            this.btnDodajKorisnik.Location = new System.Drawing.Point(302, 500);
            this.btnDodajKorisnik.Name = "btnDodajKorisnik";
            this.btnDodajKorisnik.Size = new System.Drawing.Size(75, 23);
            this.btnDodajKorisnik.TabIndex = 6;
            this.btnDodajKorisnik.Text = "Dodaj";
            this.btnDodajKorisnik.UseVisualStyleBackColor = true;
            this.btnDodajKorisnik.Click += new System.EventHandler(this.btnDodajKorisnik_Click);
            // 
            // korisnikTableAdapter
            // 
            this.korisnikTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdminTableAdapter = this.adminTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CjenikTableAdapter = null;
            this.tableAdapterManager.KlijentTableAdapter = null;
            this.tableAdapterManager.KorisnikTableAdapter = this.korisnikTableAdapter;
            this.tableAdapterManager.Mjerna_jedinicaTableAdapter = null;
            this.tableAdapterManager.RacunTableAdapter = null;
            this.tableAdapterManager.Stavka_cjenikaTableAdapter = null;
            this.tableAdapterManager.Stavka_racunaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Aplikacija.BazaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UslugaTableAdapter = null;
            // 
            // adminTableAdapter
            // 
            this.adminTableAdapter.ClearBeforeFill = true;
            // 
            // adminBindingSource
            // 
            this.adminBindingSource.DataMember = "Admin";
            this.adminBindingSource.DataSource = this.bazaDataSet;
            // 
            // btnNatrag
            // 
            this.btnNatrag.Location = new System.Drawing.Point(12, 12);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(30, 23);
            this.btnNatrag.TabIndex = 13;
            this.btnNatrag.Text = "<-----";
            this.btnNatrag.UseVisualStyleBackColor = true;
            this.btnNatrag.Click += new System.EventHandler(this.btnNatrag_Click);
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Location = new System.Drawing.Point(12, 38);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(69, 13);
            this.lblAdmin.TabIndex = 14;
            this.lblAdmin.Text = "Administratori";
            // 
            // lblKorisnici
            // 
            this.lblKorisnici.AutoSize = true;
            this.lblKorisnici.Location = new System.Drawing.Point(12, 278);
            this.lblKorisnici.Name = "lblKorisnici";
            this.lblKorisnici.Size = new System.Drawing.Size(46, 13);
            this.lblKorisnici.TabIndex = 15;
            this.lblKorisnici.Text = "Korisnici";
            // 
            // dgvAdmin
            // 
            this.dgvAdmin.AllowUserToAddRows = false;
            this.dgvAdmin.AllowUserToDeleteRows = false;
            this.dgvAdmin.AutoGenerateColumns = false;
            this.dgvAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdmin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDadminDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn1,
            this.prezimeDataGridViewTextBoxColumn1,
            this.usernameDataGridViewTextBoxColumn1,
            this.lozinkaDataGridViewTextBoxColumn1});
            this.dgvAdmin.DataSource = this.adminBindingSource;
            this.dgvAdmin.Location = new System.Drawing.Point(12, 54);
            this.dgvAdmin.Name = "dgvAdmin";
            this.dgvAdmin.ReadOnly = true;
            this.dgvAdmin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAdmin.Size = new System.Drawing.Size(760, 200);
            this.dgvAdmin.TabIndex = 16;
            this.dgvAdmin.SelectionChanged += new System.EventHandler(this.dgvAdmin_SelectionChanged);
            // 
            // btnDodajAdmin
            // 
            this.btnDodajAdmin.Location = new System.Drawing.Point(302, 260);
            this.btnDodajAdmin.Name = "btnDodajAdmin";
            this.btnDodajAdmin.Size = new System.Drawing.Size(75, 23);
            this.btnDodajAdmin.TabIndex = 17;
            this.btnDodajAdmin.Text = "Dodaj";
            this.btnDodajAdmin.UseVisualStyleBackColor = true;
            this.btnDodajAdmin.Click += new System.EventHandler(this.btnDodajAdmin_Click);
            // 
            // btnUrediAdmin
            // 
            this.btnUrediAdmin.Location = new System.Drawing.Point(383, 260);
            this.btnUrediAdmin.Name = "btnUrediAdmin";
            this.btnUrediAdmin.Size = new System.Drawing.Size(75, 23);
            this.btnUrediAdmin.TabIndex = 18;
            this.btnUrediAdmin.Text = "Uredi";
            this.btnUrediAdmin.UseVisualStyleBackColor = true;
            this.btnUrediAdmin.Click += new System.EventHandler(this.btnUrediAdmin_Click);
            // 
            // btnUrediKorisnik
            // 
            this.btnUrediKorisnik.Location = new System.Drawing.Point(383, 500);
            this.btnUrediKorisnik.Name = "btnUrediKorisnik";
            this.btnUrediKorisnik.Size = new System.Drawing.Size(75, 23);
            this.btnUrediKorisnik.TabIndex = 19;
            this.btnUrediKorisnik.Text = "Uredi";
            this.btnUrediKorisnik.UseVisualStyleBackColor = true;
            this.btnUrediKorisnik.Click += new System.EventHandler(this.btnUrediKorisnik_Click);
            // 
            // iDadminDataGridViewTextBoxColumn
            // 
            this.iDadminDataGridViewTextBoxColumn.DataPropertyName = "ID_admin";
            this.iDadminDataGridViewTextBoxColumn.HeaderText = "ID administratora";
            this.iDadminDataGridViewTextBoxColumn.Name = "iDadminDataGridViewTextBoxColumn";
            this.iDadminDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // imeDataGridViewTextBoxColumn1
            // 
            this.imeDataGridViewTextBoxColumn1.DataPropertyName = "ime";
            this.imeDataGridViewTextBoxColumn1.HeaderText = "Ime";
            this.imeDataGridViewTextBoxColumn1.Name = "imeDataGridViewTextBoxColumn1";
            this.imeDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // prezimeDataGridViewTextBoxColumn1
            // 
            this.prezimeDataGridViewTextBoxColumn1.DataPropertyName = "prezime";
            this.prezimeDataGridViewTextBoxColumn1.HeaderText = "Prezime";
            this.prezimeDataGridViewTextBoxColumn1.Name = "prezimeDataGridViewTextBoxColumn1";
            this.prezimeDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // usernameDataGridViewTextBoxColumn1
            // 
            this.usernameDataGridViewTextBoxColumn1.DataPropertyName = "username";
            this.usernameDataGridViewTextBoxColumn1.HeaderText = "Korisnički ime";
            this.usernameDataGridViewTextBoxColumn1.Name = "usernameDataGridViewTextBoxColumn1";
            this.usernameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // lozinkaDataGridViewTextBoxColumn1
            // 
            this.lozinkaDataGridViewTextBoxColumn1.DataPropertyName = "lozinka";
            this.lozinkaDataGridViewTextBoxColumn1.HeaderText = "Lozinka";
            this.lozinkaDataGridViewTextBoxColumn1.Name = "lozinkaDataGridViewTextBoxColumn1";
            this.lozinkaDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // iDkorisnikaDataGridViewTextBoxColumn
            // 
            this.iDkorisnikaDataGridViewTextBoxColumn.DataPropertyName = "ID_korisnika";
            this.iDkorisnikaDataGridViewTextBoxColumn.HeaderText = "ID korisnika";
            this.iDkorisnikaDataGridViewTextBoxColumn.Name = "iDkorisnikaDataGridViewTextBoxColumn";
            this.iDkorisnikaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "Ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            this.imeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prezimeDataGridViewTextBoxColumn
            // 
            this.prezimeDataGridViewTextBoxColumn.DataPropertyName = "prezime";
            this.prezimeDataGridViewTextBoxColumn.HeaderText = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.Name = "prezimeDataGridViewTextBoxColumn";
            this.prezimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Korisničko ime";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lozinkaDataGridViewTextBoxColumn
            // 
            this.lozinkaDataGridViewTextBoxColumn.DataPropertyName = "lozinka";
            this.lozinkaDataGridViewTextBoxColumn.HeaderText = "Lozinka";
            this.lozinkaDataGridViewTextBoxColumn.Name = "lozinkaDataGridViewTextBoxColumn";
            this.lozinkaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmKorisnici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.ControlBox = false;
            this.Controls.Add(this.btnUrediKorisnik);
            this.Controls.Add(this.btnUrediAdmin);
            this.Controls.Add(this.btnDodajAdmin);
            this.Controls.Add(this.dgvAdmin);
            this.Controls.Add(this.lblKorisnici);
            this.Controls.Add(this.lblAdmin);
            this.Controls.Add(this.btnNatrag);
            this.Controls.Add(this.btnDodajKorisnik);
            this.Controls.Add(this.dgvKorisnici);
            this.Name = "frmKorisnici";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Korisnici";
            this.Load += new System.EventHandler(this.frmKorisnici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisnici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKorisnici;
        private System.Windows.Forms.Button btnDodajKorisnik;
        private BazaDataSet bazaDataSet;
        private System.Windows.Forms.BindingSource korisnikBindingSource;
        private BazaDataSetTableAdapters.KorisnikTableAdapter korisnikTableAdapter;
        private BazaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private BazaDataSetTableAdapters.AdminTableAdapter adminTableAdapter;
        private System.Windows.Forms.BindingSource adminBindingSource;
        private System.Windows.Forms.Button btnNatrag;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Label lblKorisnici;
        private System.Windows.Forms.DataGridView dgvAdmin;
        private System.Windows.Forms.Button btnDodajAdmin;
        private System.Windows.Forms.Button btnUrediAdmin;
        private System.Windows.Forms.Button btnUrediKorisnik;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDadminDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lozinkaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDkorisnikaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lozinkaDataGridViewTextBoxColumn;
    }
}