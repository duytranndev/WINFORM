namespace WFbai2
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
			this.label1 = new System.Windows.Forms.Label();
			this.txtBox_a = new System.Windows.Forms.TextBox();
			this.txtBox_b = new System.Windows.Forms.TextBox();
			this.comboBox_signal = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtBox_c = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(179, 55);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(448, 40);
			this.label1.TabIndex = 0;
			this.label1.Text = "TỔNG TÍCH HIỆU THƯƠNG";
			// 
			// txtBox_a
			// 
			this.txtBox_a.Location = new System.Drawing.Point(136, 251);
			this.txtBox_a.Name = "txtBox_a";
			this.txtBox_a.Size = new System.Drawing.Size(100, 20);
			this.txtBox_a.TabIndex = 1;
			this.txtBox_a.Leave += new System.EventHandler(this.txtBox_a_Leave);
			// 
			// txtBox_b
			// 
			this.txtBox_b.Location = new System.Drawing.Point(418, 251);
			this.txtBox_b.Name = "txtBox_b";
			this.txtBox_b.Size = new System.Drawing.Size(100, 20);
			this.txtBox_b.TabIndex = 1;
			this.txtBox_b.Leave += new System.EventHandler(this.txtBox_b_Leave);
			// 
			// comboBox_signal
			// 
			this.comboBox_signal.FormattingEnabled = true;
			this.comboBox_signal.Items.AddRange(new object[] {
            "cộng",
            "trừ",
            "nhân",
            "chia"});
			this.comboBox_signal.Location = new System.Drawing.Point(272, 250);
			this.comboBox_signal.Name = "comboBox_signal";
			this.comboBox_signal.Size = new System.Drawing.Size(121, 21);
			this.comboBox_signal.TabIndex = 2;
			this.comboBox_signal.SelectedIndexChanged += new System.EventHandler(this.comboBox_signal_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(547, 254);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(13, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "=";
			// 
			// txtBox_c
			// 
			this.txtBox_c.Location = new System.Drawing.Point(603, 251);
			this.txtBox_c.Name = "txtBox_c";
			this.txtBox_c.Size = new System.Drawing.Size(100, 20);
			this.txtBox_c.TabIndex = 1;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLight;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.comboBox_signal);
			this.Controls.Add(this.txtBox_b);
			this.Controls.Add(this.txtBox_c);
			this.Controls.Add(this.txtBox_a);
			this.Controls.Add(this.label1);
			this.Cursor = System.Windows.Forms.Cursors.Default;
			this.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtBox_a;
		private System.Windows.Forms.TextBox txtBox_b;
		private System.Windows.Forms.ComboBox comboBox_signal;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtBox_c;
	}
}

