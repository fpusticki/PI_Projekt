namespace Aplikacija.Administrator
{
    partial class frmCjenici
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
            this.lblCjenici = new System.Windows.Forms.Label();
            this.dgvCjenik = new System.Windows.Forms.DataGridView();
            this.cjenikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bazaDataSet = new Aplikacija.BazaDataSet();
            this.lblStavkeCjenika = new System.Windows.Forms.Label();
            this.dgvStavkeCjenika = new System.Windows.Forms.DataGridView();
            this.uslugaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mjernajedinicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stavka_cjenikaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cjenikTableAdapter = new Aplikacija.BazaDataSetTableAdapters.CjenikTableAdapter();
            this.tableAdapterManager = new Aplikacija.BazaDataSetTableAdapters.TableAdapterManager();
            this.stavka_cjenikaTableAdapter = new Aplikacija.BazaDataSetTableAdapters.Stavka_cjenikaTableAdapter();
            this.btnUredi = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.uslugaTableAdapter = new Aplikacija.BazaDataSetTableAdapters.UslugaTableAdapter();
            this.mjerna_jedinicaTableAdapter = new Aplikacija.BazaDataSetTableAdapters.Mjerna_jedinicaTableAdapter();
            this.btnNatrag = new System.Windows.Forms.Button();
            this.ID_cjenika = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vazeciDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.iDstavkeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDcjenikaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDuslugeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ID_usluge = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCjenik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cjenikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeCjenika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uslugaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mjernajedinicaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavka_cjenikaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCjenici
            // 
            this.lblCjenici.AutoSize = true;
            this.lblCjenici.Location = new System.Drawing.Point(12, 38);
            this.lblCjenici.Name = "lblCjenici";
            this.lblCjenici.Size = new System.Drawing.Size(70, 13);
            this.lblCjenici.TabIndex = 0;
            this.lblCjenici.Text = "Popis cjenika";
            // 
            // dgvCjenik
            // 
            this.dgvCjenik.AllowUserToAddRows = false;
            this.dgvCjenik.AllowUserToDeleteRows = false;
            this.dgvCjenik.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCjenik.AutoGenerateColumns = false;
            this.dgvCjenik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCjenik.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_cjenika,
            this.datumDataGridViewTextBoxColumn,
            this.vazeciDataGridViewCheckBoxColumn});
            this.dgvCjenik.DataSource = this.cjenikBindingSource;
            this.dgvCjenik.Location = new System.Drawing.Point(12, 54);
            this.dgvCjenik.Name = "dgvCjenik";
            this.dgvCjenik.ReadOnly = true;
            this.dgvCjenik.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCjenik.Size = new System.Drawing.Size(759, 190);
            this.dgvCjenik.TabIndex = 1;
            this.dgvCjenik.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCjenik_SelectionChanged);
            // 
            // cjenikBindingSource
            // 
            this.cjenikBindingSource.DataMember = "Cjenik";
            this.cjenikBindingSource.DataSource = this.bazaDataSet;
            // 
            // bazaDataSet
            // 
            this.bazaDataSet.DataSetName = "BazaDataSet";
            this.bazaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblStavkeCjenika
            // 
            this.lblStavkeCjenika.AutoSize = true;
            this.lblStavkeCjenika.Location = new System.Drawing.Point(12, 263);
            this.lblStavkeCjenika.Name = "lblStavkeCjenika";
            this.lblStavkeCjenika.Size = new System.Drawing.Size(78, 13);
            this.lblStavkeCjenika.TabIndex = 2;
            this.lblStavkeCjenika.Text = "Stavke cjenika";
            // 
            // dgvStavkeCjenika
            // 
            this.dgvStavkeCjenika.AllowUserToAddRows = false;
            this.dgvStavkeCjenika.AllowUserToDeleteRows = false;
            this.dgvStavkeCjenika.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStavkeCjenika.AutoGenerateColumns = false;
            this.dgvStavkeCjenika.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStavkeCjenika.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDstavkeDataGridViewTextBoxColumn,
            this.iDcjenikaDataGridViewTextBoxColumn1,
            this.iDuslugeDataGridViewTextBoxColumn,
            this.ID_usluge,
            this.Column1,
            this.Column2});
            this.dgvStavkeCjenika.DataSource = this.stavka_cjenikaBindingSource;
            this.dgvStavkeCjenika.Location = new System.Drawing.Point(12, 279);
            this.dgvStavkeCjenika.Name = "dgvStavkeCjenika";
            this.dgvStavkeCjenika.ReadOnly = true;
            this.dgvStavkeCjenika.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStavkeCjenika.Size = new System.Drawing.Size(759, 215);
            this.dgvStavkeCjenika.TabIndex = 3;
            // 
            // uslugaBindingSource
            // 
            this.uslugaBindingSource.DataMember = "Usluga";
            this.uslugaBindingSource.DataSource = this.bazaDataSet;
            // 
            // mjernajedinicaBindingSource
            // 
            this.mjernajedinicaBindingSource.DataMember = "Mjerna_jedinica";
            this.mjernajedinicaBindingSource.DataSource = this.bazaDataSet;
            // 
            // stavka_cjenikaBindingSource
            // 
            this.stavka_cjenikaBindingSource.DataMember = "Stavka_cjenika";
            this.stavka_cjenikaBindingSource.DataSource = this.bazaDataSet;
            // 
            // cjenikTableAdapter
            // 
            this.cjenikTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdminTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CjenikTableAdapter = this.cjenikTableAdapter;
            this.tableAdapterManager.CrmTableAdapter = null;
            this.tableAdapterManager.KlijentTableAdapter = null;
            this.tableAdapterManager.KorisnikTableAdapter = null;
            this.tableAdapterManager.Mjerna_jedinicaTableAdapter = null;
            this.tableAdapterManager.RacunTableAdapter = null;
            this.tableAdapterManager.Stavka_cjenikaTableAdapter = this.stavka_cjenikaTableAdapter;
            this.tableAdapterManager.Stavka_racunaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Aplikacija.BazaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UslugaTableAdapter = null;
            // 
            // stavka_cjenikaTableAdapter
            // 
            this.stavka_cjenikaTableAdapter.ClearBeforeFill = true;
            // 
            // btnUredi
            // 
            this.btnUredi.Location = new System.Drawing.Point(383, 500);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(75, 23);
            this.btnUredi.TabIndex = 6;
            this.btnUredi.Text = "Uredi";
            this.btnUredi.UseVisualStyleBackColor = true;
            this.btnUredi.Click += new System.EventHandler(this.btnUredi_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(302, 500);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 5;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // uslugaTableAdapter
            // 
            this.uslugaTableAdapter.ClearBeforeFill = true;
            // 
            // mjerna_jedinicaTableAdapter
            // 
            this.mjerna_jedinicaTableAdapter.ClearBeforeFill = true;
            // 
            // btnNatrag
            // 
            this.btnNatrag.Location = new System.Drawing.Point(12, 12);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(30, 23);
            this.btnNatrag.TabIndex = 8;
            this.btnNatrag.Text = "<-----";
            this.btnNatrag.UseVisualStyleBackColor = true;
            this.btnNatrag.Click += new System.EventHandler(this.btnNatrag_Click);
            // 
            // ID_cjenika
            // 
            this.ID_cjenika.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID_cjenika.DataPropertyName = "ID_cjenika";
            this.ID_cjenika.HeaderText = "ID cjenika";
            this.ID_cjenika.Name = "ID_cjenika";
            this.ID_cjenika.ReadOnly = true;
            // 
            // datumDataGridViewTextBoxColumn
            // 
            this.datumDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.datumDataGridViewTextBoxColumn.DataPropertyName = "datum";
            this.datumDataGridViewTextBoxColumn.HeaderText = "Datum kreiranja";
            this.datumDataGridViewTextBoxColumn.Name = "datumDataGridViewTextBoxColumn";
            this.datumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vazeciDataGridViewCheckBoxColumn
            // 
            this.vazeciDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.vazeciDataGridViewCheckBoxColumn.DataPropertyName = "vazeci";
            this.vazeciDataGridViewCheckBoxColumn.HeaderText = "Važeći cjenik?";
            this.vazeciDataGridViewCheckBoxColumn.Name = "vazeciDataGridViewCheckBoxColumn";
            this.vazeciDataGridViewCheckBoxColumn.ReadOnly = true;
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
            // iDcjenikaDataGridViewTextBoxColumn1
            // 
            this.iDcjenikaDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iDcjenikaDataGridViewTextBoxColumn1.DataPropertyName = "ID_cjenika";
            this.iDcjenikaDataGridViewTextBoxColumn1.HeaderText = "ID_cjenika";
            this.iDcjenikaDataGridViewTextBoxColumn1.Name = "iDcjenikaDataGridViewTextBoxColumn1";
            this.iDcjenikaDataGridViewTextBoxColumn1.ReadOnly = true;
            this.iDcjenikaDataGridViewTextBoxColumn1.Visible = false;
            // 
            // iDuslugeDataGridViewTextBoxColumn
            // 
            this.iDuslugeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iDuslugeDataGridViewTextBoxColumn.DataPropertyName = "ID_usluge";
            this.iDuslugeDataGridViewTextBoxColumn.DataSource = this.uslugaBindingSource;
            this.iDuslugeDataGridViewTextBoxColumn.DisplayMember = "naziv";
            this.iDuslugeDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.iDuslugeDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.iDuslugeDataGridViewTextBoxColumn.Name = "iDuslugeDataGridViewTextBoxColumn";
            this.iDuslugeDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDuslugeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iDuslugeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iDuslugeDataGridViewTextBoxColumn.ValueMember = "ID_usluge";
            // 
            // ID_usluge
            // 
            this.ID_usluge.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID_usluge.DataPropertyName = "ID_usluge";
            this.ID_usluge.DataSource = this.uslugaBindingSource;
            this.ID_usluge.DisplayMember = "opis";
            this.ID_usluge.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.ID_usluge.HeaderText = "Opis";
            this.ID_usluge.Name = "ID_usluge";
            this.ID_usluge.ReadOnly = true;
            this.ID_usluge.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ID_usluge.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ID_usluge.ValueMember = "ID_usluge";
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "ID_usluge";
            this.Column1.DataSource = this.mjernajedinicaBindingSource;
            this.Column1.DisplayMember = "Naziv";
            this.Column1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Column1.HeaderText = "Mjerna jedinica";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column1.ValueMember = "ID_mjerne_jedinice";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "ID_usluge";
            this.Column2.DataSource = this.uslugaBindingSource;
            this.Column2.DisplayMember = "cijena";
            this.Column2.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Column2.HeaderText = "Cijena";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column2.ValueMember = "ID_usluge";
            // 
            // frmCjenici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.ControlBox = false;
            this.Controls.Add(this.btnNatrag);
            this.Controls.Add(this.btnUredi);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dgvStavkeCjenika);
            this.Controls.Add(this.lblStavkeCjenika);
            this.Controls.Add(this.dgvCjenik);
            this.Controls.Add(this.lblCjenici);
            this.Name = "frmCjenici";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cjenici";
            this.Load += new System.EventHandler(this.frmCjenici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCjenik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cjenikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeCjenika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uslugaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mjernajedinicaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavka_cjenikaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCjenici;
        private System.Windows.Forms.DataGridView dgvCjenik;
        private System.Windows.Forms.Label lblStavkeCjenika;
        private System.Windows.Forms.DataGridView dgvStavkeCjenika;
        private BazaDataSet bazaDataSet;
        private System.Windows.Forms.BindingSource cjenikBindingSource;
        private BazaDataSetTableAdapters.CjenikTableAdapter cjenikTableAdapter;
        private BazaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private BazaDataSetTableAdapters.Stavka_cjenikaTableAdapter stavka_cjenikaTableAdapter;
        private System.Windows.Forms.BindingSource stavka_cjenikaBindingSource;
        private System.Windows.Forms.Button btnUredi;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.BindingSource uslugaBindingSource;
        private BazaDataSetTableAdapters.UslugaTableAdapter uslugaTableAdapter;
        private System.Windows.Forms.BindingSource mjernajedinicaBindingSource;
        private BazaDataSetTableAdapters.Mjerna_jedinicaTableAdapter mjerna_jedinicaTableAdapter;
        private System.Windows.Forms.Button btnNatrag;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_cjenika;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn vazeciDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDstavkeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDcjenikaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn iDuslugeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn ID_usluge;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column1;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column2;
    }
}