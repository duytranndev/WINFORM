namespace DangNhap
{
	partial class XemThongTin
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.thongtinhocvienBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.xemThongTinBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.so_cm = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ho_ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nam_sinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.khoa_hoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dia_chi = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.gioi_tinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.thoi_gian_hoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.su_dung_thu_vien = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.su_dung_may_tinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.thongtinhocvienBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.xemThongTinBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.so_cm,
            this.ho_ten,
            this.nam_sinh,
            this.khoa_hoc,
            this.dia_chi,
            this.gioi_tinh,
            this.thoi_gian_hoc,
            this.su_dung_thu_vien,
            this.su_dung_may_tinh});
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(0, 0);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(1055, 450);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(312, 379);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "Xem";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.btn_xem);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(436, 379);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 2;
			this.button2.Text = "Exit";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.btn_exit);
			// 
			// thongtinhocvienBindingSource
			// 
			this.thongtinhocvienBindingSource.DataSource = typeof(DangNhap.Thong_tin_hoc_vien);
			// 
			// xemThongTinBindingSource
			// 
			this.xemThongTinBindingSource.DataSource = typeof(DangNhap.XemThongTin);
			// 
			// stt
			// 
			this.stt.HeaderText = "Số thứ tự";
			this.stt.Name = "stt";
			this.stt.ReadOnly = true;
			// 
			// so_cm
			// 
			this.so_cm.HeaderText = "Số CM";
			this.so_cm.Name = "so_cm";
			this.so_cm.ReadOnly = true;
			// 
			// ho_ten
			// 
			this.ho_ten.HeaderText = "Họ Tên";
			this.ho_ten.Name = "ho_ten";
			this.ho_ten.ReadOnly = true;
			// 
			// nam_sinh
			// 
			this.nam_sinh.HeaderText = "Năm Sinh";
			this.nam_sinh.Name = "nam_sinh";
			this.nam_sinh.ReadOnly = true;
			// 
			// khoa_hoc
			// 
			this.khoa_hoc.HeaderText = "Khóa Học";
			this.khoa_hoc.Name = "khoa_hoc";
			this.khoa_hoc.ReadOnly = true;
			// 
			// dia_chi
			// 
			this.dia_chi.HeaderText = "Địa Chỉ";
			this.dia_chi.Name = "dia_chi";
			this.dia_chi.ReadOnly = true;
			// 
			// gioi_tinh
			// 
			this.gioi_tinh.HeaderText = "Giới Tính";
			this.gioi_tinh.Name = "gioi_tinh";
			this.gioi_tinh.ReadOnly = true;
			// 
			// thoi_gian_hoc
			// 
			this.thoi_gian_hoc.HeaderText = "Thời Gian Học";
			this.thoi_gian_hoc.Name = "thoi_gian_hoc";
			this.thoi_gian_hoc.ReadOnly = true;
			// 
			// su_dung_thu_vien
			// 
			this.su_dung_thu_vien.HeaderText = "Sử Dụng Thư Viện";
			this.su_dung_thu_vien.Name = "su_dung_thu_vien";
			this.su_dung_thu_vien.ReadOnly = true;
			// 
			// su_dung_may_tinh
			// 
			this.su_dung_may_tinh.HeaderText = "Sử Dụng Máy Tính";
			this.su_dung_may_tinh.Name = "su_dung_may_tinh";
			this.su_dung_may_tinh.ReadOnly = true;
			// 
			// XemThongTin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1055, 450);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.dataGridView1);
			this.Name = "XemThongTin";
			this.Text = "XemThongTin";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.XemThongTin_FormClosed);
			this.Load += new System.EventHandler(this.XemThongTin_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.thongtinhocvienBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.xemThongTinBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.BindingSource thongtinhocvienBindingSource;
		private System.Windows.Forms.BindingSource xemThongTinBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn stt;
		private System.Windows.Forms.DataGridViewTextBoxColumn so_cm;
		private System.Windows.Forms.DataGridViewTextBoxColumn ho_ten;
		private System.Windows.Forms.DataGridViewTextBoxColumn nam_sinh;
		private System.Windows.Forms.DataGridViewTextBoxColumn khoa_hoc;
		private System.Windows.Forms.DataGridViewTextBoxColumn dia_chi;
		private System.Windows.Forms.DataGridViewTextBoxColumn gioi_tinh;
		private System.Windows.Forms.DataGridViewTextBoxColumn thoi_gian_hoc;
		private System.Windows.Forms.DataGridViewTextBoxColumn su_dung_thu_vien;
		private System.Windows.Forms.DataGridViewTextBoxColumn su_dung_may_tinh;
	}
}