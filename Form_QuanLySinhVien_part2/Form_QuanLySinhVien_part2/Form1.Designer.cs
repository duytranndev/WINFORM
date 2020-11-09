namespace Form_QuanLySinhVien_part2
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
			this.components = new System.ComponentModel.Container();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.btn_xoa = new System.Windows.Forms.Button();
			this.btn_them = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.btn_sua = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.btn_exit = new System.Windows.Forms.Button();
			this.txt_masinhvien = new System.Windows.Forms.TextBox();
			this.txt_diachi = new System.Windows.Forms.TextBox();
			this.txt_diemlythuyet = new System.Windows.Forms.TextBox();
			this.txt_tensinhvien = new System.Windows.Forms.TextBox();
			this.txt_diemthuchanh = new System.Windows.Forms.TextBox();
			this.txt_xeploai = new System.Windows.Forms.TextBox();
			this.txt_diemtrungbinh = new System.Windows.Forms.TextBox();
			this.dateTimePicker_ngaysinh = new System.Windows.Forms.DateTimePicker();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.masinhvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tensinhvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.diemlythuyet = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.diemthuchanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.combobox_gioitinh = new System.Windows.Forms.ComboBox();
			this.sinhvienDataSet1 = new Form_QuanLySinhVien_part2.App_Data.SINHVIENDataSet();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sinhvienDataSet1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(357, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(250, 26);
			this.label1.TabIndex = 0;
			this.label1.Text = "QUẢN LÝ SINH VIÊN";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(60, 98);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Địa chỉ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(310, 60);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(71, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Tên sinh viên";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(60, 143);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(73, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Điểm lý thuyết";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(310, 143);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(82, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "Điểm thực hành";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(310, 98);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(54, 13);
			this.label6.TabIndex = 5;
			this.label6.Text = "Ngày sinh";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(608, 143);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(81, 13);
			this.label7.TabIndex = 6;
			this.label7.Text = "Điểm trung bình";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(608, 98);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(45, 13);
			this.label8.TabIndex = 7;
			this.label8.Text = "Xếp loại";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(608, 60);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(47, 13);
			this.label9.TabIndex = 8;
			this.label9.Text = "Giới tính";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(60, 60);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(67, 13);
			this.label10.TabIndex = 9;
			this.label10.Text = "Mã sinh viên";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(832, 24);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(132, 181);
			this.pictureBox1.TabIndex = 10;
			this.pictureBox1.TabStop = false;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(125, 182);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 11;
			this.button1.Text = "<<";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.btn_first);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(696, 182);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 12;
			this.button2.Text = ">>";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.btn_last);
			// 
			// btn_xoa
			// 
			this.btn_xoa.Location = new System.Drawing.Point(505, 211);
			this.btn_xoa.Name = "btn_xoa";
			this.btn_xoa.Size = new System.Drawing.Size(75, 23);
			this.btn_xoa.TabIndex = 13;
			this.btn_xoa.Text = "Xóa";
			this.btn_xoa.UseVisualStyleBackColor = true;
			this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
			// 
			// btn_them
			// 
			this.btn_them.Location = new System.Drawing.Point(313, 211);
			this.btn_them.Name = "btn_them";
			this.btn_them.Size = new System.Drawing.Size(75, 23);
			this.btn_them.TabIndex = 14;
			this.btn_them.Text = "Thêm";
			this.btn_them.UseVisualStyleBackColor = true;
			this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(862, 211);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(75, 23);
			this.button5.TabIndex = 15;
			this.button5.Text = "Upload Ảnh";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.btn_upanh_Click);
			// 
			// btn_sua
			// 
			this.btn_sua.Location = new System.Drawing.Point(125, 211);
			this.btn_sua.Name = "btn_sua";
			this.btn_sua.Size = new System.Drawing.Size(75, 23);
			this.btn_sua.TabIndex = 16;
			this.btn_sua.Text = "Sửa";
			this.btn_sua.UseVisualStyleBackColor = true;
			this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
			// 
			// button7
			// 
			this.button7.Location = new System.Drawing.Point(505, 182);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(75, 23);
			this.button7.TabIndex = 17;
			this.button7.Text = ">";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.btn_next);
			// 
			// button8
			// 
			this.button8.Location = new System.Drawing.Point(313, 182);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(75, 23);
			this.button8.TabIndex = 18;
			this.button8.Text = "<";
			this.button8.UseVisualStyleBackColor = true;
			this.button8.Click += new System.EventHandler(this.btn_previous);
			// 
			// btn_exit
			// 
			this.btn_exit.Location = new System.Drawing.Point(696, 211);
			this.btn_exit.Name = "btn_exit";
			this.btn_exit.Size = new System.Drawing.Size(75, 23);
			this.btn_exit.TabIndex = 19;
			this.btn_exit.Text = "Thoát";
			this.btn_exit.UseVisualStyleBackColor = true;
			this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
			// 
			// txt_masinhvien
			// 
			this.txt_masinhvien.Location = new System.Drawing.Point(153, 57);
			this.txt_masinhvien.Name = "txt_masinhvien";
			this.txt_masinhvien.Size = new System.Drawing.Size(100, 20);
			this.txt_masinhvien.TabIndex = 20;
			// 
			// txt_diachi
			// 
			this.txt_diachi.Location = new System.Drawing.Point(153, 95);
			this.txt_diachi.Name = "txt_diachi";
			this.txt_diachi.Size = new System.Drawing.Size(100, 20);
			this.txt_diachi.TabIndex = 21;
			// 
			// txt_diemlythuyet
			// 
			this.txt_diemlythuyet.Location = new System.Drawing.Point(153, 140);
			this.txt_diemlythuyet.Name = "txt_diemlythuyet";
			this.txt_diemlythuyet.Size = new System.Drawing.Size(100, 20);
			this.txt_diemlythuyet.TabIndex = 22;
			// 
			// txt_tensinhvien
			// 
			this.txt_tensinhvien.Location = new System.Drawing.Point(400, 57);
			this.txt_tensinhvien.Name = "txt_tensinhvien";
			this.txt_tensinhvien.Size = new System.Drawing.Size(100, 20);
			this.txt_tensinhvien.TabIndex = 23;
			// 
			// txt_diemthuchanh
			// 
			this.txt_diemthuchanh.Location = new System.Drawing.Point(398, 136);
			this.txt_diemthuchanh.Name = "txt_diemthuchanh";
			this.txt_diemthuchanh.Size = new System.Drawing.Size(100, 20);
			this.txt_diemthuchanh.TabIndex = 24;
			// 
			// txt_xeploai
			// 
			this.txt_xeploai.Location = new System.Drawing.Point(696, 95);
			this.txt_xeploai.Name = "txt_xeploai";
			this.txt_xeploai.Size = new System.Drawing.Size(100, 20);
			this.txt_xeploai.TabIndex = 26;
			// 
			// txt_diemtrungbinh
			// 
			this.txt_diemtrungbinh.Location = new System.Drawing.Point(695, 133);
			this.txt_diemtrungbinh.Name = "txt_diemtrungbinh";
			this.txt_diemtrungbinh.Size = new System.Drawing.Size(100, 20);
			this.txt_diemtrungbinh.TabIndex = 27;
			// 
			// dateTimePicker_ngaysinh
			// 
			this.dateTimePicker_ngaysinh.Location = new System.Drawing.Point(398, 98);
			this.dateTimePicker_ngaysinh.Name = "dateTimePicker_ngaysinh";
			this.dateTimePicker_ngaysinh.Size = new System.Drawing.Size(182, 20);
			this.dateTimePicker_ngaysinh.TabIndex = 28;
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
            this.ngaysinh,
            this.diemlythuyet,
            this.diemthuchanh});
			this.dataGridView1.Location = new System.Drawing.Point(12, 267);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(1003, 150);
			this.dataGridView1.TabIndex = 30;
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
			this.tensinhvien.HeaderText = "Tên sinh viên";
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
			// ngaysinh
			// 
			this.ngaysinh.DataPropertyName = "ngaysinh";
			this.ngaysinh.HeaderText = "Ngày sinh";
			this.ngaysinh.Name = "ngaysinh";
			this.ngaysinh.ReadOnly = true;
			// 
			// diemlythuyet
			// 
			this.diemlythuyet.DataPropertyName = "diemlythuyet";
			this.diemlythuyet.HeaderText = "Điểm lý thuyết";
			this.diemlythuyet.Name = "diemlythuyet";
			this.diemlythuyet.ReadOnly = true;
			// 
			// diemthuchanh
			// 
			this.diemthuchanh.DataPropertyName = "diemthuchanh";
			this.diemthuchanh.HeaderText = "Điểm thực hành";
			this.diemthuchanh.Name = "diemthuchanh";
			this.diemthuchanh.ReadOnly = true;
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// imageList1
			// 
			this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// combobox_gioitinh
			// 
			this.combobox_gioitinh.FormattingEnabled = true;
			this.combobox_gioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nu"});
			this.combobox_gioitinh.Location = new System.Drawing.Point(696, 57);
			this.combobox_gioitinh.Name = "combobox_gioitinh";
			this.combobox_gioitinh.Size = new System.Drawing.Size(121, 21);
			this.combobox_gioitinh.TabIndex = 31;
			// 
			// sinhvienDataSet1
			// 
			this.sinhvienDataSet1.DataSetName = "SINHVIENDataSet";
			this.sinhvienDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1027, 450);
			this.Controls.Add(this.combobox_gioitinh);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.dateTimePicker_ngaysinh);
			this.Controls.Add(this.txt_diemtrungbinh);
			this.Controls.Add(this.txt_xeploai);
			this.Controls.Add(this.txt_diemthuchanh);
			this.Controls.Add(this.txt_tensinhvien);
			this.Controls.Add(this.txt_diemlythuyet);
			this.Controls.Add(this.txt_diachi);
			this.Controls.Add(this.txt_masinhvien);
			this.Controls.Add(this.btn_exit);
			this.Controls.Add(this.button8);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.btn_sua);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.btn_them);
			this.Controls.Add(this.btn_xoa);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sinhvienDataSet1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button btn_xoa;
		private System.Windows.Forms.Button btn_them;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button btn_sua;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button btn_exit;
		private System.Windows.Forms.TextBox txt_masinhvien;
		private System.Windows.Forms.TextBox txt_diachi;
		private System.Windows.Forms.TextBox txt_diemlythuyet;
		private System.Windows.Forms.TextBox txt_tensinhvien;
		private System.Windows.Forms.TextBox txt_diemthuchanh;
		private System.Windows.Forms.TextBox txt_xeploai;
		private System.Windows.Forms.TextBox txt_diemtrungbinh;
		private System.Windows.Forms.DateTimePicker dateTimePicker_ngaysinh;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.BindingSource bindingSource1;
		private System.Windows.Forms.ComboBox combobox_gioitinh;
		private App_Data.SINHVIENDataSet sinhvienDataSet1;
		private System.Windows.Forms.DataGridViewTextBoxColumn masinhvien;
		private System.Windows.Forms.DataGridViewTextBoxColumn tensinhvien;
		private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
		private System.Windows.Forms.DataGridViewTextBoxColumn gioitinh;
		private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh;
		private System.Windows.Forms.DataGridViewTextBoxColumn diemlythuyet;
		private System.Windows.Forms.DataGridViewTextBoxColumn diemthuchanh;
	}
}

