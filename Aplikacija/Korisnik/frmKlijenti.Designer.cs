namespace Aplikacija.Korisnik
{
    partial class frmKlijenti
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
            this.dgvKlijenti = new System.Windows.Forms.DataGridView();
            this.klijentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bazaDataSet = new Aplikacija.BazaDataSet();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.klijentTableAdapter = new Aplikacija.BazaDataSetTableAdapters.KlijentTableAdapter();
            this.tableAdapterManager = new Aplikacija.BazaDataSetTableAdapters.TableAdapterManager();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnNatrag = new System.Windows.Forms.Button();
            this.btnObriši = new System.Windows.Forms.Button();
            this.btnUredi = new System.Windows.Forms.Button();
            this.iDklijentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newsletterDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.brojdolazakaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zadnjidolazakDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKlijenti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klijentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKlijenti
            // 
            this.dgvKlijenti.AllowUserToAddRows = false;
            this.dgvKlijenti.AllowUserToDeleteRows = false;
            this.dgvKlijenti.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKlijenti.AutoGenerateColumns = false;
            this.dgvKlijenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKlijenti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDklijentaDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.spolDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.newsletterDataGridViewCheckBoxColumn,
            this.brojdolazakaDataGridViewTextBoxColumn,
            this.zadnjidolazakDataGridViewTextBoxColumn});
            this.dgvKlijenti.DataSource = this.klijentBindingSource;
            this.dgvKlijenti.Location = new System.Drawing.Point(13, 41);
            this.dgvKlijenti.Name = "dgvKlijenti";
            this.dgvKlijenti.ReadOnly = true;
            this.dgvKlijenti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKlijenti.Size = new System.Drawing.Size(759, 453);
            this.dgvKlijenti.TabIndex = 0;
            // 
            // klijentBindingSource
            // 
            this.klijentBindingSource.DataMember = "Klijent";
            this.klijentBindingSource.DataSource = this.bazaDataSet;
            // 
            // bazaDataSet
            // 
            this.bazaDataSet.DataSetName = "BazaDataSet";
            this.bazaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnDodaj
            // 
            this.btnDodaj.AutoSize = true;
            this.btnDodaj.Location = new System.Drawing.Point(280, 500);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 4;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
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
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(697, 500);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnNatrag
            // 
            this.btnNatrag.Location = new System.Drawing.Point(12, 12);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(30, 23);
            this.btnNatrag.TabIndex = 15;
            this.btnNatrag.Text = "<-----";
            this.btnNatrag.UseVisualStyleBackColor = true;
            this.btnNatrag.Click += new System.EventHandler(this.btnNatrag_Click);
            // 
            // btnObriši
            // 
            this.btnObriši.AutoSize = true;
            this.btnObriši.Location = new System.Drawing.Point(442, 500);
            this.btnObriši.Name = "btnObriši";
            this.btnObriši.Size = new System.Drawing.Size(75, 23);
            this.btnObriši.TabIndex = 16;
            this.btnObriši.Text = "Obriši";
            this.btnObriši.UseVisualStyleBackColor = true;
            this.btnObriši.Click += new System.EventHandler(this.btnObriši_Click);
            // 
            // btnUredi
            // 
            this.btnUredi.AutoSize = true;
            this.btnUredi.Location = new System.Drawing.Point(361, 500);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(75, 23);
            this.btnUredi.TabIndex = 17;
            this.btnUredi.Text = "Uredi";
            this.btnUredi.UseVisualStyleBackColor = true;
            this.btnUredi.Click += new System.EventHandler(this.btnUredi_Click);
            // 
            // iDklijentaDataGridViewTextBoxColumn
            // 
            this.iDklijentaDataGridViewTextBoxColumn.DataPropertyName = "ID_klijenta";
            this.iDklijentaDataGridViewTextBoxColumn.HeaderText = "ID_klijenta";
            this.iDklijentaDataGridViewTextBoxColumn.Name = "iDklijentaDataGridViewTextBoxColumn";
            this.iDklijentaDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDklijentaDataGridViewTextBoxColumn.Visible = false;
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "Ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            this.imeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prezimeDataGridViewTextBoxColumn
            // 
            this.prezimeDataGridViewTextBoxColumn.DataPropertyName = "prezime";
            this.prezimeDataGridViewTextBoxColumn.HeaderText = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.Name = "prezimeDataGridViewTextBoxColumn";
            this.prezimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // spolDataGridViewTextBoxColumn
            // 
            this.spolDataGridViewTextBoxColumn.DataPropertyName = "spol";
            this.spolDataGridViewTextBoxColumn.HeaderText = "Spol";
            this.spolDataGridViewTextBoxColumn.Name = "spolDataGridViewTextBoxColumn";
            this.spolDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "e-mail";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            this.telefonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // newsletterDataGridViewCheckBoxColumn
            // 
            this.newsletterDataGridViewCheckBoxColumn.DataPropertyName = "newsletter";
            this.newsletterDataGridViewCheckBoxColumn.HeaderText = "Newsletter";
            this.newsletterDataGridViewCheckBoxColumn.Name = "newsletterDataGridViewCheckBoxColumn";
            this.newsletterDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // brojdolazakaDataGridViewTextBoxColumn
            // 
            this.brojdolazakaDataGridViewTextBoxColumn.DataPropertyName = "broj_dolazaka";
            this.brojdolazakaDataGridViewTextBoxColumn.HeaderText = "broj_dolazaka";
            this.brojdolazakaDataGridViewTextBoxColumn.Name = "brojdolazakaDataGridViewTextBoxColumn";
            this.brojdolazakaDataGridViewTextBoxColumn.ReadOnly = true;
            this.brojdolazakaDataGridViewTextBoxColumn.Visible = false;
            // 
            // zadnjidolazakDataGridViewTextBoxColumn
            // 
            this.zadnjidolazakDataGridViewTextBoxColumn.DataPropertyName = "zadnji_dolazak";
            this.zadnjidolazakDataGridViewTextBoxColumn.HeaderText = "zadnji_dolazak";
            this.zadnjidolazakDataGridViewTextBoxColumn.Name = "zadnjidolazakDataGridViewTextBoxColumn";
            this.zadnjidolazakDataGridViewTextBoxColumn.ReadOnly = true;
            this.zadnjidolazakDataGridViewTextBoxColumn.Visible = false;
            // 
            // frmKlijenti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.ControlBox = false;
            this.Controls.Add(this.btnUredi);
            this.Controls.Add(this.btnObriši);
            this.Controls.Add(this.btnNatrag);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dgvKlijenti);
            this.Name = "frmKlijenti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Klijenti";
            this.Load += new System.EventHandler(this.frmKlijenti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKlijenti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klijentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKlijenti;
        private System.Windows.Forms.Button btnDodaj;
        private BazaDataSet bazaDataSet;
        private System.Windows.Forms.BindingSource klijentBindingSource;
        private BazaDataSetTableAdapters.KlijentTableAdapter klijentTableAdapter;
        private BazaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnNatrag;
        private System.Windows.Forms.Button btnObriši;
        private System.Windows.Forms.Button btnUredi;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDklijentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn spolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn newsletterDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojdolazakaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zadnjidolazakDataGridViewTextBoxColumn;
    }
}