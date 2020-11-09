namespace QuanTri_QuanLyNhanVien
{
	partial class PhongBan
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
			this.txt_mapb = new System.Windows.Forms.TextBox();
			this.txt_tentruongphong = new System.Windows.Forms.TextBox();
			this.txt_tenpb = new System.Windows.Forms.TextBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.maphongban = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tenphongban = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tentruongphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btn_them = new System.Windows.Forms.Button();
			this.btn_xoa = new System.Windows.Forms.Button();
			this.btn_thoat = new System.Windows.Forms.Button();
			this.btn_sua = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(94, 108);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(75, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "ma phong ban";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(370, 111);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(88, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "ten truong phong";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(93, 158);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(76, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "ten phong ban";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(281, 37);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(224, 39);
			this.label4.TabIndex = 3;
			this.label4.Text = "PHONG BAN";
			// 
			// txt_mapb
			// 
			this.txt_mapb.Location = new System.Drawing.Point(207, 108);
			this.txt_mapb.Name = "txt_mapb";
			this.txt_mapb.Size = new System.Drawing.Size(100, 20);
			this.txt_mapb.TabIndex = 4;
			// 
			// txt_tentruongphong
			// 
			this.txt_tentruongphong.Location = new System.Drawing.Point(484, 108);
			this.txt_tentruongphong.Name = "txt_tentruongphong";
			this.txt_tentruongphong.Size = new System.Drawing.Size(100, 20);
			this.txt_tentruongphong.TabIndex = 5;
			// 
			// txt_tenpb
			// 
			this.txt_tenpb.Location = new System.Drawing.Point(207, 155);
			this.txt_tenpb.Name = "txt_tenpb";
			this.txt_tenpb.Size = new System.Drawing.Size(100, 20);
			this.txt_tenpb.TabIndex = 6;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maphongban,
            this.tenphongban,
            this.tentruongphong});
			this.dataGridView1.Location = new System.Drawing.Point(87, 238);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(625, 150);
			this.dataGridView1.TabIndex = 7;
			// 
			// maphongban
			// 
			this.maphongban.DataPropertyName = "maphongban";
			this.maphongban.HeaderText = "Ma Phong Ban";
			this.maphongban.Name = "maphongban";
			// 
			// tenphongban
			// 
			this.tenphongban.DataPropertyName = "tenphongban";
			this.tenphongban.HeaderText = "Ten Phong Ban";
			this.tenphongban.Name = "tenphongban";
			// 
			// tentruongphong
			// 
			this.tentruongphong.DataPropertyName = "tentruongphong";
			this.tentruongphong.HeaderText = "Ten Truong Phong";
			this.tentruongphong.Name = "tentruongphong";
			// 
			// btn_them
			// 
			this.btn_them.Location = new System.Drawing.Point(97, 200);
			this.btn_them.Name = "btn_them";
			this.btn_them.Size = new System.Drawing.Size(75, 23);
			this.btn_them.TabIndex = 8;
			this.btn_them.Text = "Them";
			this.btn_them.UseVisualStyleBackColor = true;
			this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
			// 
			// btn_xoa
			// 
			this.btn_xoa.Location = new System.Drawing.Point(373, 200);
			this.btn_xoa.Name = "btn_xoa";
			this.btn_xoa.Size = new System.Drawing.Size(75, 23);
			this.btn_xoa.TabIndex = 9;
			this.btn_xoa.Text = "Xoa";
			this.btn_xoa.UseVisualStyleBackColor = true;
			this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
			// 
			// btn_thoat
			// 
			this.btn_thoat.Location = new System.Drawing.Point(509, 200);
			this.btn_thoat.Name = "btn_thoat";
			this.btn_thoat.Size = new System.Drawing.Size(75, 23);
			this.btn_thoat.TabIndex = 10;
			this.btn_thoat.Text = "Thoat";
			this.btn_thoat.UseVisualStyleBackColor = true;
			this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
			// 
			// btn_sua
			// 
			this.btn_sua.Location = new System.Drawing.Point(232, 200);
			this.btn_sua.Name = "btn_sua";
			this.btn_sua.Size = new System.Drawing.Size(75, 23);
			this.btn_sua.TabIndex = 11;
			this.btn_sua.Text = "Sua";
			this.btn_sua.UseVisualStyleBackColor = true;
			this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
			// 
			// PhongBan
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btn_sua);
			this.Controls.Add(this.btn_thoat);
			this.Controls.Add(this.btn_xoa);
			this.Controls.Add(this.btn_them);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.txt_tenpb);
			this.Controls.Add(this.txt_tentruongphong);
			this.Controls.Add(this.txt_mapb);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "PhongBan";
			this.Text = "PhongBan";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txt_mapb;
		private System.Windows.Forms.TextBox txt_tentruongphong;
		private System.Windows.Forms.TextBox txt_tenpb;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn maphongban;
		private System.Windows.Forms.DataGridViewTextBoxColumn tenphongban;
		private System.Windows.Forms.DataGridViewTextBoxColumn tentruongphong;
		private System.Windows.Forms.Button btn_them;
		private System.Windows.Forms.Button btn_xoa;
		private System.Windows.Forms.Button btn_thoat;
		private System.Windows.Forms.Button btn_sua;
	}
}