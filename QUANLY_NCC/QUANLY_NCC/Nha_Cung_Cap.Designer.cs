namespace QUANLY_NCC
{
    partial class Nha_Cung_Cap
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
            this.btn_them = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ma_ncc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten_ncc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dia_chi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.so_dien_thoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_mancc = new System.Windows.Forms.TextBox();
            this.txt_sodienthoai = new System.Windows.Forms.TextBox();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.txt_tenncc = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(138, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(527, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thong tin nha cung cap";
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(148, 299);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 23);
            this.btn_them.TabIndex = 1;
            this.btn_them.Text = "Them";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ma_ncc,
            this.ten_ncc,
            this.dia_chi,
            this.so_dien_thoai});
            this.dataGridView1.Location = new System.Drawing.Point(261, 257);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(539, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(285, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ten nha cung cap";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ma nha cung cap";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(681, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "So dien thoai";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(513, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Dia chi";
            // 
            // ma_ncc
            // 
            this.ma_ncc.DataPropertyName = "ma_ncc";
            this.ma_ncc.HeaderText = "Ma nha cung cap";
            this.ma_ncc.Name = "ma_ncc";
            this.ma_ncc.ReadOnly = true;
            // 
            // ten_ncc
            // 
            this.ten_ncc.DataPropertyName = "ten_ncc";
            this.ten_ncc.HeaderText = "Ten nha cung cap";
            this.ten_ncc.Name = "ten_ncc";
            this.ten_ncc.ReadOnly = true;
            // 
            // dia_chi
            // 
            this.dia_chi.DataPropertyName = "dia_chi";
            this.dia_chi.HeaderText = "Dia chi";
            this.dia_chi.Name = "dia_chi";
            this.dia_chi.ReadOnly = true;
            // 
            // so_dien_thoai
            // 
            this.so_dien_thoai.DataPropertyName = "so_dien_thoai";
            this.so_dien_thoai.HeaderText = "So dien thoai";
            this.so_dien_thoai.Name = "so_dien_thoai";
            this.so_dien_thoai.ReadOnly = true;
            // 
            // txt_mancc
            // 
            this.txt_mancc.Location = new System.Drawing.Point(148, 111);
            this.txt_mancc.Name = "txt_mancc";
            this.txt_mancc.Size = new System.Drawing.Size(100, 20);
            this.txt_mancc.TabIndex = 7;
            // 
            // txt_sodienthoai
            // 
            this.txt_sodienthoai.Location = new System.Drawing.Point(756, 108);
            this.txt_sodienthoai.Name = "txt_sodienthoai";
            this.txt_sodienthoai.Size = new System.Drawing.Size(100, 20);
            this.txt_sodienthoai.TabIndex = 8;
            // 
            // txt_diachi
            // 
            this.txt_diachi.Location = new System.Drawing.Point(559, 108);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(100, 20);
            this.txt_diachi.TabIndex = 9;
            // 
            // txt_tenncc
            // 
            this.txt_tenncc.Location = new System.Drawing.Point(386, 108);
            this.txt_tenncc.Name = "txt_tenncc";
            this.txt_tenncc.Size = new System.Drawing.Size(100, 20);
            this.txt_tenncc.TabIndex = 10;
            // 
            // Nha_Cung_Cap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 450);
            this.Controls.Add(this.txt_tenncc);
            this.Controls.Add(this.txt_diachi);
            this.Controls.Add(this.txt_sodienthoai);
            this.Controls.Add(this.txt_mancc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.label1);
            this.Name = "Nha_Cung_Cap";
            this.Text = "Nha_Cung_Cap";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma_ncc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten_ncc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dia_chi;
        private System.Windows.Forms.DataGridViewTextBoxColumn so_dien_thoai;
        private System.Windows.Forms.TextBox txt_mancc;
        private System.Windows.Forms.TextBox txt_sodienthoai;
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.TextBox txt_tenncc;
    }
}