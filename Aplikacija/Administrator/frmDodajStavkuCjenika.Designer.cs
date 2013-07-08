namespace Aplikacija.Administrator
{
    partial class frmDodajStavkuCjenika
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
            System.Windows.Forms.Label iD_uslugeLabel;
            System.Windows.Forms.Label nazivLabel;
            System.Windows.Forms.Label opisLabel;
            System.Windows.Forms.Label cijenaLabel;
            System.Windows.Forms.Label iD_mjerne_jediniceLabel;
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.iD_cjenikaTextBox = new System.Windows.Forms.TextBox();
            this.cjenikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bazaDataSet = new Aplikacija.BazaDataSet();
            this.iD_uslugeTextBox = new System.Windows.Forms.TextBox();
            this.uslugaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nazivTextBox = new System.Windows.Forms.TextBox();
            this.opisTextBox = new System.Windows.Forms.TextBox();
            this.mjerna_jedinicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cijenaTextBox = new System.Windows.Forms.TextBox();
            this.btnOdabir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mjerna_jedinica = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stavka_cjenikaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stavka_cjenikaTableAdapter = new Aplikacija.BazaDataSetTableAdapters.Stavka_cjenikaTableAdapter();
            this.tableAdapterManager = new Aplikacija.BazaDataSetTableAdapters.TableAdapterManager();
            this.cjenikTableAdapter = new Aplikacija.BazaDataSetTableAdapters.CjenikTableAdapter();
            this.mjerna_jedinicaTableAdapter = new Aplikacija.BazaDataSetTableAdapters.Mjerna_jedinicaTableAdapter();
            this.uslugaTableAdapter = new Aplikacija.BazaDataSetTableAdapters.UslugaTableAdapter();
            this.iD_mjerne_jediniceTextBox = new System.Windows.Forms.TextBox();
            this.uslugaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            iD_cjenikaLabel = new System.Windows.Forms.Label();
            iD_uslugeLabel = new System.Windows.Forms.Label();
            nazivLabel = new System.Windows.Forms.Label();
            opisLabel = new System.Windows.Forms.Label();
            cijenaLabel = new System.Windows.Forms.Label();
            iD_mjerne_jediniceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cjenikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uslugaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mjerna_jedinicaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavka_cjenikaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uslugaBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_cjenikaLabel
            // 
            iD_cjenikaLabel.AutoSize = true;
            iD_cjenikaLabel.Location = new System.Drawing.Point(138, 15);
            iD_cjenikaLabel.Name = "iD_cjenikaLabel";
            iD_cjenikaLabel.Size = new System.Drawing.Size(58, 13);
            iD_cjenikaLabel.TabIndex = 29;
            iD_cjenikaLabel.Text = "ID cjenika:";
            // 
            // iD_uslugeLabel
            // 
            iD_uslugeLabel.AutoSize = true;
            iD_uslugeLabel.Location = new System.Drawing.Point(141, 45);
            iD_uslugeLabel.Name = "iD_uslugeLabel";
            iD_uslugeLabel.Size = new System.Drawing.Size(55, 13);
            iD_uslugeLabel.TabIndex = 30;
            iD_uslugeLabel.Text = "ID usluge:";
            // 
            // nazivLabel
            // 
            nazivLabel.AutoSize = true;
            nazivLabel.Location = new System.Drawing.Point(161, 75);
            nazivLabel.Name = "nazivLabel";
            nazivLabel.Size = new System.Drawing.Size(37, 13);
            nazivLabel.TabIndex = 31;
            nazivLabel.Text = "Naziv:";
            // 
            // opisLabel
            // 
            opisLabel.AutoSize = true;
            opisLabel.Location = new System.Drawing.Point(474, 75);
            opisLabel.Name = "opisLabel";
            opisLabel.Size = new System.Drawing.Size(31, 13);
            opisLabel.TabIndex = 32;
            opisLabel.Text = "Opis:";
            // 
            // cijenaLabel
            // 
            cijenaLabel.AutoSize = true;
            cijenaLabel.Location = new System.Drawing.Point(465, 45);
            cijenaLabel.Name = "cijenaLabel";
            cijenaLabel.Size = new System.Drawing.Size(39, 13);
            cijenaLabel.TabIndex = 34;
            cijenaLabel.Text = "Cijena:";
            // 
            // iD_mjerne_jediniceLabel
            // 
            iD_mjerne_jediniceLabel.AutoSize = true;
            iD_mjerne_jediniceLabel.Location = new System.Drawing.Point(409, 15);
            iD_mjerne_jediniceLabel.Name = "iD_mjerne_jediniceLabel";
            iD_mjerne_jediniceLabel.Size = new System.Drawing.Size(78, 13);
            iD_mjerne_jediniceLabel.TabIndex = 37;
            iD_mjerne_jediniceLabel.Text = "Mjerna jedinica";
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(387, 500);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(75, 23);
            this.btnSpremi.TabIndex = 29;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click_1);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(306, 500);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 28;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // iD_cjenikaTextBox
            // 
            this.iD_cjenikaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cjenikBindingSource, "ID_cjenika", true));
            this.iD_cjenikaTextBox.Location = new System.Drawing.Point(211, 12);
            this.iD_cjenikaTextBox.Name = "iD_cjenikaTextBox";
            this.iD_cjenikaTextBox.Size = new System.Drawing.Size(142, 20);
            this.iD_cjenikaTextBox.TabIndex = 30;
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
            // iD_uslugeTextBox
            // 
            this.iD_uslugeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uslugaBindingSource, "ID_usluge", true));
            this.iD_uslugeTextBox.Location = new System.Drawing.Point(211, 42);
            this.iD_uslugeTextBox.Name = "iD_uslugeTextBox";
            this.iD_uslugeTextBox.Size = new System.Drawing.Size(142, 20);
            this.iD_uslugeTextBox.TabIndex = 31;
            // 
            // uslugaBindingSource
            // 
            this.uslugaBindingSource.DataMember = "Usluga";
            this.uslugaBindingSource.DataSource = this.bazaDataSet;
            // 
            // nazivTextBox
            // 
            this.nazivTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uslugaBindingSource, "naziv", true));
            this.nazivTextBox.Location = new System.Drawing.Point(211, 72);
            this.nazivTextBox.Name = "nazivTextBox";
            this.nazivTextBox.Size = new System.Drawing.Size(142, 20);
            this.nazivTextBox.TabIndex = 32;
            // 
            // opisTextBox
            // 
            this.opisTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uslugaBindingSource, "opis", true));
            this.opisTextBox.Location = new System.Drawing.Point(509, 72);
            this.opisTextBox.Multiline = true;
            this.opisTextBox.Name = "opisTextBox";
            this.opisTextBox.Size = new System.Drawing.Size(263, 66);
            this.opisTextBox.TabIndex = 33;
            // 
            // mjerna_jedinicaBindingSource
            // 
            this.mjerna_jedinicaBindingSource.DataMember = "Mjerna_jedinica";
            this.mjerna_jedinicaBindingSource.DataSource = this.bazaDataSet;
            // 
            // cijenaTextBox
            // 
            this.cijenaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uslugaBindingSource, "cijena", true));
            this.cijenaTextBox.Location = new System.Drawing.Point(509, 42);
            this.cijenaTextBox.Name = "cijenaTextBox";
            this.cijenaTextBox.Size = new System.Drawing.Size(121, 20);
            this.cijenaTextBox.TabIndex = 35;
            // 
            // btnOdabir
            // 
            this.btnOdabir.Location = new System.Drawing.Point(359, 42);
            this.btnOdabir.Name = "btnOdabir";
            this.btnOdabir.Size = new System.Drawing.Size(30, 23);
            this.btnOdabir.TabIndex = 36;
            this.btnOdabir.Text = "...";
            this.btnOdabir.UseVisualStyleBackColor = true;
            this.btnOdabir.Click += new System.EventHandler(this.btnOdabir_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Naziv,
            this.Mjerna_jedinica,
            this.cijena,
            this.opis});
            this.dataGridView1.Location = new System.Drawing.Point(12, 144);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(768, 350);
            this.dataGridView1.TabIndex = 37;
            // 
            // Naziv
            // 
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // Mjerna_jedinica
            // 
            this.Mjerna_jedinica.DataSource = this.mjerna_jedinicaBindingSource;
            this.Mjerna_jedinica.DisplayMember = "Naziv";
            this.Mjerna_jedinica.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Mjerna_jedinica.HeaderText = "Mjerna jedinica";
            this.Mjerna_jedinica.Name = "Mjerna_jedinica";
            this.Mjerna_jedinica.ReadOnly = true;
            this.Mjerna_jedinica.ValueMember = "ID_mjerne_jedinice";
            // 
            // cijena
            // 
            this.cijena.HeaderText = "Cijena";
            this.cijena.Name = "cijena";
            this.cijena.ReadOnly = true;
            // 
            // opis
            // 
            this.opis.HeaderText = "Opis";
            this.opis.Name = "opis";
            this.opis.ReadOnly = true;
            // 
            // stavka_cjenikaBindingSource
            // 
            this.stavka_cjenikaBindingSource.DataMember = "Stavka_cjenika";
            this.stavka_cjenikaBindingSource.DataSource = this.bazaDataSet;
            // 
            // stavka_cjenikaTableAdapter
            // 
            this.stavka_cjenikaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdminTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CjenikTableAdapter = this.cjenikTableAdapter;
            this.tableAdapterManager.CrmTableAdapter = null;
            this.tableAdapterManager.KlijentTableAdapter = null;
            this.tableAdapterManager.KorisnikTableAdapter = null;
            this.tableAdapterManager.Mjerna_jedinicaTableAdapter = this.mjerna_jedinicaTableAdapter;
            this.tableAdapterManager.RacunTableAdapter = null;
            this.tableAdapterManager.Stavka_cjenikaTableAdapter = this.stavka_cjenikaTableAdapter;
            this.tableAdapterManager.Stavka_racunaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Aplikacija.BazaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UslugaTableAdapter = this.uslugaTableAdapter;
            // 
            // cjenikTableAdapter
            // 
            this.cjenikTableAdapter.ClearBeforeFill = true;
            // 
            // mjerna_jedinicaTableAdapter
            // 
            this.mjerna_jedinicaTableAdapter.ClearBeforeFill = true;
            // 
            // uslugaTableAdapter
            // 
            this.uslugaTableAdapter.ClearBeforeFill = true;
            // 
            // iD_mjerne_jediniceTextBox
            // 
            this.iD_mjerne_jediniceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mjerna_jedinicaBindingSource, "Naziv", true));
            this.iD_mjerne_jediniceTextBox.Location = new System.Drawing.Point(509, 12);
            this.iD_mjerne_jediniceTextBox.Name = "iD_mjerne_jediniceTextBox";
            this.iD_mjerne_jediniceTextBox.Size = new System.Drawing.Size(100, 20);
            this.iD_mjerne_jediniceTextBox.TabIndex = 38;
            // 
            // uslugaBindingSource1
            // 
            this.uslugaBindingSource1.DataMember = "FK_Usluga_Mjerna_jedinica";
            this.uslugaBindingSource1.DataSource = this.mjerna_jedinicaBindingSource;
            // 
            // frmDodajStavkuCjenika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 562);
            this.Controls.Add(iD_mjerne_jediniceLabel);
            this.Controls.Add(this.iD_mjerne_jediniceTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnOdabir);
            this.Controls.Add(cijenaLabel);
            this.Controls.Add(this.cijenaTextBox);
            this.Controls.Add(opisLabel);
            this.Controls.Add(this.opisTextBox);
            this.Controls.Add(nazivLabel);
            this.Controls.Add(this.nazivTextBox);
            this.Controls.Add(iD_uslugeLabel);
            this.Controls.Add(this.iD_uslugeTextBox);
            this.Controls.Add(iD_cjenikaLabel);
            this.Controls.Add(this.iD_cjenikaTextBox);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.btnDodaj);
            this.Name = "frmDodajStavkuCjenika";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stavke cjenika";
            this.Load += new System.EventHandler(this.frmDodajStavkuCjenika_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.cjenikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uslugaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mjerna_jedinicaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavka_cjenikaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uslugaBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.TextBox iD_cjenikaTextBox;
        private System.Windows.Forms.TextBox iD_uslugeTextBox;
        private System.Windows.Forms.TextBox nazivTextBox;
        private System.Windows.Forms.TextBox opisTextBox;
        private System.Windows.Forms.TextBox cijenaTextBox;
        private System.Windows.Forms.Button btnOdabir;
        private System.Windows.Forms.DataGridView dataGridView1;
        private BazaDataSet bazaDataSet;
        private System.Windows.Forms.BindingSource stavka_cjenikaBindingSource;
        private BazaDataSetTableAdapters.Stavka_cjenikaTableAdapter stavka_cjenikaTableAdapter;
        private BazaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private BazaDataSetTableAdapters.CjenikTableAdapter cjenikTableAdapter;
        private System.Windows.Forms.BindingSource cjenikBindingSource;
        private BazaDataSetTableAdapters.UslugaTableAdapter uslugaTableAdapter;
        private System.Windows.Forms.BindingSource uslugaBindingSource;
        private BazaDataSetTableAdapters.Mjerna_jedinicaTableAdapter mjerna_jedinicaTableAdapter;
        private System.Windows.Forms.BindingSource mjerna_jedinicaBindingSource;
        private System.Windows.Forms.TextBox iD_mjerne_jediniceTextBox;
        private System.Windows.Forms.BindingSource uslugaBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewComboBoxColumn Mjerna_jedinica;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn opis;
    }
}