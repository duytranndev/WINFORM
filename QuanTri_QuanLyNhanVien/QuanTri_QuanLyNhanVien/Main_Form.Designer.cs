namespace QuanTri_QuanLyNhanVien
{
	partial class Main_Form
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.phongBanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.nhanVienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.baoCaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txt_ma_phongban = new System.Windows.Forms.TextBox();
			this.txt_ten_truongphong = new System.Windows.Forms.TextBox();
			this.txt_ten_phongban = new System.Windows.Forms.TextBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.maphongban = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.manhanvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tenphongban = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tentruongphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.baoCaoToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(69, 20);
			this.toolStripMenuItem1.Text = "He thong";
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.phongBanToolStripMenuItem,
            this.nhanVienToolStripMenuItem});
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
			this.openToolStripMenuItem.Text = "Open";
			// 
			// phongBanToolStripMenuItem
			// 
			this.phongBanToolStripMenuItem.Name = "phongBanToolStripMenuItem";
			this.phongBanToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
			this.phongBanToolStripMenuItem.Text = "Phong ban";
			this.phongBanToolStripMenuItem.Click += new System.EventHandler(this.phongBanToolStripMenuItem_Click);
			// 
			// nhanVienToolStripMenuItem
			// 
			this.nhanVienToolStripMenuItem.Name = "nhanVienToolStripMenuItem";
			this.nhanVienToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
			this.nhanVienToolStripMenuItem.Text = "Nhan Vien";
			this.nhanVienToolStripMenuItem.Click += new System.EventHandler(this.nhanVienToolStripMenuItem_Click);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// baoCaoToolStripMenuItem
			// 
			this.baoCaoToolStripMenuItem.Name = "baoCaoToolStripMenuItem";
			this.baoCaoToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
			this.baoCaoToolStripMenuItem.Text = "Bao Cao";
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(80, 104);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(75, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "ma phong ban";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(80, 155);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(88, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "ten truong phong";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(355, 104);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(76, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "ten phong ban";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(152, 34);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(510, 55);
			this.label4.TabIndex = 4;
			this.label4.Text = "QUAN LY NHAN VIEN";
			// 
			// txt_ma_phongban
			// 
			this.txt_ma_phongban.Location = new System.Drawing.Point(174, 97);
			this.txt_ma_phongban.Name = "txt_ma_phongban";
			this.txt_ma_phongban.Size = new System.Drawing.Size(100, 20);
			this.txt_ma_phongban.TabIndex = 5;
			// 
			// txt_ten_truongphong
			// 
			this.txt_ten_truongphong.Location = new System.Drawing.Point(174, 148);
			this.txt_ten_truongphong.Name = "txt_ten_truongphong";
			this.txt_ten_truongphong.Size = new System.Drawing.Size(100, 20);
			this.txt_ten_truongphong.TabIndex = 6;
			// 
			// txt_ten_phongban
			// 
			this.txt_ten_phongban.Location = new System.Drawing.Point(446, 101);
			this.txt_ten_phongban.Name = "txt_ten_phongban";
			this.txt_ten_phongban.Size = new System.Drawing.Size(100, 20);
			this.txt_ten_phongban.TabIndex = 7;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maphongban,
            this.gioitinh,
            this.ngaysinh,
            this.manhanvien,
            this.diachi,
            this.tenphongban,
            this.tentruongphong});
			this.dataGridView1.Location = new System.Drawing.Point(31, 242);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(735, 150);
			this.dataGridView1.TabIndex = 8;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(83, 195);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 9;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(406, 195);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 10;
			this.button2.Text = "button2";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(557, 195);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 11;
			this.button3.Text = "button3";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(252, 195);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(75, 23);
			this.button4.TabIndex = 12;
			this.button4.Text = "button4";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// maphongban
			// 
			this.maphongban.DataPropertyName = "maphongban";
			this.maphongban.HeaderText = "Ma Phong Ban";
			this.maphongban.Name = "maphongban";
			this.maphongban.ReadOnly = true;
			// 
			// gioitinh
			// 
			this.gioitinh.DataPropertyName = "gioitinh";
			this.gioitinh.HeaderText = "Gioi Tinh";
			this.gioitinh.Name = "gioitinh";
			this.gioitinh.ReadOnly = true;
			// 
			// ngaysinh
			// 
			this.ngaysinh.DataPropertyName = "ngaysinh";
			this.ngaysinh.HeaderText = "Ngay Sinh";
			this.ngaysinh.Name = "ngaysinh";
			this.ngaysinh.ReadOnly = true;
			// 
			// manhanvien
			// 
			this.manhanvien.DataPropertyName = "manhanvien";
			this.manhanvien.HeaderText = "Ma Nhan Vien";
			this.manhanvien.Name = "manhanvien";
			this.manhanvien.ReadOnly = true;
			// 
			// diachi
			// 
			this.diachi.DataPropertyName = "diachi";
			this.diachi.HeaderText = "Dia Chi";
			this.diachi.Name = "diachi";
			this.diachi.ReadOnly = true;
			// 
			// tenphongban
			// 
			this.tenphongban.DataPropertyName = "tenphongban";
			this.tenphongban.HeaderText = "Ten Phong Ban";
			this.tenphongban.Name = "tenphongban";
			this.tenphongban.ReadOnly = true;
			// 
			// tentruongphong
			// 
			this.tentruongphong.DataPropertyName = "tentruongphong";
			this.tentruongphong.HeaderText = "Ten Truong Phong";
			this.tentruongphong.Name = "tentruongphong";
			this.tentruongphong.ReadOnly = true;
			// 
			// Main_Form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.txt_ten_phongban);
			this.Controls.Add(this.txt_ten_truongphong);
			this.Controls.Add(this.txt_ma_phongban);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Main_Form";
			this.Text = "QUẢN LÝ NHÂN VIÊN";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem phongBanToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem nhanVienToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem baoCaoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txt_ma_phongban;
		private System.Windows.Forms.TextBox txt_ten_truongphong;
		private System.Windows.Forms.TextBox txt_ten_phongban;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.DataGridViewTextBoxColumn maphongban;
		private System.Windows.Forms.DataGridViewTextBoxColumn gioitinh;
		private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh;
		private System.Windows.Forms.DataGridViewTextBoxColumn manhanvien;
		private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
		private System.Windows.Forms.DataGridViewTextBoxColumn tenphongban;
		private System.Windows.Forms.DataGridViewTextBoxColumn tentruongphong;
	}
}

