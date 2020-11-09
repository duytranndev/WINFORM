namespace KT_GIUAKY
{
    partial class MAIN_FORM
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
            this.fILEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nHÀCUNGCẤPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vẬTTƯToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_mancc = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ma_ncc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ma_vt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten_vt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_first = new System.Windows.Forms.Button();
            this.bn_prev = new System.Windows.Forms.Button();
            this.btn_last = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_tim = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fILEToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(617, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fILEToolStripMenuItem
            // 
            this.fILEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nHÀCUNGCẤPToolStripMenuItem,
            this.vẬTTƯToolStripMenuItem});
            this.fILEToolStripMenuItem.Name = "fILEToolStripMenuItem";
            this.fILEToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.fILEToolStripMenuItem.Text = "FILE";
            // 
            // nHÀCUNGCẤPToolStripMenuItem
            // 
            this.nHÀCUNGCẤPToolStripMenuItem.Name = "nHÀCUNGCẤPToolStripMenuItem";
            this.nHÀCUNGCẤPToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.nHÀCUNGCẤPToolStripMenuItem.Text = "NHÀ CUNG CẤP";
            this.nHÀCUNGCẤPToolStripMenuItem.Click += new System.EventHandler(this.nHÀCUNGCẤPToolStripMenuItem_Click);
            // 
            // vẬTTƯToolStripMenuItem
            // 
            this.vẬTTƯToolStripMenuItem.Name = "vẬTTƯToolStripMenuItem";
            this.vẬTTƯToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.vẬTTƯToolStripMenuItem.Text = "VẬT TƯ";
            this.vẬTTƯToolStripMenuItem.Click += new System.EventHandler(this.vẬTTƯToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "QUẢN LÝ VẬT TƯ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã ncc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(340, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 3;
            // 
            // txt_mancc
            // 
            this.txt_mancc.Location = new System.Drawing.Point(256, 141);
            this.txt_mancc.Name = "txt_mancc";
            this.txt_mancc.Size = new System.Drawing.Size(100, 20);
            this.txt_mancc.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ma_ncc,
            this.ma_vt,
            this.ten_vt});
            this.dataGridView1.Location = new System.Drawing.Point(95, 190);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(424, 150);
            this.dataGridView1.TabIndex = 6;
            // 
            // ma_ncc
            // 
            this.ma_ncc.DataPropertyName = "ma_ncc";
            this.ma_ncc.HeaderText = "Mã Nhà CC";
            this.ma_ncc.Name = "ma_ncc";
            // 
            // ma_vt
            // 
            this.ma_vt.DataPropertyName = "ma_vt";
            this.ma_vt.HeaderText = "Mã Vật Tư";
            this.ma_vt.Name = "ma_vt";
            // 
            // ten_vt
            // 
            this.ten_vt.DataPropertyName = "ten_vt";
            this.ten_vt.HeaderText = "Tên Vật Tư";
            this.ten_vt.Name = "ten_vt";
            // 
            // btn_first
            // 
            this.btn_first.Location = new System.Drawing.Point(95, 364);
            this.btn_first.Name = "btn_first";
            this.btn_first.Size = new System.Drawing.Size(75, 23);
            this.btn_first.TabIndex = 7;
            this.btn_first.Text = "ĐẦU";
            this.btn_first.UseVisualStyleBackColor = true;
            // 
            // bn_prev
            // 
            this.bn_prev.Location = new System.Drawing.Point(327, 364);
            this.bn_prev.Name = "bn_prev";
            this.bn_prev.Size = new System.Drawing.Size(75, 23);
            this.bn_prev.TabIndex = 8;
            this.bn_prev.Text = "SAU";
            this.bn_prev.UseVisualStyleBackColor = true;
            // 
            // btn_last
            // 
            this.btn_last.Location = new System.Drawing.Point(444, 364);
            this.btn_last.Name = "btn_last";
            this.btn_last.Size = new System.Drawing.Size(75, 23);
            this.btn_last.TabIndex = 9;
            this.btn_last.Text = "CUỐI";
            this.btn_last.UseVisualStyleBackColor = true;
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(209, 364);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(75, 23);
            this.btn_next.TabIndex = 10;
            this.btn_next.Text = "TRƯỚC";
            this.btn_next.UseVisualStyleBackColor = true;
            // 
            // btn_tim
            // 
            this.btn_tim.Location = new System.Drawing.Point(410, 139);
            this.btn_tim.Name = "btn_tim";
            this.btn_tim.Size = new System.Drawing.Size(75, 23);
            this.btn_tim.TabIndex = 11;
            this.btn_tim.Text = "TÌM";
            this.btn_tim.UseVisualStyleBackColor = true;
            this.btn_tim.Click += new System.EventHandler(this.btn_tim_Click);
            // 
            // MAIN_FORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 450);
            this.Controls.Add(this.btn_tim);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_last);
            this.Controls.Add(this.bn_prev);
            this.Controls.Add(this.btn_first);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_mancc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MAIN_FORM";
            this.Text = "MAIN_FORM";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fILEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nHÀCUNGCẤPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vẬTTƯToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_mancc;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_first;
        private System.Windows.Forms.Button bn_prev;
        private System.Windows.Forms.Button btn_last;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma_ncc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma_vt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten_vt;
        private System.Windows.Forms.Button btn_tim;
    }
}