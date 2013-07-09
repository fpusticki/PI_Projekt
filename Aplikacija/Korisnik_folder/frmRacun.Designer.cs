namespace Aplikacija.Korisnik
{
    partial class frmRacun
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
            this.label1 = new System.Windows.Forms.Label();
            this.bazaDataSet = new Aplikacija.BazaDataSet();
            this.btnNatrag = new System.Windows.Forms.Button();
            this.tableAdapterManager = new Aplikacija.BazaDataSetTableAdapters.TableAdapterManager();
            this.klijentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.klijentTableAdapter = new Aplikacija.BazaDataSetTableAdapters.KlijentTableAdapter();
            this.racunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.racunTableAdapter = new Aplikacija.BazaDataSetTableAdapters.RacunTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvRacuni = new System.Windows.Forms.DataGridView();
            this.iDracunaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDkorisnikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.korisnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDklijentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgvStvkeRacuna = new System.Windows.Forms.DataGridView();
            this.iDstavkeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.uslugaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Opis = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Mjerna_jedinica = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.mjernajedinicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Cijena = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.iDracunaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDuslugeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stavkaracunaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.korisnikTableAdapter = new Aplikacija.BazaDataSetTableAdapters.KorisnikTableAdapter();
            this.stavka_racunaTableAdapter = new Aplikacija.BazaDataSetTableAdapters.Stavka_racunaTableAdapter();
            this.uslugaTableAdapter = new Aplikacija.BazaDataSetTableAdapters.UslugaTableAdapter();
            this.mjerna_jedinicaTableAdapter = new Aplikacija.BazaDataSetTableAdapters.Mjerna_jedinicaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bazaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klijentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racunBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRacuni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStvkeRacuna)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uslugaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mjernajedinicaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkaracunaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stavke računa";
            // 
            // bazaDataSet
            // 
            this.bazaDataSet.DataSetName = "BazaDataSet";
            this.bazaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnNatrag
            // 
            this.btnNatrag.Location = new System.Drawing.Point(12, 12);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(30, 23);
            this.btnNatrag.TabIndex = 16;
            this.btnNatrag.Text = "<-----";
            this.btnNatrag.UseVisualStyleBackColor = true;
            this.btnNatrag.Click += new System.EventHandler(this.btnNatrag_Click);
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdminTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CjenikTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.CrmTableAdapter = null;
            this.tableAdapterManager.KlijentTableAdapter = null;
            this.tableAdapterManager.KorisnikTableAdapter = null;
            this.tableAdapterManager.Mjerna_jedinicaTableAdapter = null;
            this.tableAdapterManager.RacunTableAdapter = null;
            this.tableAdapterManager.Stavka_cjenikaTableAdapter = null;
            this.tableAdapterManager.Stavka_racunaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Aplikacija.BazaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UslugaTableAdapter = null;
            // 
            // klijentBindingSource
            // 
            this.klijentBindingSource.DataMember = "Klijent";
            this.klijentBindingSource.DataSource = this.bazaDataSet;
            // 
            // klijentTableAdapter
            // 
            this.klijentTableAdapter.ClearBeforeFill = true;
            // 
            // racunBindingSource
            // 
            this.racunBindingSource.DataMember = "Racun";
            this.racunBindingSource.DataSource = this.bazaDataSet;
            // 
            // racunTableAdapter
            // 
            this.racunTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Popis računa";
            // 
            // dgvRacuni
            // 
            this.dgvRacuni.AllowUserToAddRows = false;
            this.dgvRacuni.AllowUserToDeleteRows = false;
            this.dgvRacuni.AutoGenerateColumns = false;
            this.dgvRacuni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRacuni.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDracunaDataGridViewTextBoxColumn,
            this.datumDataGridViewTextBoxColumn,
            this.iDkorisnikaDataGridViewTextBoxColumn,
            this.iDklijentaDataGridViewTextBoxColumn});
            this.dgvRacuni.DataSource = this.racunBindingSource;
            this.dgvRacuni.Location = new System.Drawing.Point(12, 54);
            this.dgvRacuni.Name = "dgvRacuni";
            this.dgvRacuni.ReadOnly = true;
            this.dgvRacuni.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRacuni.Size = new System.Drawing.Size(760, 220);
            this.dgvRacuni.TabIndex = 18;
            this.dgvRacuni.SelectionChanged += new System.EventHandler(this.dgvRacuni_SelectionChanged);
            // 
            // iDracunaDataGridViewTextBoxColumn
            // 
            this.iDracunaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iDracunaDataGridViewTextBoxColumn.DataPropertyName = "ID_racuna";
            this.iDracunaDataGridViewTextBoxColumn.HeaderText = "ID računa";
            this.iDracunaDataGridViewTextBoxColumn.Name = "iDracunaDataGridViewTextBoxColumn";
            this.iDracunaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datumDataGridViewTextBoxColumn
            // 
            this.datumDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.datumDataGridViewTextBoxColumn.DataPropertyName = "datum";
            this.datumDataGridViewTextBoxColumn.HeaderText = "Datum";
            this.datumDataGridViewTextBoxColumn.Name = "datumDataGridViewTextBoxColumn";
            this.datumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDkorisnikaDataGridViewTextBoxColumn
            // 
            this.iDkorisnikaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iDkorisnikaDataGridViewTextBoxColumn.DataPropertyName = "ID_korisnika";
            this.iDkorisnikaDataGridViewTextBoxColumn.DataSource = this.korisnikBindingSource;
            this.iDkorisnikaDataGridViewTextBoxColumn.DisplayMember = "prezime";
            this.iDkorisnikaDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.iDkorisnikaDataGridViewTextBoxColumn.HeaderText = "Račun izdao";
            this.iDkorisnikaDataGridViewTextBoxColumn.Name = "iDkorisnikaDataGridViewTextBoxColumn";
            this.iDkorisnikaDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDkorisnikaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iDkorisnikaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iDkorisnikaDataGridViewTextBoxColumn.ValueMember = "ID_korisnika";
            // 
            // korisnikBindingSource
            // 
            this.korisnikBindingSource.DataMember = "Korisnik";
            this.korisnikBindingSource.DataSource = this.bazaDataSet;
            // 
            // iDklijentaDataGridViewTextBoxColumn
            // 
            this.iDklijentaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iDklijentaDataGridViewTextBoxColumn.DataPropertyName = "ID_klijenta";
            this.iDklijentaDataGridViewTextBoxColumn.DataSource = this.klijentBindingSource;
            this.iDklijentaDataGridViewTextBoxColumn.DisplayMember = "prezime";
            this.iDklijentaDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.iDklijentaDataGridViewTextBoxColumn.HeaderText = "Klijent";
            this.iDklijentaDataGridViewTextBoxColumn.Name = "iDklijentaDataGridViewTextBoxColumn";
            this.iDklijentaDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDklijentaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iDklijentaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iDklijentaDataGridViewTextBoxColumn.ValueMember = "ID_klijenta";
            // 
            // dgvStvkeRacuna
            // 
            this.dgvStvkeRacuna.AllowUserToAddRows = false;
            this.dgvStvkeRacuna.AllowUserToDeleteRows = false;
            this.dgvStvkeRacuna.AutoGenerateColumns = false;
            this.dgvStvkeRacuna.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStvkeRacuna.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDstavkeDataGridViewTextBoxColumn,
            this.Naziv,
            this.Opis,
            this.Mjerna_jedinica,
            this.Cijena,
            this.iDracunaDataGridViewTextBoxColumn1,
            this.iDuslugeDataGridViewTextBoxColumn});
            this.dgvStvkeRacuna.DataSource = this.stavkaracunaBindingSource;
            this.dgvStvkeRacuna.Location = new System.Drawing.Point(12, 302);
            this.dgvStvkeRacuna.Name = "dgvStvkeRacuna";
            this.dgvStvkeRacuna.ReadOnly = true;
            this.dgvStvkeRacuna.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStvkeRacuna.Size = new System.Drawing.Size(760, 228);
            this.dgvStvkeRacuna.TabIndex = 19;
            // 
            // iDstavkeDataGridViewTextBoxColumn
            // 
            this.iDstavkeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iDstavkeDataGridViewTextBoxColumn.DataPropertyName = "ID_stavke";
            this.iDstavkeDataGridViewTextBoxColumn.HeaderText = "ID_stavke";
            this.iDstavkeDataGridViewTextBoxColumn.Name = "iDstavkeDataGridViewTextBoxColumn";
            this.iDstavkeDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDstavkeDataGridViewTextBoxColumn.Visible = false;
            // 
            // Naziv
            // 
            this.Naziv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Naziv.DataSource = this.uslugaBindingSource;
            this.Naziv.DisplayMember = "naziv";
            this.Naziv.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            this.Naziv.ValueMember = "ID_usluge";
            // 
            // uslugaBindingSource
            // 
            this.uslugaBindingSource.DataMember = "Usluga";
            this.uslugaBindingSource.DataSource = this.bazaDataSet;
            // 
            // Opis
            // 
            this.Opis.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Opis.DataSource = this.uslugaBindingSource;
            this.Opis.DisplayMember = "opis";
            this.Opis.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Opis.HeaderText = "Opis";
            this.Opis.Name = "Opis";
            this.Opis.ReadOnly = true;
            this.Opis.ValueMember = "ID_usluge";
            // 
            // Mjerna_jedinica
            // 
            this.Mjerna_jedinica.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Mjerna_jedinica.DataSource = this.mjernajedinicaBindingSource;
            this.Mjerna_jedinica.DisplayMember = "Naziv";
            this.Mjerna_jedinica.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Mjerna_jedinica.HeaderText = "Mjerna jedinica";
            this.Mjerna_jedinica.Name = "Mjerna_jedinica";
            this.Mjerna_jedinica.ReadOnly = true;
            this.Mjerna_jedinica.ValueMember = "ID_mjerne_jedinice";
            // 
            // mjernajedinicaBindingSource
            // 
            this.mjernajedinicaBindingSource.DataMember = "Mjerna_jedinica";
            this.mjernajedinicaBindingSource.DataSource = this.bazaDataSet;
            // 
            // Cijena
            // 
            this.Cijena.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cijena.DataSource = this.uslugaBindingSource;
            this.Cijena.DisplayMember = "cijena";
            this.Cijena.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Cijena.HeaderText = "Cijena";
            this.Cijena.Name = "Cijena";
            this.Cijena.ReadOnly = true;
            this.Cijena.ValueMember = "ID_usluge";
            // 
            // iDracunaDataGridViewTextBoxColumn1
            // 
            this.iDracunaDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iDracunaDataGridViewTextBoxColumn1.DataPropertyName = "ID_racuna";
            this.iDracunaDataGridViewTextBoxColumn1.HeaderText = "ID_racuna";
            this.iDracunaDataGridViewTextBoxColumn1.Name = "iDracunaDataGridViewTextBoxColumn1";
            this.iDracunaDataGridViewTextBoxColumn1.ReadOnly = true;
            this.iDracunaDataGridViewTextBoxColumn1.Visible = false;
            // 
            // iDuslugeDataGridViewTextBoxColumn
            // 
            this.iDuslugeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iDuslugeDataGridViewTextBoxColumn.DataPropertyName = "ID_usluge";
            this.iDuslugeDataGridViewTextBoxColumn.HeaderText = "ID_usluge";
            this.iDuslugeDataGridViewTextBoxColumn.Name = "iDuslugeDataGridViewTextBoxColumn";
            this.iDuslugeDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDuslugeDataGridViewTextBoxColumn.Visible = false;
            // 
            // stavkaracunaBindingSource
            // 
            this.stavkaracunaBindingSource.DataMember = "Stavka_racuna";
            this.stavkaracunaBindingSource.DataSource = this.bazaDataSet;
            // 
            // korisnikTableAdapter
            // 
            this.korisnikTableAdapter.ClearBeforeFill = true;
            // 
            // stavka_racunaTableAdapter
            // 
            this.stavka_racunaTableAdapter.ClearBeforeFill = true;
            // 
            // uslugaTableAdapter
            // 
            this.uslugaTableAdapter.ClearBeforeFill = true;
            // 
            // mjerna_jedinicaTableAdapter
            // 
            this.mjerna_jedinicaTableAdapter.ClearBeforeFill = true;
            // 
            // frmRacun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 542);
            this.ControlBox = false;
            this.Controls.Add(this.dgvStvkeRacuna);
            this.Controls.Add(this.dgvRacuni);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnNatrag);
            this.Controls.Add(this.label1);
            this.Name = "frmRacun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Račun";
            this.Load += new System.EventHandler(this.frmRacun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bazaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klijentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racunBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRacuni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStvkeRacuna)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uslugaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mjernajedinicaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkaracunaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private BazaDataSet bazaDataSet;
        private BazaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btnNatrag;
        private System.Windows.Forms.BindingSource klijentBindingSource;
        private BazaDataSetTableAdapters.KlijentTableAdapter klijentTableAdapter;
        private System.Windows.Forms.BindingSource racunBindingSource;
        private BazaDataSetTableAdapters.RacunTableAdapter racunTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvRacuni;
        private System.Windows.Forms.DataGridView dgvStvkeRacuna;
        private System.Windows.Forms.BindingSource korisnikBindingSource;
        private BazaDataSetTableAdapters.KorisnikTableAdapter korisnikTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDracunaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn iDkorisnikaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn iDklijentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource stavkaracunaBindingSource;
        private BazaDataSetTableAdapters.Stavka_racunaTableAdapter stavka_racunaTableAdapter;
        private System.Windows.Forms.BindingSource uslugaBindingSource;
        private BazaDataSetTableAdapters.UslugaTableAdapter uslugaTableAdapter;
        private System.Windows.Forms.BindingSource mjernajedinicaBindingSource;
        private BazaDataSetTableAdapters.Mjerna_jedinicaTableAdapter mjerna_jedinicaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDstavkeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewComboBoxColumn Opis;
        private System.Windows.Forms.DataGridViewComboBoxColumn Mjerna_jedinica;
        private System.Windows.Forms.DataGridViewComboBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDracunaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDuslugeDataGridViewTextBoxColumn;
    }
}