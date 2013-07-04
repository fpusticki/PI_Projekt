namespace Aplikacija
{
    partial class frmAdministrator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdministrator));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.miFile = new System.Windows.Forms.ToolStripMenuItem();
            this.miFileOdjava = new System.Windows.Forms.ToolStripMenuItem();
            this.miUsluge = new System.Windows.Forms.ToolStripMenuItem();
            this.miCjenici = new System.Windows.Forms.ToolStripMenuItem();
            this.miKorisnici = new System.Windows.Forms.ToolStripMenuItem();
            this.miCRM = new System.Windows.Forms.ToolStripMenuItem();
            this.miPostavke = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miFile,
            this.miUsluge,
            this.miCjenici,
            this.miKorisnici,
            this.miCRM,
            this.miPostavke});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // miFile
            // 
            this.miFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miFileOdjava});
            this.miFile.Name = "miFile";
            this.miFile.Size = new System.Drawing.Size(37, 20);
            this.miFile.Text = "File";
            // 
            // miFileOdjava
            // 
            this.miFileOdjava.Name = "miFileOdjava";
            this.miFileOdjava.Size = new System.Drawing.Size(111, 22);
            this.miFileOdjava.Text = "Odjava";
            this.miFileOdjava.Click += new System.EventHandler(this.miFileOdjava_Click);
            // 
            // miUsluge
            // 
            this.miUsluge.Name = "miUsluge";
            this.miUsluge.Size = new System.Drawing.Size(55, 20);
            this.miUsluge.Text = "Usluge";
            this.miUsluge.Click += new System.EventHandler(this.miUsluge_Click);
            // 
            // miCjenici
            // 
            this.miCjenici.Name = "miCjenici";
            this.miCjenici.Size = new System.Drawing.Size(55, 20);
            this.miCjenici.Text = "Cjenici";
            this.miCjenici.Click += new System.EventHandler(this.miCjenici_Click);
            // 
            // miKorisnici
            // 
            this.miKorisnici.Name = "miKorisnici";
            this.miKorisnici.Size = new System.Drawing.Size(64, 20);
            this.miKorisnici.Text = "Korisnici";
            this.miKorisnici.Click += new System.EventHandler(this.miKorisnici_Click);
            // 
            // miCRM
            // 
            this.miCRM.Name = "miCRM";
            this.miCRM.Size = new System.Drawing.Size(45, 20);
            this.miCRM.Text = "CRM";
            this.miCRM.Click += new System.EventHandler(this.miCRM_Click);
            // 
            // miPostavke
            // 
            this.miPostavke.Name = "miPostavke";
            this.miPostavke.Size = new System.Drawing.Size(66, 20);
            this.miPostavke.Text = "Postavke";
            this.miPostavke.Click += new System.EventHandler(this.miPostavke_Click);
            // 
            // frmAdministrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmAdministrator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrator";
            this.Load += new System.EventHandler(this.frmAdministrator_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem miFile;
        private System.Windows.Forms.ToolStripMenuItem miFileOdjava;
        private System.Windows.Forms.ToolStripMenuItem miUsluge;
        private System.Windows.Forms.ToolStripMenuItem miCjenici;
        private System.Windows.Forms.ToolStripMenuItem miKorisnici;
        private System.Windows.Forms.ToolStripMenuItem miCRM;
        private System.Windows.Forms.ToolStripMenuItem miPostavke;
    }
}

