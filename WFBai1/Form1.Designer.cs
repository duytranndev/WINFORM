namespace WFBai1
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
			System.Windows.Forms.Label label2;
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txt_so1 = new System.Windows.Forms.TextBox();
			this.txt_so2 = new System.Windows.Forms.TextBox();
			this.txt_ketqua = new System.Windows.Forms.TextBox();
			this.btn_nhan = new System.Windows.Forms.Button();
			this.btn_tru = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new System.Drawing.Point(144, 197);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(47, 13);
			label2.TabIndex = 2;
			label2.Text = "Số thứ 1";
			label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(218, 101);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(352, 42);
			this.label1.TabIndex = 1;
			this.label1.Text = "PHÉP TÍNH CƠ BẢN";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(144, 256);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(47, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "Số thứ 2";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(396, 256);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(44, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Kết quả";
			// 
			// txt_so1
			// 
			this.txt_so1.Location = new System.Drawing.Point(225, 197);
			this.txt_so1.Name = "txt_so1";
			this.txt_so1.Size = new System.Drawing.Size(136, 20);
			this.txt_so1.TabIndex = 4;
			// 
			// txt_so2
			// 
			this.txt_so2.Location = new System.Drawing.Point(225, 256);
			this.txt_so2.Name = "txt_so2";
			this.txt_so2.Size = new System.Drawing.Size(136, 20);
			this.txt_so2.TabIndex = 5;
			// 
			// txt_ketqua
			// 
			this.txt_ketqua.Location = new System.Drawing.Point(460, 253);
			this.txt_ketqua.Name = "txt_ketqua";
			this.txt_ketqua.Size = new System.Drawing.Size(151, 20);
			this.txt_ketqua.TabIndex = 6;
			// 
			// btn_nhan
			// 
			this.btn_nhan.Location = new System.Drawing.Point(399, 343);
			this.btn_nhan.Name = "btn_nhan";
			this.btn_nhan.Size = new System.Drawing.Size(75, 23);
			this.btn_nhan.TabIndex = 8;
			this.btn_nhan.Text = "Nhân";
			this.btn_nhan.UseVisualStyleBackColor = true;
			this.btn_nhan.Click += new System.EventHandler(this.btn_nhan_Click);
			// 
			// btn_tru
			// 
			this.btn_tru.Location = new System.Drawing.Point(285, 343);
			this.btn_tru.Name = "btn_tru";
			this.btn_tru.Size = new System.Drawing.Size(75, 23);
			this.btn_tru.TabIndex = 9;
			this.btn_tru.Text = "Trừ";
			this.btn_tru.UseVisualStyleBackColor = true;
			this.btn_tru.Click += new System.EventHandler(this.btn_tru_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(168, 343);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 10;
			this.button1.Text = "Cong";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.btn_cong);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(541, 343);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 11;
			this.button2.Text = "Chia";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.btn_chia);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.btn_tru);
			this.Controls.Add(this.btn_nhan);
			this.Controls.Add(this.txt_ketqua);
			this.Controls.Add(this.txt_so2);
			this.Controls.Add(this.txt_so1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Cộng";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txt_so1;
		private System.Windows.Forms.TextBox txt_so2;
		private System.Windows.Forms.TextBox txt_ketqua;
		private System.Windows.Forms.Button btn_nhan;
		private System.Windows.Forms.Button btn_tru;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
	}
}

