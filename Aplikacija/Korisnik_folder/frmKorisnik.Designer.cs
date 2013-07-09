namespace Aplikacija
{
    partial class frmKorisnik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKorisnik));
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.miFile = new System.Windows.Forms.ToolStripMenuItem();
            this.miFileOdjava = new System.Windows.Forms.ToolStripMenuItem();
            this.miObavijesti = new System.Windows.Forms.ToolStripMenuItem();
            this.miCjenik = new System.Windows.Forms.ToolStripMenuItem();
            this.miKlijenti = new System.Windows.Forms.ToolStripMenuItem();
            this.miRacun = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kreiranjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMain
            // 
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miFile,
            this.miObavijesti,
            this.miCjenik,
            this.miKlijenti,
            this.miRacun});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(784, 24);
            this.msMain.TabIndex = 1;
            this.msMain.Text = "menuStrip1";
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
            // miObavijesti
            // 
            this.miObavijesti.Name = "miObavijesti";
            this.miObavijesti.Size = new System.Drawing.Size(71, 20);
            this.miObavijesti.Text = "Obavijesti";
            this.miObavijesti.Click += new System.EventHandler(this.miObavijesti_Click);
            // 
            // miCjenik
            // 
            this.miCjenik.Name = "miCjenik";
            this.miCjenik.Size = new System.Drawing.Size(52, 20);
            this.miCjenik.Text = "Cjenik";
            this.miCjenik.Click += new System.EventHandler(this.miCjenik_Click);
            // 
            // miKlijenti
            // 
            this.miKlijenti.Name = "miKlijenti";
            this.miKlijenti.Size = new System.Drawing.Size(55, 20);
            this.miKlijenti.Text = "Klijenti";
            this.miKlijenti.Click += new System.EventHandler(this.miKlijenti_Click);
            // 
            // miRacun
            // 
            this.miRacun.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledToolStripMenuItem,
            this.kreiranjeToolStripMenuItem});
            this.miRacun.Name = "miRacun";
            this.miRacun.Size = new System.Drawing.Size(55, 20);
            this.miRacun.Text = "Računi";
            // 
            // pregledToolStripMenuItem
            // 
            this.pregledToolStripMenuItem.Name = "pregledToolStripMenuItem";
            this.pregledToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pregledToolStripMenuItem.Text = "Pregled";
            this.pregledToolStripMenuItem.Click += new System.EventHandler(this.pregledToolStripMenuItem_Click);
            // 
            // kreiranjeToolStripMenuItem
            // 
            this.kreiranjeToolStripMenuItem.Name = "kreiranjeToolStripMenuItem";
            this.kreiranjeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.kreiranjeToolStripMenuItem.Text = "Kreiranje";
            this.kreiranjeToolStripMenuItem.Click += new System.EventHandler(this.kreiranjeToolStripMenuItem_Click);
            // 
            // frmKorisnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.msMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msMain;
            this.Name = "frmKorisnik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Korisnik";
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem miFile;
        private System.Windows.Forms.ToolStripMenuItem miFileOdjava;
        private System.Windows.Forms.ToolStripMenuItem miObavijesti;
        private System.Windows.Forms.ToolStripMenuItem miCjenik;
        private System.Windows.Forms.ToolStripMenuItem miKlijenti;
        private System.Windows.Forms.ToolStripMenuItem miRacun;
        private System.Windows.Forms.ToolStripMenuItem pregledToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kreiranjeToolStripMenuItem;
    }
}