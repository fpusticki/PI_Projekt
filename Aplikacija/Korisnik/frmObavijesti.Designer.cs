namespace Aplikacija.Korisnik
{
    partial class frmObavijesti
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
            this.lstObavijesti = new System.Windows.Forms.ListBox();
            this.btnIsprazniListu = new System.Windows.Forms.Button();
            this.btnNatrag = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstObavijesti
            // 
            this.lstObavijesti.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstObavijesti.FormattingEnabled = true;
            this.lstObavijesti.Location = new System.Drawing.Point(13, 39);
            this.lstObavijesti.Name = "lstObavijesti";
            this.lstObavijesti.Size = new System.Drawing.Size(759, 420);
            this.lstObavijesti.TabIndex = 0;
            // 
            // btnIsprazniListu
            // 
            this.btnIsprazniListu.AutoSize = true;
            this.btnIsprazniListu.Location = new System.Drawing.Point(350, 475);
            this.btnIsprazniListu.Name = "btnIsprazniListu";
            this.btnIsprazniListu.Size = new System.Drawing.Size(78, 23);
            this.btnIsprazniListu.TabIndex = 1;
            this.btnIsprazniListu.Text = "Isprazni Listu";
            this.btnIsprazniListu.UseVisualStyleBackColor = true;
            this.btnIsprazniListu.Click += new System.EventHandler(this.btnIsprazniListu_Click);
            // 
            // btnNatrag
            // 
            this.btnNatrag.Location = new System.Drawing.Point(12, 12);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(30, 23);
            this.btnNatrag.TabIndex = 6;
            this.btnNatrag.Text = "<-----";
            this.btnNatrag.UseVisualStyleBackColor = true;
            this.btnNatrag.Click += new System.EventHandler(this.btnNatrag_Click);
            // 
            // frmObavijesti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.ControlBox = false;
            this.Controls.Add(this.btnNatrag);
            this.Controls.Add(this.btnIsprazniListu);
            this.Controls.Add(this.lstObavijesti);
            this.Name = "frmObavijesti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Obavijesti";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstObavijesti;
        private System.Windows.Forms.Button btnIsprazniListu;
        private System.Windows.Forms.Button btnNatrag;

    }
}