namespace QUAN_LY_HANG
{
    partial class Form1
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
            this.fIleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nHÀCUNGCẤPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mẶTHÀNGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fIleToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fIleToolStripMenuItem
            // 
            this.fIleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nHÀCUNGCẤPToolStripMenuItem,
            this.mẶTHÀNGToolStripMenuItem,
            this.eXITToolStripMenuItem});
            this.fIleToolStripMenuItem.Name = "fIleToolStripMenuItem";
            this.fIleToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fIleToolStripMenuItem.Text = "File";
            // 
            // nHÀCUNGCẤPToolStripMenuItem
            // 
            this.nHÀCUNGCẤPToolStripMenuItem.Name = "nHÀCUNGCẤPToolStripMenuItem";
            this.nHÀCUNGCẤPToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nHÀCUNGCẤPToolStripMenuItem.Text = "NHÀ CUNG CẤP";
            this.nHÀCUNGCẤPToolStripMenuItem.Click += new System.EventHandler(this.nHÀCUNGCẤPToolStripMenuItem_Click);
            // 
            // mẶTHÀNGToolStripMenuItem
            // 
            this.mẶTHÀNGToolStripMenuItem.Name = "mẶTHÀNGToolStripMenuItem";
            this.mẶTHÀNGToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mẶTHÀNGToolStripMenuItem.Text = "MẶT HÀNG";
            this.mẶTHÀNGToolStripMenuItem.Click += new System.EventHandler(this.mẶTHÀNGToolStripMenuItem_Click);
            // 
            // eXITToolStripMenuItem
            // 
            this.eXITToolStripMenuItem.Name = "eXITToolStripMenuItem";
            this.eXITToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eXITToolStripMenuItem.Text = "EXIT";
            this.eXITToolStripMenuItem.Click += new System.EventHandler(this.eXITToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fIleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nHÀCUNGCẤPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mẶTHÀNGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXITToolStripMenuItem;
    }
}

