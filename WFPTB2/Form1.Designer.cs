namespace WFPTB2
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
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.txt_a = new System.Windows.Forms.TextBox();
			this.txt_b = new System.Windows.Forms.TextBox();
			this.txt_c = new System.Windows.Forms.TextBox();
			this.txt_x = new System.Windows.Forms.TextBox();
			this.txt_x1 = new System.Windows.Forms.TextBox();
			this.txt_x2 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(168, 62);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(464, 40);
			this.label1.TabIndex = 0;
			this.label1.Text = "GIẢI PHƯƠNG TRÌNH BẬC 2";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(122, 147);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(16, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "a:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(122, 215);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(16, 13);
			this.label3.TabIndex = 1;
			this.label3.Text = "b:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(122, 288);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(16, 13);
			this.label4.TabIndex = 1;
			this.label4.Text = "c:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(464, 288);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(15, 13);
			this.label5.TabIndex = 1;
			this.label5.Text = "x:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(464, 215);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(21, 13);
			this.label6.TabIndex = 2;
			this.label6.Text = "x2:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(464, 147);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(21, 13);
			this.label7.TabIndex = 3;
			this.label7.Text = "x1:";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(175, 342);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 4;
			this.button1.Text = "Run";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.btn_Run_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(353, 342);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 5;
			this.button2.Text = "Reset";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.btn_Reset_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(535, 342);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 6;
			this.button3.Text = "Exit";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.btn_Click_Exit);
			// 
			// txt_a
			// 
			this.txt_a.Location = new System.Drawing.Point(189, 147);
			this.txt_a.Multiline = true;
			this.txt_a.Name = "txt_a";
			this.txt_a.Size = new System.Drawing.Size(100, 20);
			this.txt_a.TabIndex = 7;
			this.txt_a.Leave += new System.EventHandler(this.txt_a_Leave);
			// 
			// txt_b
			// 
			this.txt_b.Location = new System.Drawing.Point(189, 215);
			this.txt_b.Multiline = true;
			this.txt_b.Name = "txt_b";
			this.txt_b.Size = new System.Drawing.Size(100, 20);
			this.txt_b.TabIndex = 7;
			this.txt_b.Leave += new System.EventHandler(this.txt_b_Leave);
			// 
			// txt_c
			// 
			this.txt_c.Location = new System.Drawing.Point(189, 285);
			this.txt_c.Multiline = true;
			this.txt_c.Name = "txt_c";
			this.txt_c.Size = new System.Drawing.Size(100, 20);
			this.txt_c.TabIndex = 7;
			this.txt_c.Leave += new System.EventHandler(this.txt_c_Leave);
			// 
			// txt_x
			// 
			this.txt_x.Location = new System.Drawing.Point(532, 281);
			this.txt_x.Multiline = true;
			this.txt_x.Name = "txt_x";
			this.txt_x.Size = new System.Drawing.Size(100, 20);
			this.txt_x.TabIndex = 7;
			// 
			// txt_x1
			// 
			this.txt_x1.Location = new System.Drawing.Point(532, 144);
			this.txt_x1.Multiline = true;
			this.txt_x1.Name = "txt_x1";
			this.txt_x1.Size = new System.Drawing.Size(100, 20);
			this.txt_x1.TabIndex = 7;
			// 
			// txt_x2
			// 
			this.txt_x2.Location = new System.Drawing.Point(532, 215);
			this.txt_x2.Multiline = true;
			this.txt_x2.Name = "txt_x2";
			this.txt_x2.Size = new System.Drawing.Size(100, 20);
			this.txt_x2.TabIndex = 7;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 462);
			this.Controls.Add(this.txt_x1);
			this.Controls.Add(this.txt_x2);
			this.Controls.Add(this.txt_x);
			this.Controls.Add(this.txt_c);
			this.Controls.Add(this.txt_b);
			this.Controls.Add(this.txt_a);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
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
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.TextBox txt_a;
		private System.Windows.Forms.TextBox txt_b;
		private System.Windows.Forms.TextBox txt_c;
		private System.Windows.Forms.TextBox txt_x;
		private System.Windows.Forms.TextBox txt_x1;
		private System.Windows.Forms.TextBox txt_x2;
	}
}

