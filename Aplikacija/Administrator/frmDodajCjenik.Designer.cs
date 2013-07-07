namespace Aplikacija.Administrator
{
    partial class frmDodajCjenik
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
            this.btnPonisti = new System.Windows.Forms.Button();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.bazaDataSet = new Aplikacija.BazaDataSet();
            this.cjenikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cjenikTableAdapter = new Aplikacija.BazaDataSetTableAdapters.CjenikTableAdapter();
            this.tableAdapterManager = new Aplikacija.BazaDataSetTableAdapters.TableAdapterManager();
            this.iD_cjenikaTextBox = new System.Windows.Forms.TextBox();
            this.datumDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btnDodajStavke = new System.Windows.Forms.Button();
            this.chbVazeci = new System.Windows.Forms.CheckBox();
            iD_cjenikaLabel = new System.Windows.Forms.Label();
            datumLabel = new System.Windows.Forms.Label();
            vazeciLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bazaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cjenikBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_cjenikaLabel
            // 
            iD_cjenikaLabel.AutoSize = true;
            iD_cjenikaLabel.Location = new System.Drawing.Point(52, 50);
            iD_cjenikaLabel.Name = "iD_cjenikaLabel";
            iD_cjenikaLabel.Size = new System.Drawing.Size(58, 13);
            iD_cjenikaLabel.TabIndex = 28;
            iD_cjenikaLabel.Text = "ID cjenika:";
            // 
            // datumLabel
            // 
            datumLabel.AutoSize = true;
            datumLabel.Location = new System.Drawing.Point(52, 90);
            datumLabel.Name = "datumLabel";
            datumLabel.Size = new System.Drawing.Size(41, 13);
            datumLabel.TabIndex = 29;
            datumLabel.Text = "Datum:";
            // 
            // vazeciLabel
            // 
            vazeciLabel.AutoSize = true;
            vazeciLabel.Location = new System.Drawing.Point(52, 130);
            vazeciLabel.Name = "vazeciLabel";
            vazeciLabel.Size = new System.Drawing.Size(42, 13);
            vazeciLabel.TabIndex = 30;
            vazeciLabel.Text = "Važeći:";
            // 
            // btnPonisti
            // 
            this.btnPonisti.Location = new System.Drawing.Point(376, 202);
            this.btnPonisti.Name = "btnPonisti";
            this.btnPonisti.Size = new System.Drawing.Size(75, 23);
            this.btnPonisti.TabIndex = 27;
            this.btnPonisti.Text = "Poništi";
            this.btnPonisti.UseVisualStyleBackColor = true;
            this.btnPonisti.Click += new System.EventHandler(this.btnPonisti_Click);
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(295, 202);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(75, 23);
            this.btnSpremi.TabIndex = 26;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // bazaDataSet
            // 
            this.bazaDataSet.DataSetName = "BazaDataSet";
            this.bazaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.tableAdapterManager.Stavka_cjenikaTableAdapter = null;
            this.tableAdapterManager.Stavka_racunaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Aplikacija.BazaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UslugaTableAdapter = null;
            // 
            // iD_cjenikaTextBox
            // 
            this.iD_cjenikaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cjenikBindingSource, "ID_cjenika", true));
            this.iD_cjenikaTextBox.Location = new System.Drawing.Point(130, 50);
            this.iD_cjenikaTextBox.Name = "iD_cjenikaTextBox";
            this.iD_cjenikaTextBox.Size = new System.Drawing.Size(140, 20);
            this.iD_cjenikaTextBox.TabIndex = 29;
            // 
            // datumDateTimePicker
            // 
            this.datumDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.cjenikBindingSource, "datum", true));
            this.datumDateTimePicker.Location = new System.Drawing.Point(130, 90);
            this.datumDateTimePicker.Name = "datumDateTimePicker";
            this.datumDateTimePicker.Size = new System.Drawing.Size(140, 20);
            this.datumDateTimePicker.TabIndex = 30;
            // 
            // btnDodajStavke
            // 
            this.btnDodajStavke.Location = new System.Drawing.Point(52, 170);
            this.btnDodajStavke.Name = "btnDodajStavke";
            this.btnDodajStavke.Size = new System.Drawing.Size(115, 23);
            this.btnDodajStavke.TabIndex = 32;
            this.btnDodajStavke.Text = "Dodaj stavke";
            this.btnDodajStavke.UseVisualStyleBackColor = true;
            this.btnDodajStavke.Click += new System.EventHandler(this.btnDodajStavke_Click);
            // 
            // chbVazeci
            // 
            this.chbVazeci.AutoSize = true;
            this.chbVazeci.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.cjenikBindingSource, "vazeci", true));
            this.chbVazeci.Location = new System.Drawing.Point(130, 130);
            this.chbVazeci.Name = "chbVazeci";
            this.chbVazeci.Size = new System.Drawing.Size(40, 17);
            this.chbVazeci.TabIndex = 33;
            this.chbVazeci.Text = "Da";
            this.chbVazeci.UseVisualStyleBackColor = true;
            // 
            // frmDodajCjenik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 262);
            this.Controls.Add(this.chbVazeci);
            this.Controls.Add(this.btnDodajStavke);
            this.Controls.Add(vazeciLabel);
            this.Controls.Add(datumLabel);
            this.Controls.Add(this.datumDateTimePicker);
            this.Controls.Add(iD_cjenikaLabel);
            this.Controls.Add(this.iD_cjenikaTextBox);
            this.Controls.Add(this.btnPonisti);
            this.Controls.Add(this.btnSpremi);
            this.Name = "frmDodajCjenik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novi cjenik";
            this.Load += new System.EventHandler(this.frmDodajCjenik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bazaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cjenikBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPonisti;
        private System.Windows.Forms.Button btnSpremi;
        private BazaDataSet bazaDataSet;
        private System.Windows.Forms.BindingSource cjenikBindingSource;
        private BazaDataSetTableAdapters.CjenikTableAdapter cjenikTableAdapter;
        private BazaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox iD_cjenikaTextBox;
        private System.Windows.Forms.DateTimePicker datumDateTimePicker;
        private System.Windows.Forms.Button btnDodajStavke;
        private System.Windows.Forms.CheckBox chbVazeci;
    }
}