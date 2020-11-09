namespace KiemTra_QuanLySinhVien
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
			this.btn_thoat = new System.Windows.Forms.Button();
			this.btn_xoa = new System.Windows.Forms.Button();
			this.btn_them = new System.Windows.Forms.Button();
			this.btn_sua = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.masinhvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tensinhvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.diem = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.anh = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txt_diem = new System.Windows.Forms.TextBox();
			this.txt_ngaysinh = new System.Windows.Forms.TextBox();
			this.txt_tensv = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txt_masv = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btn_upload = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label6 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// btn_thoat
			// 
			this.btn_thoat.Location = new System.Drawing.Point(518, 407);
			this.btn_thoat.Name = "btn_thoat";
			this.btn_thoat.Size = new System.Drawing.Size(75, 23);
			this.btn_thoat.TabIndex = 31;
			this.btn_thoat.Text = "Thoát";
			this.btn_thoat.UseVisualStyleBackColor = true;
			// 
			// btn_xoa
			// 
			this.btn_xoa.Location = new System.Drawing.Point(271, 407);
			this.btn_xoa.Name = "btn_xoa";
			this.btn_xoa.Size = new System.Drawing.Size(75, 23);
			this.btn_xoa.TabIndex = 29;
			this.btn_xoa.Text = "Xóa";
			this.btn_xoa.UseVisualStyleBackColor = true;
			this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
			// 
			// btn_them
			// 
			this.btn_them.Location = new System.Drawing.Point(141, 407);
			this.btn_them.Name = "btn_them";
			this.btn_them.Size = new System.Drawing.Size(75, 23);
			this.btn_them.TabIndex = 28;
			this.btn_them.Text = "Thêm";
			this.btn_them.UseVisualStyleBackColor = true;
			this.btn_them.Click += new System.EventHandler(this.btn_them_Click_1);
			// 
			// btn_sua
			// 
			this.btn_sua.Location = new System.Drawing.Point(397, 407);
			this.btn_sua.Name = "btn_sua";
			this.btn_sua.Size = new System.Drawing.Size(75, 23);
			this.btn_sua.TabIndex = 30;
			this.btn_sua.Text = "Sửa";
			this.btn_sua.UseVisualStyleBackColor = true;
			this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click_1);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masinhvien,
            this.tensinhvien,
            this.diem,
            this.ngaysinh,
            this.anh});
			this.dataGridView1.Location = new System.Drawing.Point(126, 223);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(590, 165);
			this.dataGridView1.TabIndex = 27;
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
			// diem
			// 
			this.diem.DataPropertyName = "diem";
			this.diem.HeaderText = "Điểm";
			this.diem.Name = "diem";
			this.diem.ReadOnly = true;
			// 
			// ngaysinh
			// 
			this.ngaysinh.DataPropertyName = "ngaysinh";
			this.ngaysinh.HeaderText = "Ngày sinh";
			this.ngaysinh.Name = "ngaysinh";
			this.ngaysinh.ReadOnly = true;
			// 
			// anh
			// 
			this.anh.DataPropertyName = "anh";
			this.anh.HeaderText = "Ảnh";
			this.anh.Name = "anh";
			this.anh.ReadOnly = true;
			// 
			// txt_diem
			// 
			this.txt_diem.Location = new System.Drawing.Point(420, 135);
			this.txt_diem.Name = "txt_diem";
			this.txt_diem.Size = new System.Drawing.Size(104, 20);
			this.txt_diem.TabIndex = 25;
			// 
			// txt_ngaysinh
			// 
			this.txt_ngaysinh.Location = new System.Drawing.Point(420, 90);
			this.txt_ngaysinh.Name = "txt_ngaysinh";
			this.txt_ngaysinh.Size = new System.Drawing.Size(104, 20);
			this.txt_ngaysinh.TabIndex = 24;
			// 
			// txt_tensv
			// 
			this.txt_tensv.Location = new System.Drawing.Point(200, 131);
			this.txt_tensv.Name = "txt_tensv";
			this.txt_tensv.Size = new System.Drawing.Size(104, 20);
			this.txt_tensv.TabIndex = 23;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(360, 138);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(31, 13);
			this.label5.TabIndex = 21;
			this.label5.Text = "Diem";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(320, 21);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(190, 26);
			this.label4.TabIndex = 20;
			this.label4.Text = "Quan ly sinh vien";
			// 
			// txt_masv
			// 
			this.txt_masv.Location = new System.Drawing.Point(200, 90);
			this.txt_masv.Name = "txt_masv";
			this.txt_masv.Size = new System.Drawing.Size(104, 20);
			this.txt_masv.TabIndex = 19;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(360, 90);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(54, 13);
			this.label3.TabIndex = 18;
			this.label3.Text = "Ngay sinh";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(123, 131);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(71, 13);
			this.label2.TabIndex = 17;
			this.label2.Text = "Ten sinh vien";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(124, 90);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 13);
			this.label1.TabIndex = 16;
			this.label1.Text = "Ma sinh vien";
			// 
			// btn_upload
			// 
			this.btn_upload.Location = new System.Drawing.Point(693, 185);
			this.btn_upload.Name = "btn_upload";
			this.btn_upload.Size = new System.Drawing.Size(75, 23);
			this.btn_upload.TabIndex = 32;
			this.btn_upload.Text = "upload";
			this.btn_upload.UseVisualStyleBackColor = true;
			this.btn_upload.Click += new System.EventHandler(this.btn_upload_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(616, 21);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(226, 158);
			this.pictureBox1.TabIndex = 34;
			this.pictureBox1.TabStop = false;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(584, 112);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(26, 13);
			this.label6.TabIndex = 35;
			this.label6.Text = "Anh";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1000, 450);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btn_upload);
			this.Controls.Add(this.btn_thoat);
			this.Controls.Add(this.btn_xoa);
			this.Controls.Add(this.btn_them);
			this.Controls.Add(this.btn_sua);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.txt_diem);
			this.Controls.Add(this.txt_ngaysinh);
			this.Controls.Add(this.txt_tensv);
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
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btn_thoat;
		private System.Windows.Forms.Button btn_xoa;
		private System.Windows.Forms.Button btn_them;
		private System.Windows.Forms.Button btn_sua;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TextBox txt_diem;
		private System.Windows.Forms.TextBox txt_ngaysinh;
		private System.Windows.Forms.TextBox txt_tensv;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txt_masv;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btn_upload;
		private System.Windows.Forms.DataGridViewTextBoxColumn masinhvien;
		private System.Windows.Forms.DataGridViewTextBoxColumn tensinhvien;
		private System.Windows.Forms.DataGridViewTextBoxColumn diem;
		private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh;
		private System.Windows.Forms.DataGridViewTextBoxColumn anh;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label6;
	}
}

