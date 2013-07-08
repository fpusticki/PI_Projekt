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
            System.Windows.Forms.Label iD_klijentaLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPregledStavki = new System.Windows.Forms.DataGridView();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnNatrag = new System.Windows.Forms.Button();
            this.btnPonisti = new System.Windows.Forms.Button();
            this.stavka_racunaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bazaDataSet = new Aplikacija.BazaDataSet();
            this.stavka_racunaTableAdapter = new Aplikacija.BazaDataSetTableAdapters.Stavka_racunaTableAdapter();
            this.tableAdapterManager = new Aplikacija.BazaDataSetTableAdapters.TableAdapterManager();
            this.uslugaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uslugaTableAdapter = new Aplikacija.BazaDataSetTableAdapters.UslugaTableAdapter();
            this.mjernajedinicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mjerna_jedinicaTableAdapter = new Aplikacija.BazaDataSetTableAdapters.Mjerna_jedinicaTableAdapter();
            this.iDstavkeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDracunaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDuslugeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_usluge = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.klijentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.klijentTableAdapter = new Aplikacija.BazaDataSetTableAdapters.KlijentTableAdapter();
            this.racunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.racunTableAdapter = new Aplikacija.BazaDataSetTableAdapters.RacunTableAdapter();
            this.iD_klijentaComboBox = new System.Windows.Forms.ComboBox();
            this.btnDodajStavkuRacuna = new System.Windows.Forms.Button();
            iD_klijentaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregledStavki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavka_racunaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uslugaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mjernajedinicaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klijentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racunBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stavke računa";
            // 
            // dgvPregledStavki
            // 
            this.dgvPregledStavki.AllowUserToAddRows = false;
            this.dgvPregledStavki.AllowUserToDeleteRows = false;
            this.dgvPregledStavki.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPregledStavki.AutoGenerateColumns = false;
            this.dgvPregledStavki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPregledStavki.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDstavkeDataGridViewTextBoxColumn,
            this.iDracunaDataGridViewTextBoxColumn,
            this.iDuslugeDataGridViewTextBoxColumn,
            this.ID_usluge,
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvPregledStavki.DataSource = this.stavka_racunaBindingSource;
            this.dgvPregledStavki.Location = new System.Drawing.Point(12, 54);
            this.dgvPregledStavki.Name = "dgvPregledStavki";
            this.dgvPregledStavki.ReadOnly = true;
            this.dgvPregledStavki.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPregledStavki.Size = new System.Drawing.Size(776, 317);
            this.dgvPregledStavki.TabIndex = 2;
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(280, 500);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(75, 23);
            this.btnSpremi.TabIndex = 4;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
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
            // btnPonisti
            // 
            this.btnPonisti.Location = new System.Drawing.Point(361, 500);
            this.btnPonisti.Name = "btnPonisti";
            this.btnPonisti.Size = new System.Drawing.Size(75, 23);
            this.btnPonisti.TabIndex = 17;
            this.btnPonisti.Text = "Poništi";
            this.btnPonisti.UseVisualStyleBackColor = true;
            this.btnPonisti.Click += new System.EventHandler(this.btnPonisti_Click);
            // 
            // stavka_racunaBindingSource
            // 
            this.stavka_racunaBindingSource.DataMember = "Stavka_racuna";
            this.stavka_racunaBindingSource.DataSource = this.bazaDataSet;
            // 
            // bazaDataSet
            // 
            this.bazaDataSet.DataSetName = "BazaDataSet";
            this.bazaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stavka_racunaTableAdapter
            // 
            this.stavka_racunaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdminTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CjenikTableAdapter = null;
            this.tableAdapterManager.CrmTableAdapter = null;
            this.tableAdapterManager.KlijentTableAdapter = null;
            this.tableAdapterManager.KorisnikTableAdapter = null;
            this.tableAdapterManager.Mjerna_jedinicaTableAdapter = null;
            this.tableAdapterManager.RacunTableAdapter = null;
            this.tableAdapterManager.Stavka_cjenikaTableAdapter = null;
            this.tableAdapterManager.Stavka_racunaTableAdapter = this.stavka_racunaTableAdapter;
            this.tableAdapterManager.UpdateOrder = Aplikacija.BazaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UslugaTableAdapter = null;
            // 
            // uslugaBindingSource
            // 
            this.uslugaBindingSource.DataMember = "Usluga";
            this.uslugaBindingSource.DataSource = this.bazaDataSet;
            // 
            // uslugaTableAdapter
            // 
            this.uslugaTableAdapter.ClearBeforeFill = true;
            // 
            // mjernajedinicaBindingSource
            // 
            this.mjernajedinicaBindingSource.DataMember = "Mjerna_jedinica";
            this.mjernajedinicaBindingSource.DataSource = this.bazaDataSet;
            // 
            // mjerna_jedinicaTableAdapter
            // 
            this.mjerna_jedinicaTableAdapter.ClearBeforeFill = true;
            // 
            // iDstavkeDataGridViewTextBoxColumn
            // 
            this.iDstavkeDataGridViewTextBoxColumn.DataPropertyName = "ID_stavke";
            this.iDstavkeDataGridViewTextBoxColumn.HeaderText = "ID_stavke";
            this.iDstavkeDataGridViewTextBoxColumn.Name = "iDstavkeDataGridViewTextBoxColumn";
            this.iDstavkeDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDstavkeDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDracunaDataGridViewTextBoxColumn
            // 
            this.iDracunaDataGridViewTextBoxColumn.DataPropertyName = "ID_racuna";
            this.iDracunaDataGridViewTextBoxColumn.HeaderText = "ID_racuna";
            this.iDracunaDataGridViewTextBoxColumn.Name = "iDracunaDataGridViewTextBoxColumn";
            this.iDracunaDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDracunaDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDuslugeDataGridViewTextBoxColumn
            // 
            this.iDuslugeDataGridViewTextBoxColumn.DataPropertyName = "ID_usluge";
            this.iDuslugeDataGridViewTextBoxColumn.HeaderText = "ID usluge";
            this.iDuslugeDataGridViewTextBoxColumn.Name = "iDuslugeDataGridViewTextBoxColumn";
            this.iDuslugeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ID_usluge
            // 
            this.ID_usluge.DataPropertyName = "ID_usluge";
            this.ID_usluge.DataSource = this.uslugaBindingSource;
            this.ID_usluge.DisplayMember = "naziv";
            this.ID_usluge.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.ID_usluge.HeaderText = "Naziv";
            this.ID_usluge.Name = "ID_usluge";
            this.ID_usluge.ReadOnly = true;
            this.ID_usluge.ValueMember = "ID_usluge";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID_usluge";
            this.Column1.DataSource = this.uslugaBindingSource;
            this.Column1.DisplayMember = "opis";
            this.Column1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Column1.HeaderText = "Opis";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.ValueMember = "ID_usluge";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "ID_usluge";
            this.Column2.DataSource = this.mjernajedinicaBindingSource;
            this.Column2.DisplayMember = "Naziv";
            this.Column2.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Column2.HeaderText = "Mjerna jedinica";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.ValueMember = "ID_mjerne_jedinice";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "ID_usluge";
            this.Column3.DataSource = this.uslugaBindingSource;
            this.Column3.DisplayMember = "cijena";
            this.Column3.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Column3.HeaderText = "Cijena";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.ValueMember = "ID_usluge";
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
            // iD_klijentaLabel
            // 
            iD_klijentaLabel.AutoSize = true;
            iD_klijentaLabel.Location = new System.Drawing.Point(29, 463);
            iD_klijentaLabel.Name = "iD_klijentaLabel";
            iD_klijentaLabel.Size = new System.Drawing.Size(57, 13);
            iD_klijentaLabel.TabIndex = 17;
            iD_klijentaLabel.Text = "ID klijenta:";
            // 
            // iD_klijentaComboBox
            // 
            this.iD_klijentaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.racunBindingSource, "ID_klijenta", true));
            this.iD_klijentaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.racunBindingSource, "ID_klijenta", true));
            this.iD_klijentaComboBox.DataSource = this.klijentBindingSource;
            this.iD_klijentaComboBox.DisplayMember = "prezime";
            this.iD_klijentaComboBox.FormattingEnabled = true;
            this.iD_klijentaComboBox.Location = new System.Drawing.Point(92, 460);
            this.iD_klijentaComboBox.Name = "iD_klijentaComboBox";
            this.iD_klijentaComboBox.Size = new System.Drawing.Size(121, 21);
            this.iD_klijentaComboBox.TabIndex = 18;
            this.iD_klijentaComboBox.ValueMember = "ID_klijenta";
            // 
            // btnDodajStavkuRacuna
            // 
            this.btnDodajStavkuRacuna.Location = new System.Drawing.Point(32, 418);
            this.btnDodajStavkuRacuna.Name = "btnDodajStavkuRacuna";
            this.btnDodajStavkuRacuna.Size = new System.Drawing.Size(181, 23);
            this.btnDodajStavkuRacuna.TabIndex = 19;
            this.btnDodajStavkuRacuna.Text = "Dodaj stavku";
            this.btnDodajStavkuRacuna.UseVisualStyleBackColor = true;
            // 
            // frmRacun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 562);
            this.ControlBox = false;
            this.Controls.Add(this.btnDodajStavkuRacuna);
            this.Controls.Add(iD_klijentaLabel);
            this.Controls.Add(this.iD_klijentaComboBox);
            this.Controls.Add(this.btnPonisti);
            this.Controls.Add(this.btnNatrag);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.dgvPregledStavki);
            this.Controls.Add(this.label1);
            this.Name = "frmRacun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Račun";
            this.Load += new System.EventHandler(this.frmRacun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregledStavki)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavka_racunaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uslugaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mjernajedinicaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klijentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racunBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPregledStavki;
        private System.Windows.Forms.Button btnSpremi;
        private BazaDataSet bazaDataSet;
        private System.Windows.Forms.BindingSource stavka_racunaBindingSource;
        private BazaDataSetTableAdapters.Stavka_racunaTableAdapter stavka_racunaTableAdapter;
        private BazaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btnNatrag;
        private System.Windows.Forms.Button btnPonisti;
        private System.Windows.Forms.BindingSource uslugaBindingSource;
        private BazaDataSetTableAdapters.UslugaTableAdapter uslugaTableAdapter;
        private System.Windows.Forms.BindingSource mjernajedinicaBindingSource;
        private BazaDataSetTableAdapters.Mjerna_jedinicaTableAdapter mjerna_jedinicaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDstavkeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDracunaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDuslugeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn ID_usluge;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column1;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column2;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column3;
        private System.Windows.Forms.BindingSource klijentBindingSource;
        private BazaDataSetTableAdapters.KlijentTableAdapter klijentTableAdapter;
        private System.Windows.Forms.BindingSource racunBindingSource;
        private BazaDataSetTableAdapters.RacunTableAdapter racunTableAdapter;
        private System.Windows.Forms.ComboBox iD_klijentaComboBox;
        private System.Windows.Forms.Button btnDodajStavkuRacuna;
    }
}