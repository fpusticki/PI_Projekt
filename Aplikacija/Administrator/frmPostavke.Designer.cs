namespace Aplikacija.Administrator
{
    partial class frmPostavke
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
            this.lblNazivPoduzeca = new System.Windows.Forms.Label();
            this.lblAdresa = new System.Windows.Forms.Label();
            this.lblOIB = new System.Windows.Forms.Label();
            this.lblBrojRacuna = new System.Windows.Forms.Label();
            this.lblBrojTelefona = new System.Windows.Forms.Label();
            this.lblPDV = new System.Windows.Forms.Label();
            this.txtNazivPoduzeca = new System.Windows.Forms.TextBox();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.txtOIB = new System.Windows.Forms.TextBox();
            this.txtBrRcn = new System.Windows.Forms.TextBox();
            this.txtBrTelefona = new System.Windows.Forms.TextBox();
            this.txtPDV = new System.Windows.Forms.TextBox();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnNatrag = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNazivPoduzeca
            // 
            this.lblNazivPoduzeca.AutoSize = true;
            this.lblNazivPoduzeca.Location = new System.Drawing.Point(160, 50);
            this.lblNazivPoduzeca.Name = "lblNazivPoduzeca";
            this.lblNazivPoduzeca.Size = new System.Drawing.Size(84, 13);
            this.lblNazivPoduzeca.TabIndex = 0;
            this.lblNazivPoduzeca.Text = "Naziv poduzeća";
            // 
            // lblAdresa
            // 
            this.lblAdresa.AutoSize = true;
            this.lblAdresa.Location = new System.Drawing.Point(160, 100);
            this.lblAdresa.Name = "lblAdresa";
            this.lblAdresa.Size = new System.Drawing.Size(40, 13);
            this.lblAdresa.TabIndex = 1;
            this.lblAdresa.Text = "Adresa";
            // 
            // lblOIB
            // 
            this.lblOIB.AutoSize = true;
            this.lblOIB.Location = new System.Drawing.Point(160, 150);
            this.lblOIB.Name = "lblOIB";
            this.lblOIB.Size = new System.Drawing.Size(25, 13);
            this.lblOIB.TabIndex = 2;
            this.lblOIB.Text = "OIB";
            // 
            // lblBrojRacuna
            // 
            this.lblBrojRacuna.AutoSize = true;
            this.lblBrojRacuna.Location = new System.Drawing.Point(160, 200);
            this.lblBrojRacuna.Name = "lblBrojRacuna";
            this.lblBrojRacuna.Size = new System.Drawing.Size(80, 13);
            this.lblBrojRacuna.TabIndex = 3;
            this.lblBrojRacuna.Text = "Broj žiro računa";
            // 
            // lblBrojTelefona
            // 
            this.lblBrojTelefona.AutoSize = true;
            this.lblBrojTelefona.Location = new System.Drawing.Point(160, 250);
            this.lblBrojTelefona.Name = "lblBrojTelefona";
            this.lblBrojTelefona.Size = new System.Drawing.Size(66, 13);
            this.lblBrojTelefona.TabIndex = 4;
            this.lblBrojTelefona.Text = "Broj telefona";
            // 
            // lblPDV
            // 
            this.lblPDV.AutoSize = true;
            this.lblPDV.Location = new System.Drawing.Point(160, 300);
            this.lblPDV.Name = "lblPDV";
            this.lblPDV.Size = new System.Drawing.Size(29, 13);
            this.lblPDV.TabIndex = 5;
            this.lblPDV.Text = "PDV";
            // 
            // txtNazivPoduzeca
            // 
            this.txtNazivPoduzeca.Location = new System.Drawing.Point(273, 50);
            this.txtNazivPoduzeca.Name = "txtNazivPoduzeca";
            this.txtNazivPoduzeca.Size = new System.Drawing.Size(300, 20);
            this.txtNazivPoduzeca.TabIndex = 6;
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(273, 100);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(300, 20);
            this.txtAdresa.TabIndex = 7;
            // 
            // txtOIB
            // 
            this.txtOIB.Location = new System.Drawing.Point(273, 150);
            this.txtOIB.Name = "txtOIB";
            this.txtOIB.Size = new System.Drawing.Size(300, 20);
            this.txtOIB.TabIndex = 8;
            // 
            // txtBrRcn
            // 
            this.txtBrRcn.Location = new System.Drawing.Point(273, 200);
            this.txtBrRcn.Name = "txtBrRcn";
            this.txtBrRcn.Size = new System.Drawing.Size(300, 20);
            this.txtBrRcn.TabIndex = 9;
            // 
            // txtBrTelefona
            // 
            this.txtBrTelefona.Location = new System.Drawing.Point(273, 250);
            this.txtBrTelefona.Name = "txtBrTelefona";
            this.txtBrTelefona.Size = new System.Drawing.Size(300, 20);
            this.txtBrTelefona.TabIndex = 10;
            // 
            // txtPDV
            // 
            this.txtPDV.Location = new System.Drawing.Point(273, 300);
            this.txtPDV.Name = "txtPDV";
            this.txtPDV.Size = new System.Drawing.Size(100, 20);
            this.txtPDV.TabIndex = 11;
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(273, 375);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(75, 23);
            this.btnSpremi.TabIndex = 12;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // btnNatrag
            // 
            this.btnNatrag.Location = new System.Drawing.Point(12, 12);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(30, 23);
            this.btnNatrag.TabIndex = 13;
            this.btnNatrag.Text = "<-----";
            this.btnNatrag.UseVisualStyleBackColor = true;
            this.btnNatrag.Click += new System.EventHandler(this.btnNatrag_Click);
            // 
            // frmPostavke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.ControlBox = false;
            this.Controls.Add(this.btnNatrag);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.txtPDV);
            this.Controls.Add(this.txtBrTelefona);
            this.Controls.Add(this.txtBrRcn);
            this.Controls.Add(this.txtOIB);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.txtNazivPoduzeca);
            this.Controls.Add(this.lblPDV);
            this.Controls.Add(this.lblBrojTelefona);
            this.Controls.Add(this.lblBrojRacuna);
            this.Controls.Add(this.lblOIB);
            this.Controls.Add(this.lblAdresa);
            this.Controls.Add(this.lblNazivPoduzeca);
            this.Name = "frmPostavke";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Postavke";
            this.Load += new System.EventHandler(this.frmPostavke_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNazivPoduzeca;
        private System.Windows.Forms.Label lblAdresa;
        private System.Windows.Forms.Label lblOIB;
        private System.Windows.Forms.Label lblBrojRacuna;
        private System.Windows.Forms.Label lblBrojTelefona;
        private System.Windows.Forms.Label lblPDV;
        private System.Windows.Forms.TextBox txtNazivPoduzeca;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.TextBox txtOIB;
        private System.Windows.Forms.TextBox txtBrRcn;
        private System.Windows.Forms.TextBox txtBrTelefona;
        private System.Windows.Forms.TextBox txtPDV;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnNatrag;
    }
}