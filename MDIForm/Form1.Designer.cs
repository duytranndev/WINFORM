namespace MDIForm
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
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openSubFormAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openSubFormBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openSubFormAToolStripMenuItem,
            this.openSubFormBToolStripMenuItem});
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
			this.openToolStripMenuItem.Text = "Open Form";
			// 
			// openSubFormAToolStripMenuItem
			// 
			this.openSubFormAToolStripMenuItem.Name = "openSubFormAToolStripMenuItem";
			this.openSubFormAToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.openSubFormAToolStripMenuItem.Text = "Open Sub Form A";
			this.openSubFormAToolStripMenuItem.Click += new System.EventHandler(this.openSubFormAToolStripMenuItem_Click);
			// 
			// openSubFormBToolStripMenuItem
			// 
			this.openSubFormBToolStripMenuItem.Name = "openSubFormBToolStripMenuItem";
			this.openSubFormBToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.openSubFormBToolStripMenuItem.Text = "Open Sub Form B";
			this.openSubFormBToolStripMenuItem.Click += new System.EventHandler(this.openSubFormBToolStripMenuItem_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.menuStrip1);
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Main Form";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openSubFormAToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openSubFormBToolStripMenuItem;
	}
}

