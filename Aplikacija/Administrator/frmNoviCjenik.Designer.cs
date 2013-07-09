namespace Aplikacija.Administrator
{
    partial class frmNoviCjenik
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
            System.Windows.Forms.Label iD_cjenikaLabel;
            System.Windows.Forms.Label datumLabel;
            System.Windows.Forms.Label vazeciLabel;
            this.dgvPopisUsluga = new System.Windows.Forms.DataGridView();
            this.mjernajedinicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bazaDataSet = new Aplikacija.BazaDataSet();
            this.uslugaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uslugaTableAdapter = new Aplikacija.BazaDataSetTableAdapters.UslugaTableAdapter();
            this.tableAdapterManager = new Aplikacija.BazaDataSetTableAdapters.TableAdapterManager();
            this.mjerna_jedinicaTableAdapter = new Aplikacija.BazaDataSetTableAdapters.Mjerna_jedinicaTableAdapter();
            this.dgvOdabraneUsluge = new System.Windows.Forms.DataGridView();
            this.stavkacjenikaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stavka_cjenikaTableAdapter = new Aplikacija.BazaDataSetTableAdapters.Stavka_cjenikaTableAdapter();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnPonisti = new System.Windows.Forms.Button();
            this.cjenikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cjenikTableAdapter = new Aplikacija.BazaDataSetTableAdapters.CjenikTableAdapter();
            this.iD_cjenikaTextBox = new System.Windows.Forms.TextBox();
            this.datumDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.vazeciCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.iDuslugeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDmjernejediniceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cijenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDstavkeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDcjenikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDuslugeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Opis = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Mjerna_jedinica = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewComboBoxColumn();
            iD_cjenikaLabel = new System.Windows.Forms.Label();
            datumLabel = new System.Windows.Forms.Label();
            vazeciLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisUsluga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mjernajedinicaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uslugaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdabraneUsluge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkacjenikaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cjenikBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_cjenikaLabel
            // 
            iD_cjenikaLabel.AutoSize = true;
            iD_cjenikaLabel.Location = new System.Drawing.Point(12, 532);
            iD_cjenikaLabel.Name = "iD_cjenikaLabel";
            iD_cjenikaLabel.Size = new System.Drawing.Size(58, 13);
            iD_cjenikaLabel.TabIndex = 5;
            iD_cjenikaLabel.Text = "ID cjenika:";
            // 
            // datumLabel
            // 
            datumLabel.AutoSize = true;
            datumLabel.Location = new System.Drawing.Point(206, 532);
            datumLabel.Name = "datumLabel";
            datumLabel.Size = new System.Drawing.Size(41, 13);
            datumLabel.TabIndex = 6;
            datumLabel.Text = "Datum:";
            // 
            // vazeciLabel
            // 
            vazeciLabel.AutoSize = true;
            vazeciLabel.Location = new System.Drawing.Point(431, 532);
            vazeciLabel.Name = "vazeciLabel";
            vazeciLabel.Size = new System.Drawing.Size(42, 13);
            vazeciLabel.TabIndex = 8;
            vazeciLabel.Text = "Važeći:";
            // 
            // dgvPopisUsluga
            // 
            this.dgvPopisUsluga.AllowUserToAddRows = false;
            this.dgvPopisUsluga.AllowUserToDeleteRows = false;
            this.dgvPopisUsluga.AutoGenerateColumns = false;
            this.dgvPopisUsluga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPopisUsluga.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDuslugeDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.opisDataGridViewTextBoxColumn,
            this.iDmjernejediniceDataGridViewTextBoxColumn,
            this.cijenaDataGridViewTextBoxColumn});
            this.dgvPopisUsluga.DataSource = this.uslugaBindingSource;
            this.dgvPopisUsluga.Location = new System.Drawing.Point(12, 25);
            this.dgvPopisUsluga.Name = "dgvPopisUsluga";
            this.dgvPopisUsluga.ReadOnly = true;
            this.dgvPopisUsluga.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPopisUsluga.Size = new System.Drawing.Size(760, 243);
            this.dgvPopisUsluga.TabIndex = 2;
            this.dgvPopisUsluga.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPopisUsluga_CellClick);
            // 
            // mjernajedinicaBindingSource
            // 
            this.mjernajedinicaBindingSource.DataMember = "Mjerna_jedinica";
            this.mjernajedinicaBindingSource.DataSource = this.bazaDataSet;
            // 
            // bazaDataSet
            // 
            this.bazaDataSet.DataSetName = "BazaDataSet";
            this.bazaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdminTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CjenikTableAdapter = null;
            this.tableAdapterManager.CrmTableAdapter = null;
            this.tableAdapterManager.KlijentTableAdapter = null;
            this.tableAdapterManager.KorisnikTableAdapter = null;
            this.tableAdapterManager.Mjerna_jedinicaTableAdapter = this.mjerna_jedinicaTableAdapter;
            this.tableAdapterManager.RacunTableAdapter = null;
            this.tableAdapterManager.Stavka_cjenikaTableAdapter = null;
            this.tableAdapterManager.Stavka_racunaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Aplikacija.BazaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UslugaTableAdapter = this.uslugaTableAdapter;
            // 
            // mjerna_jedinicaTableAdapter
            // 
            this.mjerna_jedinicaTableAdapter.ClearBeforeFill = true;
            // 
            // dgvOdabraneUsluge
            // 
            this.dgvOdabraneUsluge.AllowUserToAddRows = false;
            this.dgvOdabraneUsluge.AllowUserToDeleteRows = false;
            this.dgvOdabraneUsluge.AutoGenerateColumns = false;
            this.dgvOdabraneUsluge.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOdabraneUsluge.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDstavkeDataGridViewTextBoxColumn,
            this.iDcjenikaDataGridViewTextBoxColumn,
            this.iDuslugeDataGridViewTextBoxColumn1,
            this.Naziv,
            this.Opis,
            this.Mjerna_jedinica,
            this.Cijena});
            this.dgvOdabraneUsluge.DataSource = this.stavkacjenikaBindingSource;
            this.dgvOdabraneUsluge.Location = new System.Drawing.Point(12, 287);
            this.dgvOdabraneUsluge.Name = "dgvOdabraneUsluge";
            this.dgvOdabraneUsluge.ReadOnly = true;
            this.dgvOdabraneUsluge.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOdabraneUsluge.Size = new System.Drawing.Size(760, 234);
            this.dgvOdabraneUsluge.TabIndex = 3;
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
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(615, 527);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(75, 23);
            this.btnSpremi.TabIndex = 4;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // btnPonisti
            // 
            this.btnPonisti.Location = new System.Drawing.Point(696, 527);
            this.btnPonisti.Name = "btnPonisti";
            this.btnPonisti.Size = new System.Drawing.Size(75, 23);
            this.btnPonisti.TabIndex = 5;
            this.btnPonisti.Text = "Poništi";
            this.btnPonisti.UseVisualStyleBackColor = true;
            this.btnPonisti.Click += new System.EventHandler(this.btnPonisti_Click);
            // 
            // cjenikBindingSource
            // 
            this.cjenikBindingSource.DataMember = "Cjenik";
            this.cjenikBindingSource.DataSource = this.bazaDataSet;
            // 
            // cjenikTableAdapter
            // 
            this.cjenikTableAdapter.ClearBeforeFill = true;
            // 
            // iD_cjenikaTextBox
            // 
            this.iD_cjenikaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cjenikBindingSource, "ID_cjenika", true));
            this.iD_cjenikaTextBox.Location = new System.Drawing.Point(76, 529);
            this.iD_cjenikaTextBox.Name = "iD_cjenikaTextBox";
            this.iD_cjenikaTextBox.Size = new System.Drawing.Size(74, 20);
            this.iD_cjenikaTextBox.TabIndex = 6;
            // 
            // datumDateTimePicker
            // 
            this.datumDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.cjenikBindingSource, "datum", true));
            this.datumDateTimePicker.Location = new System.Drawing.Point(251, 528);
            this.datumDateTimePicker.Name = "datumDateTimePicker";
            this.datumDateTimePicker.Size = new System.Drawing.Size(121, 20);
            this.datumDateTimePicker.TabIndex = 7;
            // 
            // vazeciCheckBox
            // 
            this.vazeciCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.cjenikBindingSource, "vazeci", true));
            this.vazeciCheckBox.Location = new System.Drawing.Point(478, 527);
            this.vazeciCheckBox.Name = "vazeciCheckBox";
            this.vazeciCheckBox.Size = new System.Drawing.Size(48, 24);
            this.vazeciCheckBox.TabIndex = 9;
            this.vazeciCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Usluge";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Stavke cjenika";
            // 
            // iDuslugeDataGridViewTextBoxColumn
            // 
            this.iDuslugeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iDuslugeDataGridViewTextBoxColumn.DataPropertyName = "ID_usluge";
            this.iDuslugeDataGridViewTextBoxColumn.HeaderText = "ID usluge";
            this.iDuslugeDataGridViewTextBoxColumn.Name = "iDuslugeDataGridViewTextBoxColumn";
            this.iDuslugeDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDuslugeDataGridViewTextBoxColumn.Visible = false;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // opisDataGridViewTextBoxColumn
            // 
            this.opisDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.opisDataGridViewTextBoxColumn.DataPropertyName = "opis";
            this.opisDataGridViewTextBoxColumn.HeaderText = "Opis";
            this.opisDataGridViewTextBoxColumn.Name = "opisDataGridViewTextBoxColumn";
            this.opisDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDmjernejediniceDataGridViewTextBoxColumn
            // 
            this.iDmjernejediniceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iDmjernejediniceDataGridViewTextBoxColumn.DataPropertyName = "ID_mjerne_jedinice";
            this.iDmjernejediniceDataGridViewTextBoxColumn.DataSource = this.mjernajedinicaBindingSource;
            this.iDmjernejediniceDataGridViewTextBoxColumn.DisplayMember = "Naziv";
            this.iDmjernejediniceDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.iDmjernejediniceDataGridViewTextBoxColumn.HeaderText = "Mjerna jedinica";
            this.iDmjernejediniceDataGridViewTextBoxColumn.Name = "iDmjernejediniceDataGridViewTextBoxColumn";
            this.iDmjernejediniceDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDmjernejediniceDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iDmjernejediniceDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iDmjernejediniceDataGridViewTextBoxColumn.ValueMember = "ID_mjerne_jedinice";
            // 
            // cijenaDataGridViewTextBoxColumn
            // 
            this.cijenaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cijenaDataGridViewTextBoxColumn.DataPropertyName = "cijena";
            this.cijenaDataGridViewTextBoxColumn.HeaderText = "Cijena";
            this.cijenaDataGridViewTextBoxColumn.Name = "cijenaDataGridViewTextBoxColumn";
            this.cijenaDataGridViewTextBoxColumn.ReadOnly = true;
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
            // iDuslugeDataGridViewTextBoxColumn1
            // 
            this.iDuslugeDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iDuslugeDataGridViewTextBoxColumn1.DataPropertyName = "ID_usluge";
            this.iDuslugeDataGridViewTextBoxColumn1.HeaderText = "ID_usluge";
            this.iDuslugeDataGridViewTextBoxColumn1.Name = "iDuslugeDataGridViewTextBoxColumn1";
            this.iDuslugeDataGridViewTextBoxColumn1.ReadOnly = true;
            this.iDuslugeDataGridViewTextBoxColumn1.Visible = false;
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
            // frmNoviCjenik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 583);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(vazeciLabel);
            this.Controls.Add(this.vazeciCheckBox);
            this.Controls.Add(datumLabel);
            this.Controls.Add(this.datumDateTimePicker);
            this.Controls.Add(iD_cjenikaLabel);
            this.Controls.Add(this.iD_cjenikaTextBox);
            this.Controls.Add(this.btnPonisti);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.dgvOdabraneUsluge);
            this.Controls.Add(this.dgvPopisUsluga);
            this.Name = "frmNoviCjenik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novi cjenik";
            this.Load += new System.EventHandler(this.frmNoviCjenik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisUsluga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mjernajedinicaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uslugaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdabraneUsluge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkacjenikaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cjenikBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPopisUsluga;
        private BazaDataSet bazaDataSet;
        private System.Windows.Forms.BindingSource uslugaBindingSource;
        private BazaDataSetTableAdapters.UslugaTableAdapter uslugaTableAdapter;
        private BazaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private BazaDataSetTableAdapters.Mjerna_jedinicaTableAdapter mjerna_jedinicaTableAdapter;
        private System.Windows.Forms.BindingSource mjernajedinicaBindingSource;
        private System.Windows.Forms.DataGridView dgvOdabraneUsluge;
        private System.Windows.Forms.BindingSource stavkacjenikaBindingSource;
        private BazaDataSetTableAdapters.Stavka_cjenikaTableAdapter stavka_cjenikaTableAdapter;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnPonisti;
        private System.Windows.Forms.BindingSource cjenikBindingSource;
        private BazaDataSetTableAdapters.CjenikTableAdapter cjenikTableAdapter;
        private System.Windows.Forms.TextBox iD_cjenikaTextBox;
        private System.Windows.Forms.DateTimePicker datumDateTimePicker;
        private System.Windows.Forms.CheckBox vazeciCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDuslugeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn iDmjernejediniceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDstavkeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDcjenikaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDuslugeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewComboBoxColumn Opis;
        private System.Windows.Forms.DataGridViewComboBoxColumn Mjerna_jedinica;
        private System.Windows.Forms.DataGridViewComboBoxColumn Cijena;
    }
}