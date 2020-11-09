namespace WFBuoi3
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
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txt_time_begin = new System.Windows.Forms.TextBox();
			this.txt_time_access = new System.Windows.Forms.TextBox();
			this.txt_time_end = new System.Windows.Forms.TextBox();
			this.txt_money = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(122, 52);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(333, 36);
			this.label1.TabIndex = 0;
			this.label1.Text = "Tính tiền cước Internet";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(99, 135);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 19);
			this.label2.TabIndex = 1;
			this.label2.Text = "Giờ bắt đầu";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(354, 135);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(117, 19);
			this.label3.TabIndex = 2;
			this.label3.Text = "Thời gian truy cập";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(99, 213);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(83, 19);
			this.label4.TabIndex = 3;
			this.label4.Text = "Giờ kết thúc";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(354, 213);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(55, 19);
			this.label5.TabIndex = 4;
			this.label5.Text = "Giá tiền";
			// 
			// txt_time_begin
			// 
			this.txt_time_begin.Location = new System.Drawing.Point(103, 157);
			this.txt_time_begin.Multiline = true;
			this.txt_time_begin.Name = "txt_time_begin";
			this.txt_time_begin.Size = new System.Drawing.Size(156, 31);
			this.txt_time_begin.TabIndex = 5;
			this.txt_time_begin.Leave += new System.EventHandler(this.txt_time_begin_Leave);
			// 
			// txt_time_access
			// 
			this.txt_time_access.Location = new System.Drawing.Point(358, 157);
			this.txt_time_access.Multiline = true;
			this.txt_time_access.Name = "txt_time_access";
			this.txt_time_access.Size = new System.Drawing.Size(156, 31);
			this.txt_time_access.TabIndex = 6;
			// 
			// txt_time_end
			// 
			this.txt_time_end.Location = new System.Drawing.Point(103, 235);
			this.txt_time_end.Multiline = true;
			this.txt_time_end.Name = "txt_time_end";
			this.txt_time_end.Size = new System.Drawing.Size(156, 31);
			this.txt_time_end.TabIndex = 7;
			this.txt_time_end.Leave += new System.EventHandler(this.txt_time_end_Leave);
			// 
			// txt_money
			// 
			this.txt_money.Location = new System.Drawing.Point(358, 235);
			this.txt_money.Multiline = true;
			this.txt_money.Name = "txt_money";
			this.txt_money.Size = new System.Drawing.Size(156, 31);
			this.txt_money.TabIndex = 8;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(103, 296);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 33);
			this.button1.TabIndex = 9;
			this.button1.Text = "Run";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.btn_run_click);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(268, 296);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 33);
			this.button2.TabIndex = 10;
			this.button2.Text = "Reset";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.btn_reset_click);
			// 
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.Location = new System.Drawing.Point(439, 296);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 33);
			this.button3.TabIndex = 11;
			this.button3.Text = "Exit";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.btn_exit_click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(610, 368);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.txt_money);
			this.Controls.Add(this.txt_time_end);
			this.Controls.Add(this.txt_time_access);
			this.Controls.Add(this.txt_time_begin);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txt_time_begin;
		private System.Windows.Forms.TextBox txt_time_access;
		private System.Windows.Forms.TextBox txt_time_end;
		private System.Windows.Forms.TextBox txt_money;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
	}
}

