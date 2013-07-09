namespace Aplikacija.Korisnik_folder
{
    partial class frmNoviRacun
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
            this.dgvStavkeCjenika = new System.Windows.Forms.DataGridView();
            this.dgvStavkeRacuna = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bazaDataSet = new Aplikacija.BazaDataSet();
            this.stavkacjenikaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stavka_cjenikaTableAdapter = new Aplikacija.BazaDataSetTableAdapters.Stavka_cjenikaTableAdapter();
            this.stavkaracunaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stavka_racunaTableAdapter = new Aplikacija.BazaDataSetTableAdapters.Stavka_racunaTableAdapter();
            this.uslugaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uslugaTableAdapter = new Aplikacija.BazaDataSetTableAdapters.UslugaTableAdapter();
            this.mjernajedinicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mjerna_jedinicaTableAdapter = new Aplikacija.BazaDataSetTableAdapters.Mjerna_jedinicaTableAdapter();
            this.iDstavkeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDcjenikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDuslugeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Opis = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Mjerna_jedinica = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.iDstavkeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv_stavke = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Opis_stavke = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Mjerna_jedinica_stavke = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Cijena_stavke = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.iDracunaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDuslugeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeCjenika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeRacuna)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkacjenikaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkaracunaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uslugaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mjernajedinicaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStavkeCjenika
            // 
            this.dgvStavkeCjenika.AllowUserToAddRows = false;
            this.dgvStavkeCjenika.AllowUserToDeleteRows = false;
            this.dgvStavkeCjenika.AutoGenerateColumns = false;
            this.dgvStavkeCjenika.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStavkeCjenika.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDstavkeDataGridViewTextBoxColumn,
            this.iDcjenikaDataGridViewTextBoxColumn,
            this.iDuslugeDataGridViewTextBoxColumn,
            this.Naziv,
            this.Opis,
            this.Mjerna_jedinica,
            this.Cijena});
            this.dgvStavkeCjenika.DataSource = this.stavkacjenikaBindingSource;
            this.dgvStavkeCjenika.Location = new System.Drawing.Point(12, 25);
            this.dgvStavkeCjenika.Name = "dgvStavkeCjenika";
            this.dgvStavkeCjenika.ReadOnly = true;
            this.dgvStavkeCjenika.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStavkeCjenika.Size = new System.Drawing.Size(760, 207);
            this.dgvStavkeCjenika.TabIndex = 0;
            // 
            // dgvStavkeRacuna
            // 
            this.dgvStavkeRacuna.AllowUserToAddRows = false;
            this.dgvStavkeRacuna.AllowUserToDeleteRows = false;
            this.dgvStavkeRacuna.AutoGenerateColumns = false;
            this.dgvStavkeRacuna.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStavkeRacuna.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDstavkeDataGridViewTextBoxColumn1,
            this.Naziv_stavke,
            this.Opis_stavke,
            this.Mjerna_jedinica_stavke,
            this.Cijena_stavke,
            this.iDracunaDataGridViewTextBoxColumn,
            this.iDuslugeDataGridViewTextBoxColumn1});
            this.dgvStavkeRacuna.DataSource = this.stavkaracunaBindingSource;
            this.dgvStavkeRacuna.Location = new System.Drawing.Point(12, 251);
            this.dgvStavkeRacuna.Name = "dgvStavkeRacuna";
            this.dgvStavkeRacuna.ReadOnly = true;
            this.dgvStavkeRacuna.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStavkeRacuna.Size = new System.Drawing.Size(760, 160);
            this.dgvStavkeRacuna.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usluge";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Stavke računa";
            // 
            // bazaDataSet
            // 
            this.bazaDataSet.DataSetName = "BazaDataSet";
            this.bazaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stavkacjenikaBindingSource
            // 
            this.stavkacjenikaBindingSource.DataMember = "Stavka_cjenika";
            this.stavkacjenikaBindingSource.DataSource = this.bazaDataSet;
            // 
            // stavka_cjenikaTableAdapter
            // 
            this.stavka_cjenikaTableAdapter.ClearBeforeFill = true;
            // 
            // stavkaracunaBindingSource
            // 
            this.stavkaracunaBindingSource.DataMember = "Stavka_racuna";
            this.stavkaracunaBindingSource.DataSource = this.bazaDataSet;
            // 
            // stavka_racunaTableAdapter
            // 
            this.stavka_racunaTableAdapter.ClearBeforeFill = true;
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
            this.iDstavkeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iDstavkeDataGridViewTextBoxColumn.DataPropertyName = "ID_stavke";
            this.iDstavkeDataGridViewTextBoxColumn.HeaderText = "ID_stavke";
            this.iDstavkeDataGridViewTextBoxColumn.Name = "iDstavkeDataGridViewTextBoxColumn";
            this.iDstavkeDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDstavkeDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDcjenikaDataGridViewTextBoxColumn
            // 
            this.iDcjenikaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iDcjenikaDataGridViewTextBoxColumn.DataPropertyName = "ID_cjenika";
            this.iDcjenikaDataGridViewTextBoxColumn.HeaderText = "ID_cjenika";
            this.iDcjenikaDataGridViewTextBoxColumn.Name = "iDcjenikaDataGridViewTextBoxColumn";
            this.iDcjenikaDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDcjenikaDataGridViewTextBoxColumn.Visible = false;
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
            // iDstavkeDataGridViewTextBoxColumn1
            // 
            this.iDstavkeDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iDstavkeDataGridViewTextBoxColumn1.DataPropertyName = "ID_stavke";
            this.iDstavkeDataGridViewTextBoxColumn1.HeaderText = "ID_stavke";
            this.iDstavkeDataGridViewTextBoxColumn1.Name = "iDstavkeDataGridViewTextBoxColumn1";
            this.iDstavkeDataGridViewTextBoxColumn1.ReadOnly = true;
            this.iDstavkeDataGridViewTextBoxColumn1.Visible = false;
            // 
            // Naziv_stavke
            // 
            this.Naziv_stavke.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Naziv_stavke.DataSource = this.uslugaBindingSource;
            this.Naziv_stavke.DisplayMember = "naziv";
            this.Naziv_stavke.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Naziv_stavke.HeaderText = "Naziv";
            this.Naziv_stavke.Name = "Naziv_stavke";
            this.Naziv_stavke.ReadOnly = true;
            this.Naziv_stavke.ValueMember = "ID_usluge";
            // 
            // Opis_stavke
            // 
            this.Opis_stavke.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Opis_stavke.DataSource = this.uslugaBindingSource;
            this.Opis_stavke.DisplayMember = "opis";
            this.Opis_stavke.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Opis_stavke.HeaderText = "Opis";
            this.Opis_stavke.Name = "Opis_stavke";
            this.Opis_stavke.ReadOnly = true;
            this.Opis_stavke.ValueMember = "ID_usluge";
            // 
            // Mjerna_jedinica_stavke
            // 
            this.Mjerna_jedinica_stavke.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Mjerna_jedinica_stavke.DataSource = this.mjernajedinicaBindingSource;
            this.Mjerna_jedinica_stavke.DisplayMember = "Naziv";
            this.Mjerna_jedinica_stavke.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Mjerna_jedinica_stavke.HeaderText = "Mjerna jedinica";
            this.Mjerna_jedinica_stavke.Name = "Mjerna_jedinica_stavke";
            this.Mjerna_jedinica_stavke.ReadOnly = true;
            this.Mjerna_jedinica_stavke.ValueMember = "ID_mjerne_jedinice";
            // 
            // Cijena_stavke
            // 
            this.Cijena_stavke.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cijena_stavke.DataSource = this.uslugaBindingSource;
            this.Cijena_stavke.DisplayMember = "cijena";
            this.Cijena_stavke.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Cijena_stavke.HeaderText = "Cijena";
            this.Cijena_stavke.Name = "Cijena_stavke";
            this.Cijena_stavke.ReadOnly = true;
            this.Cijena_stavke.ValueMember = "ID_usluge";
            // 
            // iDracunaDataGridViewTextBoxColumn
            // 
            this.iDracunaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iDracunaDataGridViewTextBoxColumn.DataPropertyName = "ID_racuna";
            this.iDracunaDataGridViewTextBoxColumn.HeaderText = "ID_racuna";
            this.iDracunaDataGridViewTextBoxColumn.Name = "iDracunaDataGridViewTextBoxColumn";
            this.iDracunaDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDracunaDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDuslugeDataGridViewTextBoxColumn1
            // 
            this.iDuslugeDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iDuslugeDataGridViewTextBoxColumn1.DataPropertyName = "ID_usluge";
            this.iDuslugeDataGridViewTextBoxColumn1.HeaderText = "ID_usluge";
            this.iDuslugeDataGridViewTextBoxColumn1.Name = "iDuslugeDataGridViewTextBoxColumn1";
            this.iDuslugeDataGridViewTextBoxColumn1.ReadOnly = true;
            this.iDuslugeDataGridViewTextBoxColumn1.Visible = false;
            // 
            // frmNoviRacun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvStavkeRacuna);
            this.Controls.Add(this.dgvStavkeCjenika);
            this.Name = "frmNoviRacun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novi račun";
            this.Load += new System.EventHandler(this.frmNoviRacun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeCjenika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeRacuna)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkacjenikaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkaracunaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uslugaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mjernajedinicaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStavkeCjenika;
        private System.Windows.Forms.DataGridView dgvStavkeRacuna;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private BazaDataSet bazaDataSet;
        private System.Windows.Forms.BindingSource stavkacjenikaBindingSource;
        private BazaDataSetTableAdapters.Stavka_cjenikaTableAdapter stavka_cjenikaTableAdapter;
        private System.Windows.Forms.BindingSource stavkaracunaBindingSource;
        private BazaDataSetTableAdapters.Stavka_racunaTableAdapter stavka_racunaTableAdapter;
        private System.Windows.Forms.BindingSource uslugaBindingSource;
        private BazaDataSetTableAdapters.UslugaTableAdapter uslugaTableAdapter;
        private System.Windows.Forms.BindingSource mjernajedinicaBindingSource;
        private BazaDataSetTableAdapters.Mjerna_jedinicaTableAdapter mjerna_jedinicaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDstavkeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDcjenikaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDuslugeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewComboBoxColumn Opis;
        private System.Windows.Forms.DataGridViewComboBoxColumn Mjerna_jedinica;
        private System.Windows.Forms.DataGridViewComboBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDstavkeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn Naziv_stavke;
        private System.Windows.Forms.DataGridViewComboBoxColumn Opis_stavke;
        private System.Windows.Forms.DataGridViewComboBoxColumn Mjerna_jedinica_stavke;
        private System.Windows.Forms.DataGridViewComboBoxColumn Cijena_stavke;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDracunaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDuslugeDataGridViewTextBoxColumn1;

    }
}