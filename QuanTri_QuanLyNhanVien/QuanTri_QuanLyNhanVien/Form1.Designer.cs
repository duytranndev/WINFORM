namespace QuanTri_QuanLyNhanVien
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
			this.txt_user = new System.Windows.Forms.TextBox();
			this.txt_pass = new System.Windows.Forms.TextBox();
			this.btb_login = new System.Windows.Forms.Button();
			this.btn_cancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(168, 97);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(27, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "user";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(168, 141);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(29, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "pass";
			// 
			// txt_user
			// 
			this.txt_user.Location = new System.Drawing.Point(259, 97);
			this.txt_user.Name = "txt_user";
			this.txt_user.Size = new System.Drawing.Size(100, 20);
			this.txt_user.TabIndex = 2;
			// 
			// txt_pass
			// 
			this.txt_pass.Location = new System.Drawing.Point(259, 141);
			this.txt_pass.Name = "txt_pass";
			this.txt_pass.Size = new System.Drawing.Size(100, 20);
			this.txt_pass.TabIndex = 3;
			// 
			// btb_login
			// 
			this.btb_login.Location = new System.Drawing.Point(217, 194);
			this.btb_login.Name = "btb_login";
			this.btb_login.Size = new System.Drawing.Size(75, 23);
			this.btb_login.TabIndex = 4;
			this.btb_login.Text = "login";
			this.btb_login.UseVisualStyleBackColor = true;
			this.btb_login.Click += new System.EventHandler(this.btb_login_Click);
			// 
			// btn_cancel
			// 
			this.btn_cancel.Location = new System.Drawing.Point(317, 194);
			this.btn_cancel.Name = "btn_cancel";
			this.btn_cancel.Size = new System.Drawing.Size(75, 23);
			this.btn_cancel.TabIndex = 5;
			this.btn_cancel.Text = "cancel";
			this.btn_cancel.UseVisualStyleBackColor = true;
			this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btn_cancel);
			this.Controls.Add(this.btb_login);
			this.Controls.Add(this.txt_pass);
			this.Controls.Add(this.txt_user);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "QUẢN LÝ NHÂN VIÊN";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txt_user;
		private System.Windows.Forms.TextBox txt_pass;
		private System.Windows.Forms.Button btb_login;
		private System.Windows.Forms.Button btn_cancel;
	}
}

