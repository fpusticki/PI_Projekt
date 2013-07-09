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
            System.Windows.Forms.Label iD_racunaLabel;
            System.Windows.Forms.Label datumLabel;
            System.Windows.Forms.Label iD_korisnikaLabel;
            System.Windows.Forms.Label iD_klijentaLabel;
            System.Windows.Forms.Label broj_dolazakaLabel;
            this.dgvStavkeCjenika = new System.Windows.Forms.DataGridView();
            this.iDstavkeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDcjenikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDuslugeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.uslugaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bazaDataSet = new Aplikacija.BazaDataSet();
            this.Opis = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Mjerna_jedinica = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.mjernajedinicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Cijena = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.stavkacjenikaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvStavkeRacuna = new System.Windows.Forms.DataGridView();
            this.iDstavkeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv_stavke = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Opis_stavke = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Mjerna_jedinica_stavke = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Cijena_stavke = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.iDracunaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDuslugeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stavkaracunaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.stavka_cjenikaTableAdapter = new Aplikacija.BazaDataSetTableAdapters.Stavka_cjenikaTableAdapter();
            this.stavka_racunaTableAdapter = new Aplikacija.BazaDataSetTableAdapters.Stavka_racunaTableAdapter();
            this.uslugaTableAdapter = new Aplikacija.BazaDataSetTableAdapters.UslugaTableAdapter();
            this.mjerna_jedinicaTableAdapter = new Aplikacija.BazaDataSetTableAdapters.Mjerna_jedinicaTableAdapter();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnPonisti = new System.Windows.Forms.Button();
            this.racunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.racunTableAdapter = new Aplikacija.BazaDataSetTableAdapters.RacunTableAdapter();
            this.tableAdapterManager = new Aplikacija.BazaDataSetTableAdapters.TableAdapterManager();
            this.iD_racunaTextBox = new System.Windows.Forms.TextBox();
            this.datumDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.iD_korisnikaTextBox = new System.Windows.Forms.TextBox();
            this.iD_klijentaComboBox = new System.Windows.Forms.ComboBox();
            this.klijentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.klijentTableAdapter = new Aplikacija.BazaDataSetTableAdapters.KlijentTableAdapter();
            this.broj_dolazakaTextBox = new System.Windows.Forms.TextBox();
            iD_racunaLabel = new System.Windows.Forms.Label();
            datumLabel = new System.Windows.Forms.Label();
            iD_korisnikaLabel = new System.Windows.Forms.Label();
            iD_klijentaLabel = new System.Windows.Forms.Label();
            broj_dolazakaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeCjenika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uslugaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mjernajedinicaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkacjenikaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeRacuna)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkaracunaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racunBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klijentBindingSource)).BeginInit();
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
            // uslugaBindingSource
            // 
            this.uslugaBindingSource.DataMember = "Usluga";
            this.uslugaBindingSource.DataSource = this.bazaDataSet;
            // 
            // bazaDataSet
            // 
            this.bazaDataSet.DataSetName = "BazaDataSet";
            this.bazaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // stavkacjenikaBindingSource
            // 
            this.stavkacjenikaBindingSource.DataMember = "Stavka_cjenika";
            this.stavkacjenikaBindingSource.DataSource = this.bazaDataSet;
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
            // stavkaracunaBindingSource
            // 
            this.stavkaracunaBindingSource.DataMember = "Stavka_racuna";
            this.stavkaracunaBindingSource.DataSource = this.bazaDataSet;
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
            // stavka_cjenikaTableAdapter
            // 
            this.stavka_cjenikaTableAdapter.ClearBeforeFill = true;
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
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(587, 527);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(88, 23);
            this.btnSpremi.TabIndex = 4;
            this.btnSpremi.Text = "Spremi i ispiši";
            this.btnSpremi.UseVisualStyleBackColor = true;
            // 
            // btnPonisti
            // 
            this.btnPonisti.Location = new System.Drawing.Point(681, 527);
            this.btnPonisti.Name = "btnPonisti";
            this.btnPonisti.Size = new System.Drawing.Size(91, 23);
            this.btnPonisti.TabIndex = 5;
            this.btnPonisti.Text = "Poništi";
            this.btnPonisti.UseVisualStyleBackColor = true;
            this.btnPonisti.Click += new System.EventHandler(this.btnPonisti_Click);
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdminTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CjenikTableAdapter = null;
            this.tableAdapterManager.CrmTableAdapter = null;
            this.tableAdapterManager.KlijentTableAdapter = this.klijentTableAdapter;
            this.tableAdapterManager.KorisnikTableAdapter = null;
            this.tableAdapterManager.Mjerna_jedinicaTableAdapter = this.mjerna_jedinicaTableAdapter;
            this.tableAdapterManager.RacunTableAdapter = this.racunTableAdapter;
            this.tableAdapterManager.Stavka_cjenikaTableAdapter = this.stavka_cjenikaTableAdapter;
            this.tableAdapterManager.Stavka_racunaTableAdapter = this.stavka_racunaTableAdapter;
            this.tableAdapterManager.UpdateOrder = Aplikacija.BazaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UslugaTableAdapter = this.uslugaTableAdapter;
            // 
            // iD_racunaLabel
            // 
            iD_racunaLabel.AutoSize = true;
            iD_racunaLabel.Location = new System.Drawing.Point(12, 430);
            iD_racunaLabel.Name = "iD_racunaLabel";
            iD_racunaLabel.Size = new System.Drawing.Size(57, 13);
            iD_racunaLabel.TabIndex = 6;
            iD_racunaLabel.Text = "ID racuna:";
            // 
            // iD_racunaTextBox
            // 
            this.iD_racunaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.racunBindingSource, "ID_racuna", true));
            this.iD_racunaTextBox.Location = new System.Drawing.Point(84, 427);
            this.iD_racunaTextBox.Name = "iD_racunaTextBox";
            this.iD_racunaTextBox.Size = new System.Drawing.Size(200, 20);
            this.iD_racunaTextBox.TabIndex = 7;
            // 
            // datumLabel
            // 
            datumLabel.AutoSize = true;
            datumLabel.Location = new System.Drawing.Point(12, 472);
            datumLabel.Name = "datumLabel";
            datumLabel.Size = new System.Drawing.Size(39, 13);
            datumLabel.TabIndex = 8;
            datumLabel.Text = "datum:";
            // 
            // datumDateTimePicker
            // 
            this.datumDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.racunBindingSource, "datum", true));
            this.datumDateTimePicker.Location = new System.Drawing.Point(84, 466);
            this.datumDateTimePicker.Name = "datumDateTimePicker";
            this.datumDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.datumDateTimePicker.TabIndex = 9;
            // 
            // iD_korisnikaLabel
            // 
            iD_korisnikaLabel.AutoSize = true;
            iD_korisnikaLabel.Location = new System.Drawing.Point(12, 517);
            iD_korisnikaLabel.Name = "iD_korisnikaLabel";
            iD_korisnikaLabel.Size = new System.Drawing.Size(66, 13);
            iD_korisnikaLabel.TabIndex = 10;
            iD_korisnikaLabel.Text = "ID korisnika:";
            // 
            // iD_korisnikaTextBox
            // 
            this.iD_korisnikaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.racunBindingSource, "ID_korisnika", true));
            this.iD_korisnikaTextBox.Location = new System.Drawing.Point(84, 514);
            this.iD_korisnikaTextBox.Name = "iD_korisnikaTextBox";
            this.iD_korisnikaTextBox.Size = new System.Drawing.Size(200, 20);
            this.iD_korisnikaTextBox.TabIndex = 11;
            // 
            // iD_klijentaLabel
            // 
            iD_klijentaLabel.AutoSize = true;
            iD_klijentaLabel.Location = new System.Drawing.Point(363, 430);
            iD_klijentaLabel.Name = "iD_klijentaLabel";
            iD_klijentaLabel.Size = new System.Drawing.Size(57, 13);
            iD_klijentaLabel.TabIndex = 12;
            iD_klijentaLabel.Text = "ID klijenta:";
            // 
            // iD_klijentaComboBox
            // 
            this.iD_klijentaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.racunBindingSource, "ID_klijenta", true));
            this.iD_klijentaComboBox.FormattingEnabled = true;
            this.iD_klijentaComboBox.Location = new System.Drawing.Point(442, 427);
            this.iD_klijentaComboBox.Name = "iD_klijentaComboBox";
            this.iD_klijentaComboBox.Size = new System.Drawing.Size(186, 21);
            this.iD_klijentaComboBox.TabIndex = 13;
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
            // broj_dolazakaLabel
            // 
            broj_dolazakaLabel.AutoSize = true;
            broj_dolazakaLabel.Location = new System.Drawing.Point(363, 472);
            broj_dolazakaLabel.Name = "broj_dolazakaLabel";
            broj_dolazakaLabel.Size = new System.Drawing.Size(73, 13);
            broj_dolazakaLabel.TabIndex = 14;
            broj_dolazakaLabel.Text = "broj dolazaka:";
            // 
            // broj_dolazakaTextBox
            // 
            this.broj_dolazakaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klijentBindingSource, "broj_dolazaka", true));
            this.broj_dolazakaTextBox.Location = new System.Drawing.Point(442, 469);
            this.broj_dolazakaTextBox.Name = "broj_dolazakaTextBox";
            this.broj_dolazakaTextBox.Size = new System.Drawing.Size(100, 20);
            this.broj_dolazakaTextBox.TabIndex = 15;
            // 
            // frmNoviRacun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 580);
            this.Controls.Add(broj_dolazakaLabel);
            this.Controls.Add(this.broj_dolazakaTextBox);
            this.Controls.Add(iD_klijentaLabel);
            this.Controls.Add(this.iD_klijentaComboBox);
            this.Controls.Add(iD_korisnikaLabel);
            this.Controls.Add(this.iD_korisnikaTextBox);
            this.Controls.Add(datumLabel);
            this.Controls.Add(this.datumDateTimePicker);
            this.Controls.Add(iD_racunaLabel);
            this.Controls.Add(this.iD_racunaTextBox);
            this.Controls.Add(this.btnPonisti);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvStavkeRacuna);
            this.Controls.Add(this.dgvStavkeCjenika);
            this.Name = "frmNoviRacun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novi račun";
            this.Load += new System.EventHandler(this.frmNoviRacun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeCjenika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uslugaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mjernajedinicaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkacjenikaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeRacuna)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkaracunaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racunBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klijentBindingSource)).EndInit();
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
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnPonisti;
        private System.Windows.Forms.BindingSource racunBindingSource;
        private BazaDataSetTableAdapters.RacunTableAdapter racunTableAdapter;
        private BazaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox iD_racunaTextBox;
        private System.Windows.Forms.DateTimePicker datumDateTimePicker;
        private System.Windows.Forms.TextBox iD_korisnikaTextBox;
        private System.Windows.Forms.ComboBox iD_klijentaComboBox;
        private BazaDataSetTableAdapters.KlijentTableAdapter klijentTableAdapter;
        private System.Windows.Forms.BindingSource klijentBindingSource;
        private System.Windows.Forms.TextBox broj_dolazakaTextBox;

    }
}