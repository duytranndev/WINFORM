namespace Form_QuanLySinhVien
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
			this.txt_masv = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txt_tensv = new System.Windows.Forms.TextBox();
			this.txt_gioitinh = new System.Windows.Forms.TextBox();
			this.txt_diem = new System.Windows.Forms.TextBox();
			this.txt_diachi = new System.Windows.Forms.TextBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.masinhvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tensinhvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.diem = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btn_them = new System.Windows.Forms.Button();
			this.btn_xoa = new System.Windows.Forms.Button();
			this.btn_sua = new System.Windows.Forms.Button();
			this.btn_thoat = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 81);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Ma sinh vien";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 122);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(71, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Ten sinh vien";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(249, 81);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(45, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Gioi tinh";
			// 
			// txt_masv
			// 
			this.txt_masv.Location = new System.Drawing.Point(89, 81);
			this.txt_masv.Name = "txt_masv";
			this.txt_masv.Size = new System.Drawing.Size(104, 20);
			this.txt_masv.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(209, 12);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(190, 26);
			this.label4.TabIndex = 4;
			this.label4.Text = "Quan ly sinh vien";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(426, 81);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(31, 13);
			this.label5.TabIndex = 5;
			this.label5.Text = "Diem";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(249, 129);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(40, 13);
			this.label6.TabIndex = 6;
			this.label6.Text = "Dia chi";
			// 
			// txt_tensv
			// 
			this.txt_tensv.Location = new System.Drawing.Point(89, 122);
			this.txt_tensv.Name = "txt_tensv";
			this.txt_tensv.Size = new System.Drawing.Size(104, 20);
			this.txt_tensv.TabIndex = 7;
			// 
			// txt_gioitinh
			// 
			this.txt_gioitinh.Location = new System.Drawing.Point(300, 78);
			this.txt_gioitinh.Name = "txt_gioitinh";
			this.txt_gioitinh.Size = new System.Drawing.Size(104, 20);
			this.txt_gioitinh.TabIndex = 8;
			// 
			// txt_diem
			// 
			this.txt_diem.Location = new System.Drawing.Point(463, 81);
			this.txt_diem.Name = "txt_diem";
			this.txt_diem.Size = new System.Drawing.Size(104, 20);
			this.txt_diem.TabIndex = 9;
			// 
			// txt_diachi
			// 
			this.txt_diachi.Location = new System.Drawing.Point(300, 122);
			this.txt_diachi.Name = "txt_diachi";
			this.txt_diachi.Size = new System.Drawing.Size(104, 20);
			this.txt_diachi.TabIndex = 10;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masinhvien,
            this.tensinhvien,
            this.diachi,
            this.gioitinh,
            this.diem});
			this.dataGridView1.Location = new System.Drawing.Point(15, 161);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(552, 218);
			this.dataGridView1.TabIndex = 11;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// masinhvien
			// 
			this.masinhvien.DataPropertyName = "masinhvien";
			this.masinhvien.HeaderText = "Mã sinh viên";
			this.masinhvien.Name = "masinhvien";
			this.masinhvien.ReadOnly = true;
			// 
			// tensinhvien
			// 
			this.tensinhvien.DataPropertyName = "tensinhvien";
			this.tensinhvien.HeaderText = "Tên Sinh Viên";
			this.tensinhvien.Name = "tensinhvien";
			this.tensinhvien.ReadOnly = true;
			// 
			// diachi
			// 
			this.diachi.DataPropertyName = "diachi";
			this.diachi.HeaderText = "Địa chỉ";
			this.diachi.Name = "diachi";
			this.diachi.ReadOnly = true;
			// 
			// gioitinh
			// 
			this.gioitinh.DataPropertyName = "gioitinh";
			this.gioitinh.HeaderText = "Giới tính";
			this.gioitinh.Name = "gioitinh";
			this.gioitinh.ReadOnly = true;
			// 
			// diem
			// 
			this.diem.DataPropertyName = "diem";
			this.diem.HeaderText = "Điểm";
			this.diem.Name = "diem";
			this.diem.ReadOnly = true;
			// 
			// btn_them
			// 
			this.btn_them.Location = new System.Drawing.Point(89, 398);
			this.btn_them.Name = "btn_them";
			this.btn_them.Size = new System.Drawing.Size(75, 23);
			this.btn_them.TabIndex = 12;
			this.btn_them.Text = "Thêm";
			this.btn_them.UseVisualStyleBackColor = true;
			this.btn_them.Click += new System.EventHandler(this.btn_them_click);
			// 
			// btn_xoa
			// 
			this.btn_xoa.Location = new System.Drawing.Point(214, 398);
			this.btn_xoa.Name = "btn_xoa";
			this.btn_xoa.Size = new System.Drawing.Size(75, 23);
			this.btn_xoa.TabIndex = 13;
			this.btn_xoa.Text = "Xóa";
			this.btn_xoa.UseVisualStyleBackColor = true;
			this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
			// 
			// btn_sua
			// 
			this.btn_sua.Location = new System.Drawing.Point(324, 398);
			this.btn_sua.Name = "btn_sua";
			this.btn_sua.Size = new System.Drawing.Size(75, 23);
			this.btn_sua.TabIndex = 14;
			this.btn_sua.Text = "Sửa";
			this.btn_sua.UseVisualStyleBackColor = true;
			this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
			// 
			// btn_thoat
			// 
			this.btn_thoat.Location = new System.Drawing.Point(467, 398);
			this.btn_thoat.Name = "btn_thoat";
			this.btn_thoat.Size = new System.Drawing.Size(75, 23);
			this.btn_thoat.TabIndex = 15;
			this.btn_thoat.Text = "Thoát";
			this.btn_thoat.UseVisualStyleBackColor = true;
			this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(575, 450);
			this.Controls.Add(this.btn_thoat);
			this.Controls.Add(this.btn_sua);
			this.Controls.Add(this.btn_xoa);
			this.Controls.Add(this.btn_them);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.txt_diachi);
			this.Controls.Add(this.txt_diem);
			this.Controls.Add(this.txt_gioitinh);
			this.Controls.Add(this.txt_tensv);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txt_masv);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txt_masv;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txt_tensv;
		private System.Windows.Forms.TextBox txt_gioitinh;
		private System.Windows.Forms.TextBox txt_diem;
		private System.Windows.Forms.TextBox txt_diachi;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn masinhvien;
		private System.Windows.Forms.DataGridViewTextBoxColumn tensinhvien;
		private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
		private System.Windows.Forms.DataGridViewTextBoxColumn gioitinh;
		private System.Windows.Forms.DataGridViewTextBoxColumn diem;
		private System.Windows.Forms.Button btn_them;
		private System.Windows.Forms.Button btn_xoa;
		private System.Windows.Forms.Button btn_sua;
		private System.Windows.Forms.Button btn_thoat;
	}
}

