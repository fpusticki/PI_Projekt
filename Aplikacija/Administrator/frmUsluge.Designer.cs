namespace Aplikacija.Administrator
{
    partial class frmUsluge
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
            this.dgvUsluge = new System.Windows.Forms.DataGridView();
            this.iDuslugeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDmjernejediniceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.mjernajedinicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bazaDataSet = new Aplikacija.BazaDataSet();
            this.cijenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uslugaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uslugaTableAdapter = new Aplikacija.BazaDataSetTableAdapters.UslugaTableAdapter();
            this.tableAdapterManager = new Aplikacija.BazaDataSetTableAdapters.TableAdapterManager();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.uslugaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mjerna_jedinicaTableAdapter = new Aplikacija.BazaDataSetTableAdapters.Mjerna_jedinicaTableAdapter();
            this.btnNatrag = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsluge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mjernajedinicaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uslugaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uslugaBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsluge
            // 
            this.dgvUsluge.AllowUserToAddRows = false;
            this.dgvUsluge.AllowUserToDeleteRows = false;
            this.dgvUsluge.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUsluge.AutoGenerateColumns = false;
            this.dgvUsluge.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsluge.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDuslugeDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.opisDataGridViewTextBoxColumn,
            this.iDmjernejediniceDataGridViewTextBoxColumn,
            this.cijenaDataGridViewTextBoxColumn});
            this.dgvUsluge.DataSource = this.uslugaBindingSource;
            this.dgvUsluge.Location = new System.Drawing.Point(13, 42);
            this.dgvUsluge.Name = "dgvUsluge";
            this.dgvUsluge.ReadOnly = true;
            this.dgvUsluge.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsluge.Size = new System.Drawing.Size(759, 452);
            this.dgvUsluge.TabIndex = 0;
            this.dgvUsluge.SelectionChanged += new System.EventHandler(this.dgvUsluge_SelectionChanged);
            // 
            // iDuslugeDataGridViewTextBoxColumn
            // 
            this.iDuslugeDataGridViewTextBoxColumn.DataPropertyName = "ID_usluge";
            this.iDuslugeDataGridViewTextBoxColumn.HeaderText = "ID usluge";
            this.iDuslugeDataGridViewTextBoxColumn.Name = "iDuslugeDataGridViewTextBoxColumn";
            this.iDuslugeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // opisDataGridViewTextBoxColumn
            // 
            this.opisDataGridViewTextBoxColumn.DataPropertyName = "opis";
            this.opisDataGridViewTextBoxColumn.HeaderText = "Opis";
            this.opisDataGridViewTextBoxColumn.Name = "opisDataGridViewTextBoxColumn";
            this.opisDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDmjernejediniceDataGridViewTextBoxColumn
            // 
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
            // cijenaDataGridViewTextBoxColumn
            // 
            this.cijenaDataGridViewTextBoxColumn.DataPropertyName = "cijena";
            this.cijenaDataGridViewTextBoxColumn.HeaderText = "Cijena";
            this.cijenaDataGridViewTextBoxColumn.Name = "cijenaDataGridViewTextBoxColumn";
            this.cijenaDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.tableAdapterManager.Mjerna_jedinicaTableAdapter = null;
            this.tableAdapterManager.RacunTableAdapter = null;
            this.tableAdapterManager.Stavka_cjenikaTableAdapter = null;
            this.tableAdapterManager.Stavka_racunaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Aplikacija.BazaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UslugaTableAdapter = this.uslugaTableAdapter;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(345, 500);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 1;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // uslugaBindingSource1
            // 
            this.uslugaBindingSource1.DataMember = "Usluga";
            this.uslugaBindingSource1.DataSource = this.bazaDataSet;
            // 
            // mjerna_jedinicaTableAdapter
            // 
            this.mjerna_jedinicaTableAdapter.ClearBeforeFill = true;
            // 
            // btnNatrag
            // 
            this.btnNatrag.Location = new System.Drawing.Point(13, 13);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(30, 23);
            this.btnNatrag.TabIndex = 4;
            this.btnNatrag.Text = "<-----";
            this.btnNatrag.UseVisualStyleBackColor = true;
            this.btnNatrag.Click += new System.EventHandler(this.btnNatrag_Click);
            // 
            // frmUsluge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.ControlBox = false;
            this.Controls.Add(this.btnNatrag);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dgvUsluge);
            this.Name = "frmUsluge";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Usluge";
            this.Load += new System.EventHandler(this.frmUsluge_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsluge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mjernajedinicaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uslugaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uslugaBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsluge;
        private BazaDataSet bazaDataSet;
        private System.Windows.Forms.BindingSource uslugaBindingSource;
        private BazaDataSetTableAdapters.UslugaTableAdapter uslugaTableAdapter;
        private BazaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.BindingSource mjernajedinicaBindingSource;
        private System.Windows.Forms.BindingSource uslugaBindingSource1;
        private BazaDataSetTableAdapters.Mjerna_jedinicaTableAdapter mjerna_jedinicaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDuslugeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn iDmjernejediniceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnNatrag;
    }
}