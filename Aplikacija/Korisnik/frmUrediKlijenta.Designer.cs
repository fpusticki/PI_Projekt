namespace Aplikacija.Korisnik
{
    partial class frmUrediKlijenta
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
            System.Windows.Forms.Label newsletterLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label telefonLabel;
            System.Windows.Forms.Label spolLabel;
            System.Windows.Forms.Label prezimeLabel;
            System.Windows.Forms.Label imeLabel;
            this.newsletterCheckBox = new System.Windows.Forms.CheckBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.telefonTextBox = new System.Windows.Forms.TextBox();
            this.spolTextBox = new System.Windows.Forms.TextBox();
            this.prezimeTextBox = new System.Windows.Forms.TextBox();
            this.imeTextBox = new System.Windows.Forms.TextBox();
            this.btnPonisti = new System.Windows.Forms.Button();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.bazaDataSet = new Aplikacija.BazaDataSet();
            this.klijentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.klijentTableAdapter = new Aplikacija.BazaDataSetTableAdapters.KlijentTableAdapter();
            this.tableAdapterManager = new Aplikacija.BazaDataSetTableAdapters.TableAdapterManager();
            newsletterLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            telefonLabel = new System.Windows.Forms.Label();
            spolLabel = new System.Windows.Forms.Label();
            prezimeLabel = new System.Windows.Forms.Label();
            imeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bazaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klijentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // newsletterLabel
            // 
            newsletterLabel.AutoSize = true;
            newsletterLabel.Location = new System.Drawing.Point(52, 191);
            newsletterLabel.Name = "newsletterLabel";
            newsletterLabel.Size = new System.Drawing.Size(60, 13);
            newsletterLabel.TabIndex = 57;
            newsletterLabel.Text = "Newsletter:";
            // 
            // newsletterCheckBox
            // 
            this.newsletterCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.klijentBindingSource, "newsletter", true));
            this.newsletterCheckBox.Location = new System.Drawing.Point(146, 186);
            this.newsletterCheckBox.Name = "newsletterCheckBox";
            this.newsletterCheckBox.Size = new System.Drawing.Size(104, 24);
            this.newsletterCheckBox.TabIndex = 59;
            this.newsletterCheckBox.Text = "Da";
            this.newsletterCheckBox.UseVisualStyleBackColor = true;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(52, 161);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(37, 13);
            emailLabel.TabIndex = 55;
            emailLabel.Text = "e-mail:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klijentBindingSource, "email", true));
            this.emailTextBox.Location = new System.Drawing.Point(120, 161);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(130, 20);
            this.emailTextBox.TabIndex = 58;
            // 
            // telefonLabel
            // 
            telefonLabel.AutoSize = true;
            telefonLabel.Location = new System.Drawing.Point(52, 131);
            telefonLabel.Name = "telefonLabel";
            telefonLabel.Size = new System.Drawing.Size(46, 13);
            telefonLabel.TabIndex = 53;
            telefonLabel.Text = "Telefon:";
            // 
            // telefonTextBox
            // 
            this.telefonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klijentBindingSource, "telefon", true));
            this.telefonTextBox.Location = new System.Drawing.Point(120, 131);
            this.telefonTextBox.Name = "telefonTextBox";
            this.telefonTextBox.Size = new System.Drawing.Size(130, 20);
            this.telefonTextBox.TabIndex = 56;
            // 
            // spolLabel
            // 
            spolLabel.AutoSize = true;
            spolLabel.Location = new System.Drawing.Point(52, 101);
            spolLabel.Name = "spolLabel";
            spolLabel.Size = new System.Drawing.Size(31, 13);
            spolLabel.TabIndex = 51;
            spolLabel.Text = "Spol:";
            // 
            // spolTextBox
            // 
            this.spolTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klijentBindingSource, "spol", true));
            this.spolTextBox.Location = new System.Drawing.Point(120, 101);
            this.spolTextBox.Name = "spolTextBox";
            this.spolTextBox.Size = new System.Drawing.Size(130, 20);
            this.spolTextBox.TabIndex = 54;
            // 
            // prezimeLabel
            // 
            prezimeLabel.AutoSize = true;
            prezimeLabel.Location = new System.Drawing.Point(52, 71);
            prezimeLabel.Name = "prezimeLabel";
            prezimeLabel.Size = new System.Drawing.Size(47, 13);
            prezimeLabel.TabIndex = 49;
            prezimeLabel.Text = "Prezime:";
            // 
            // prezimeTextBox
            // 
            this.prezimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klijentBindingSource, "prezime", true));
            this.prezimeTextBox.Location = new System.Drawing.Point(120, 71);
            this.prezimeTextBox.Name = "prezimeTextBox";
            this.prezimeTextBox.Size = new System.Drawing.Size(130, 20);
            this.prezimeTextBox.TabIndex = 52;
            // 
            // imeLabel
            // 
            imeLabel.AutoSize = true;
            imeLabel.Location = new System.Drawing.Point(52, 41);
            imeLabel.Name = "imeLabel";
            imeLabel.Size = new System.Drawing.Size(27, 13);
            imeLabel.TabIndex = 48;
            imeLabel.Text = "Ime:";
            // 
            // imeTextBox
            // 
            this.imeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klijentBindingSource, "ime", true));
            this.imeTextBox.Location = new System.Drawing.Point(120, 41);
            this.imeTextBox.Name = "imeTextBox";
            this.imeTextBox.Size = new System.Drawing.Size(130, 20);
            this.imeTextBox.TabIndex = 50;
            // 
            // btnPonisti
            // 
            this.btnPonisti.Location = new System.Drawing.Point(376, 203);
            this.btnPonisti.Name = "btnPonisti";
            this.btnPonisti.Size = new System.Drawing.Size(75, 23);
            this.btnPonisti.TabIndex = 47;
            this.btnPonisti.Text = "Poništi";
            this.btnPonisti.UseVisualStyleBackColor = true;
            this.btnPonisti.Click += new System.EventHandler(this.btnPonisti_Click);
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(295, 203);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(75, 23);
            this.btnSpremi.TabIndex = 46;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // bazaDataSet
            // 
            this.bazaDataSet.DataSetName = "BazaDataSet";
            this.bazaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdminTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CjenikTableAdapter = null;
            this.tableAdapterManager.CrmTableAdapter = null;
            this.tableAdapterManager.KlijentTableAdapter = this.klijentTableAdapter;
            this.tableAdapterManager.KorisnikTableAdapter = null;
            this.tableAdapterManager.Mjerna_jedinicaTableAdapter = null;
            this.tableAdapterManager.RacunTableAdapter = null;
            this.tableAdapterManager.Stavka_cjenikaTableAdapter = null;
            this.tableAdapterManager.Stavka_racunaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Aplikacija.BazaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UslugaTableAdapter = null;
            // 
            // frmUrediKlijenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 262);
            this.Controls.Add(newsletterLabel);
            this.Controls.Add(this.newsletterCheckBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(telefonLabel);
            this.Controls.Add(this.telefonTextBox);
            this.Controls.Add(spolLabel);
            this.Controls.Add(this.spolTextBox);
            this.Controls.Add(prezimeLabel);
            this.Controls.Add(this.prezimeTextBox);
            this.Controls.Add(imeLabel);
            this.Controls.Add(this.imeTextBox);
            this.Controls.Add(this.btnPonisti);
            this.Controls.Add(this.btnSpremi);
            this.Name = "frmUrediKlijenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uređivanje klijenta";
            this.Load += new System.EventHandler(this.frmUrediKlijenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bazaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klijentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox newsletterCheckBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox telefonTextBox;
        private System.Windows.Forms.TextBox spolTextBox;
        private System.Windows.Forms.TextBox prezimeTextBox;
        private System.Windows.Forms.TextBox imeTextBox;
        private System.Windows.Forms.Button btnPonisti;
        private System.Windows.Forms.Button btnSpremi;
        private BazaDataSet bazaDataSet;
        private System.Windows.Forms.BindingSource klijentBindingSource;
        private BazaDataSetTableAdapters.KlijentTableAdapter klijentTableAdapter;
        private BazaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}