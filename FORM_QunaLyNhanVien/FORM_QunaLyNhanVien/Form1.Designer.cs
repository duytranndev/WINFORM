namespace FORM_QunaLyNhanVien
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
			this.txt_manv = new System.Windows.Forms.TextBox();
			this.txt_ngaysinh = new System.Windows.Forms.TextBox();
			this.txt_tennv = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.label5 = new System.Windows.Forms.Label();
			this.btn_them = new System.Windows.Forms.Button();
			this.btn_thoat = new System.Windows.Forms.Button();
			this.btn_xoa = new System.Windows.Forms.Button();
			this.btn_sua = new System.Windows.Forms.Button();
			this.btn_upload = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.manv = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tennv = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.anh = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(225, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(345, 42);
			this.label1.TabIndex = 0;
			this.label1.Text = "Quan Ly Nhan Vien";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(100, 186);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Ngay Sinh";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(116, 139);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(44, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Ten NV";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(116, 89);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(40, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Ma NV";
			// 
			// txt_manv
			// 
			this.txt_manv.Location = new System.Drawing.Point(201, 82);
			this.txt_manv.Name = "txt_manv";
			this.txt_manv.Size = new System.Drawing.Size(100, 20);
			this.txt_manv.TabIndex = 4;
			// 
			// txt_ngaysinh
			// 
			this.txt_ngaysinh.Location = new System.Drawing.Point(201, 183);
			this.txt_ngaysinh.Name = "txt_ngaysinh";
			this.txt_ngaysinh.Size = new System.Drawing.Size(100, 20);
			this.txt_ngaysinh.TabIndex = 5;
			// 
			// txt_tennv
			// 
			this.txt_tennv.Location = new System.Drawing.Point(201, 136);
			this.txt_tennv.Name = "txt_tennv";
			this.txt_tennv.Size = new System.Drawing.Size(100, 20);
			this.txt_tennv.TabIndex = 6;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(469, 76);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(149, 127);
			this.pictureBox1.TabIndex = 7;
			this.pictureBox1.TabStop = false;
			// 
			// imageList1
			// 
			this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(423, 136);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(26, 13);
			this.label5.TabIndex = 8;
			this.label5.Text = "Anh";
			// 
			// btn_them
			// 
			this.btn_them.Location = new System.Drawing.Point(135, 223);
			this.btn_them.Name = "btn_them";
			this.btn_them.Size = new System.Drawing.Size(75, 29);
			this.btn_them.TabIndex = 9;
			this.btn_them.Text = "Them";
			this.btn_them.UseVisualStyleBackColor = true;
			this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
			// 
			// btn_thoat
			// 
			this.btn_thoat.Location = new System.Drawing.Point(531, 223);
			this.btn_thoat.Name = "btn_thoat";
			this.btn_thoat.Size = new System.Drawing.Size(75, 29);
			this.btn_thoat.TabIndex = 10;
			this.btn_thoat.Text = "Thoat";
			this.btn_thoat.UseVisualStyleBackColor = true;
			// 
			// btn_xoa
			// 
			this.btn_xoa.Location = new System.Drawing.Point(399, 223);
			this.btn_xoa.Name = "btn_xoa";
			this.btn_xoa.Size = new System.Drawing.Size(75, 29);
			this.btn_xoa.TabIndex = 11;
			this.btn_xoa.Text = "Xoa";
			this.btn_xoa.UseVisualStyleBackColor = true;
			this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
			// 
			// btn_sua
			// 
			this.btn_sua.Location = new System.Drawing.Point(265, 223);
			this.btn_sua.Name = "btn_sua";
			this.btn_sua.Size = new System.Drawing.Size(75, 29);
			this.btn_sua.TabIndex = 12;
			this.btn_sua.Text = "Sua";
			this.btn_sua.UseVisualStyleBackColor = true;
			this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
			// 
			// btn_upload
			// 
			this.btn_upload.Location = new System.Drawing.Point(624, 128);
			this.btn_upload.Name = "btn_upload";
			this.btn_upload.Size = new System.Drawing.Size(75, 29);
			this.btn_upload.TabIndex = 13;
			this.btn_upload.Text = "Tai Len";
			this.btn_upload.UseVisualStyleBackColor = true;
			this.btn_upload.Click += new System.EventHandler(this.btn_upload_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.manv,
            this.tennv,
            this.ngaysinh,
            this.anh});
			this.dataGridView1.Location = new System.Drawing.Point(135, 276);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(522, 135);
			this.dataGridView1.TabIndex = 14;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// manv
			// 
			this.manv.DataPropertyName = "manv";
			this.manv.HeaderText = "Mã nhân viên";
			this.manv.Name = "manv";
			// 
			// tennv
			// 
			this.tennv.DataPropertyName = "tennv";
			this.tennv.HeaderText = "Tên Nhân Viên";
			this.tennv.Name = "tennv";
			// 
			// ngaysinh
			// 
			this.ngaysinh.DataPropertyName = "ngaysinh";
			this.ngaysinh.HeaderText = "Ngày Sinh";
			this.ngaysinh.Name = "ngaysinh";
			// 
			// anh
			// 
			this.anh.DataPropertyName = "anh";
			this.anh.HeaderText = "Anh";
			this.anh.Name = "anh";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btn_upload);
			this.Controls.Add(this.btn_sua);
			this.Controls.Add(this.btn_xoa);
			this.Controls.Add(this.btn_thoat);
			this.Controls.Add(this.btn_them);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.txt_tennv);
			this.Controls.Add(this.txt_ngaysinh);
			this.Controls.Add(this.txt_manv);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txt_manv;
		private System.Windows.Forms.TextBox txt_ngaysinh;
		private System.Windows.Forms.TextBox txt_tennv;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btn_them;
		private System.Windows.Forms.Button btn_thoat;
		private System.Windows.Forms.Button btn_xoa;
		private System.Windows.Forms.Button btn_sua;
		private System.Windows.Forms.Button btn_upload;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn manv;
		private System.Windows.Forms.DataGridViewTextBoxColumn tennv;
		private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh;
		private System.Windows.Forms.DataGridViewTextBoxColumn anh;
	}
}

