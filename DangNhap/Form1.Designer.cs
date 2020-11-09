namespace DangNhap
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
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txt_name = new System.Windows.Forms.TextBox();
			this.txt_pass = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(153, 51);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(257, 24);
			this.label1.TabIndex = 0;
			this.label1.Text = "THÔNG TIN ĐĂNG NHẬP";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(185, 108);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(37, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "USER";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(170, 158);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(70, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "PASSWORD";
			// 
			// txt_name
			// 
			this.txt_name.Location = new System.Drawing.Point(259, 105);
			this.txt_name.Name = "txt_name";
			this.txt_name.Size = new System.Drawing.Size(100, 20);
			this.txt_name.TabIndex = 3;
			this.txt_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_name_KeyPress);
			// 
			// txt_pass
			// 
			this.txt_pass.Location = new System.Drawing.Point(259, 155);
			this.txt_pass.Name = "txt_pass";
			this.txt_pass.Size = new System.Drawing.Size(100, 20);
			this.txt_pass.TabIndex = 4;
			this.txt_pass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_pass_KeyPress);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(197, 194);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(173, 23);
			this.button1.TabIndex = 5;
			this.button1.Text = "LOGGIN";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.btn_dangnhap);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(555, 256);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.txt_pass);
			this.Controls.Add(this.txt_name);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txt_name;
		private System.Windows.Forms.TextBox txt_pass;
		private System.Windows.Forms.Button button1;
	}
}

