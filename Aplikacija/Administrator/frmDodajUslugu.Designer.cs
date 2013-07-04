namespace Aplikacija.Administrator
{
    partial class frmDodajUslugu
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
            System.Windows.Forms.Label nazivLabel;
            System.Windows.Forms.Label iD_mjerne_jediniceLabel;
            System.Windows.Forms.Label cijenaLabel;
            System.Windows.Forms.Label opisLabel;
            this.uslugaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bazaDataSet = new Aplikacija.BazaDataSet();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnPonisti = new System.Windows.Forms.Button();
            this.uslugaTableAdapter = new Aplikacija.BazaDataSetTableAdapters.UslugaTableAdapter();
            this.tableAdapterManager = new Aplikacija.BazaDataSetTableAdapters.TableAdapterManager();
            this.mjerna_jedinicaTableAdapter = new Aplikacija.BazaDataSetTableAdapters.Mjerna_jedinicaTableAdapter();
            this.nazivTextBox = new System.Windows.Forms.TextBox();
            this.iD_mjerne_jediniceComboBox = new System.Windows.Forms.ComboBox();
            this.mjerna_jedinicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cijenaTextBox = new System.Windows.Forms.TextBox();
            this.opisTextBox = new System.Windows.Forms.TextBox();
            nazivLabel = new System.Windows.Forms.Label();
            iD_mjerne_jediniceLabel = new System.Windows.Forms.Label();
            cijenaLabel = new System.Windows.Forms.Label();
            opisLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uslugaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mjerna_jedinicaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nazivLabel
            // 
            nazivLabel.AutoSize = true;
            nazivLabel.Location = new System.Drawing.Point(52, 50);
            nazivLabel.Name = "nazivLabel";
            nazivLabel.Size = new System.Drawing.Size(37, 13);
            nazivLabel.TabIndex = 21;
            nazivLabel.Text = "Naziv:";
            // 
            // iD_mjerne_jediniceLabel
            // 
            iD_mjerne_jediniceLabel.AutoSize = true;
            iD_mjerne_jediniceLabel.Location = new System.Drawing.Point(52, 80);
            iD_mjerne_jediniceLabel.Name = "iD_mjerne_jediniceLabel";
            iD_mjerne_jediniceLabel.Size = new System.Drawing.Size(81, 13);
            iD_mjerne_jediniceLabel.TabIndex = 22;
            iD_mjerne_jediniceLabel.Text = "Mjerna jedinica:";
            // 
            // cijenaLabel
            // 
            cijenaLabel.AutoSize = true;
            cijenaLabel.Location = new System.Drawing.Point(52, 110);
            cijenaLabel.Name = "cijenaLabel";
            cijenaLabel.Size = new System.Drawing.Size(39, 13);
            cijenaLabel.TabIndex = 23;
            cijenaLabel.Text = "Cijena:";
            // 
            // opisLabel
            // 
            opisLabel.AutoSize = true;
            opisLabel.Location = new System.Drawing.Point(52, 140);
            opisLabel.Name = "opisLabel";
            opisLabel.Size = new System.Drawing.Size(31, 13);
            opisLabel.TabIndex = 24;
            opisLabel.Text = "Opis:";
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
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(296, 205);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(75, 23);
            this.btnSpremi.TabIndex = 14;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // btnPonisti
            // 
            this.btnPonisti.Location = new System.Drawing.Point(377, 205);
            this.btnPonisti.Name = "btnPonisti";
            this.btnPonisti.Size = new System.Drawing.Size(75, 23);
            this.btnPonisti.TabIndex = 20;
            this.btnPonisti.Text = "Poništi";
            this.btnPonisti.UseVisualStyleBackColor = true;
            this.btnPonisti.Click += new System.EventHandler(this.btnPonisti_Click);
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
            // nazivTextBox
            // 
            this.nazivTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uslugaBindingSource, "naziv", true));
            this.nazivTextBox.Location = new System.Drawing.Point(152, 50);
            this.nazivTextBox.Name = "nazivTextBox";
            this.nazivTextBox.Size = new System.Drawing.Size(100, 20);
            this.nazivTextBox.TabIndex = 22;
            // 
            // iD_mjerne_jediniceComboBox
            // 
            this.iD_mjerne_jediniceComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.uslugaBindingSource, "ID_mjerne_jedinice", true));
            this.iD_mjerne_jediniceComboBox.DataSource = this.mjerna_jedinicaBindingSource;
            this.iD_mjerne_jediniceComboBox.DisplayMember = "Naziv";
            this.iD_mjerne_jediniceComboBox.FormattingEnabled = true;
            this.iD_mjerne_jediniceComboBox.Location = new System.Drawing.Point(152, 80);
            this.iD_mjerne_jediniceComboBox.Name = "iD_mjerne_jediniceComboBox";
            this.iD_mjerne_jediniceComboBox.Size = new System.Drawing.Size(100, 21);
            this.iD_mjerne_jediniceComboBox.TabIndex = 23;
            this.iD_mjerne_jediniceComboBox.ValueMember = "ID_mjerne_jedinice";
            // 
            // mjerna_jedinicaBindingSource
            // 
            this.mjerna_jedinicaBindingSource.DataMember = "Mjerna_jedinica";
            this.mjerna_jedinicaBindingSource.DataSource = this.bazaDataSet;
            // 
            // cijenaTextBox
            // 
            this.cijenaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uslugaBindingSource, "cijena", true));
            this.cijenaTextBox.Location = new System.Drawing.Point(152, 107);
            this.cijenaTextBox.Name = "cijenaTextBox";
            this.cijenaTextBox.Size = new System.Drawing.Size(100, 20);
            this.cijenaTextBox.TabIndex = 24;
            // 
            // opisTextBox
            // 
            this.opisTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uslugaBindingSource, "opis", true));
            this.opisTextBox.Location = new System.Drawing.Point(152, 140);
            this.opisTextBox.Multiline = true;
            this.opisTextBox.Name = "opisTextBox";
            this.opisTextBox.Size = new System.Drawing.Size(300, 59);
            this.opisTextBox.TabIndex = 25;
            // 
            // frmDodajUslugu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 262);
            this.Controls.Add(opisLabel);
            this.Controls.Add(this.opisTextBox);
            this.Controls.Add(cijenaLabel);
            this.Controls.Add(this.cijenaTextBox);
            this.Controls.Add(iD_mjerne_jediniceLabel);
            this.Controls.Add(this.iD_mjerne_jediniceComboBox);
            this.Controls.Add(nazivLabel);
            this.Controls.Add(this.nazivTextBox);
            this.Controls.Add(this.btnPonisti);
            this.Controls.Add(this.btnSpremi);
            this.Name = "frmDodajUslugu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nova usluga";
            this.Load += new System.EventHandler(this.frmDodajUslugu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uslugaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mjerna_jedinicaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnPonisti;
        private BazaDataSet bazaDataSet;
        private System.Windows.Forms.BindingSource uslugaBindingSource;
        private BazaDataSetTableAdapters.UslugaTableAdapter uslugaTableAdapter;
        private BazaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private BazaDataSetTableAdapters.Mjerna_jedinicaTableAdapter mjerna_jedinicaTableAdapter;
        private System.Windows.Forms.TextBox nazivTextBox;
        private System.Windows.Forms.ComboBox iD_mjerne_jediniceComboBox;
        private System.Windows.Forms.TextBox cijenaTextBox;
        private System.Windows.Forms.TextBox opisTextBox;
        private System.Windows.Forms.BindingSource mjerna_jedinicaBindingSource;
    }
}