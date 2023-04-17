namespace Pemrograman_1214078.view
{
    partial class FormKatalog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKatalog));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maticToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gigiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.koplingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mASTERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kembaliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.mASTERToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.kembaliToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1579, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maticToolStripMenuItem,
            this.gigiToolStripMenuItem,
            this.koplingToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.fileToolStripMenuItem.Text = "Kategori";
            // 
            // maticToolStripMenuItem
            // 
            this.maticToolStripMenuItem.Name = "maticToolStripMenuItem";
            this.maticToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.maticToolStripMenuItem.Text = "Matic";
            this.maticToolStripMenuItem.Click += new System.EventHandler(this.maticToolStripMenuItem_Click);
            // 
            // gigiToolStripMenuItem
            // 
            this.gigiToolStripMenuItem.Name = "gigiToolStripMenuItem";
            this.gigiToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.gigiToolStripMenuItem.Text = "Gigi";
            this.gigiToolStripMenuItem.Click += new System.EventHandler(this.gigiToolStripMenuItem_Click);
            // 
            // koplingToolStripMenuItem
            // 
            this.koplingToolStripMenuItem.Name = "koplingToolStripMenuItem";
            this.koplingToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.koplingToolStripMenuItem.Text = "Kopling";
            this.koplingToolStripMenuItem.Click += new System.EventHandler(this.koplingToolStripMenuItem_Click);
            // 
            // mASTERToolStripMenuItem
            // 
            this.mASTERToolStripMenuItem.Name = "mASTERToolStripMenuItem";
            this.mASTERToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.mASTERToolStripMenuItem.Text = "Best Seller";
            this.mASTERToolStripMenuItem.Click += new System.EventHandler(this.mASTERToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.helpToolStripMenuItem.Text = "Promo";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // kembaliToolStripMenuItem
            // 
            this.kembaliToolStripMenuItem.Name = "kembaliToolStripMenuItem";
            this.kembaliToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.kembaliToolStripMenuItem.Text = "&Kembali";
            this.kembaliToolStripMenuItem.Click += new System.EventHandler(this.kembaliToolStripMenuItem_Click);
            // 
            // FormKatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pemrograman_1214078.Properties.Resources.MOTOR_PARENT_FORM_BG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1579, 875);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "FormKatalog";
            this.Text = "FormKatalog";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormKatalog_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maticToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gigiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem koplingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mASTERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kembaliToolStripMenuItem;
    }
}