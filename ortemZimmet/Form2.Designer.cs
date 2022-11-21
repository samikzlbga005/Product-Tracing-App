namespace ortemZimmet
{
    partial class Form2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kişiEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zimmetleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personellerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kişiEkleToolStripMenuItem,
            this.zimmetleToolStripMenuItem,
            this.stokToolStripMenuItem,
            this.personellerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(956, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "Kişi Ekle";
            // 
            // kişiEkleToolStripMenuItem
            // 
            this.kişiEkleToolStripMenuItem.Name = "kişiEkleToolStripMenuItem";
            this.kişiEkleToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.kişiEkleToolStripMenuItem.Text = "Kişi Ekle";
            this.kişiEkleToolStripMenuItem.Click += new System.EventHandler(this.kişiEkleToolStripMenuItem_Click);
            // 
            // zimmetleToolStripMenuItem
            // 
            this.zimmetleToolStripMenuItem.Name = "zimmetleToolStripMenuItem";
            this.zimmetleToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.zimmetleToolStripMenuItem.Text = "Zimmetle";
            // 
            // stokToolStripMenuItem
            // 
            this.stokToolStripMenuItem.Name = "stokToolStripMenuItem";
            this.stokToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.stokToolStripMenuItem.Text = "Stok";
            // 
            // personellerToolStripMenuItem
            // 
            this.personellerToolStripMenuItem.Name = "personellerToolStripMenuItem";
            this.personellerToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.personellerToolStripMenuItem.Text = "Personeller";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(804, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(724, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Admin: ";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 555);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Anasayfa";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kişiEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zimmetleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stokToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personellerToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}