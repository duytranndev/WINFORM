namespace QUAN_LY_HANG
{
    partial class MATHANG
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
            this.txt_mahang = new System.Windows.Forms.TextBox();
            this.txt_ngayvaokho = new System.Windows.Forms.TextBox();
            this.txt_tenhang = new System.Windows.Forms.TextBox();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ma_hang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten_hang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngay_vao_kho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "MẶT HÀNG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(152, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày vào kho";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(152, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tên hàng";
            // 
            // txt_mahang
            // 
            this.txt_mahang.Location = new System.Drawing.Point(236, 92);
            this.txt_mahang.Name = "txt_mahang";
            this.txt_mahang.Size = new System.Drawing.Size(100, 20);
            this.txt_mahang.TabIndex = 4;
            // 
            // txt_ngayvaokho
            // 
            this.txt_ngayvaokho.Location = new System.Drawing.Point(236, 174);
            this.txt_ngayvaokho.Name = "txt_ngayvaokho";
            this.txt_ngayvaokho.Size = new System.Drawing.Size(100, 20);
            this.txt_ngayvaokho.TabIndex = 5;
            // 
            // txt_tenhang
            // 
            this.txt_tenhang.Location = new System.Drawing.Point(236, 134);
            this.txt_tenhang.Name = "txt_tenhang";
            this.txt_tenhang.Size = new System.Drawing.Size(100, 20);
            this.txt_tenhang.TabIndex = 6;
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(70, 404);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 23);
            this.btn_them.TabIndex = 7;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(173, 404);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_xoa.TabIndex = 8;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(390, 404);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_thoat.TabIndex = 9;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(278, 404);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 23);
            this.btn_sua.TabIndex = 10;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ma_hang,
            this.ten_hang,
            this.ngay_vao_kho});
            this.dataGridView1.Location = new System.Drawing.Point(70, 215);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(395, 150);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ma_hang
            // 
            this.ma_hang.DataPropertyName = "ma_hang";
            this.ma_hang.HeaderText = "Mã hàng";
            this.ma_hang.Name = "ma_hang";
            // 
            // ten_hang
            // 
            this.ten_hang.DataPropertyName = "ten_hang";
            this.ten_hang.HeaderText = "Tên hàng";
            this.ten_hang.Name = "ten_hang";
            // 
            // ngay_vao_kho
            // 
            this.ngay_vao_kho.DataPropertyName = "ngay_vao_kho";
            this.ngay_vao_kho.HeaderText = "Ngày vào kho";
            this.ngay_vao_kho.Name = "ngay_vao_kho";
            // 
            // MATHANG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.txt_tenhang);
            this.Controls.Add(this.txt_ngayvaokho);
            this.Controls.Add(this.txt_mahang);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MATHANG";
            this.Text = "MATHANG";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_mahang;
        private System.Windows.Forms.TextBox txt_ngayvaokho;
        private System.Windows.Forms.TextBox txt_tenhang;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma_hang;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten_hang;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngay_vao_kho;
    }
}