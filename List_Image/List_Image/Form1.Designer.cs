namespace List_Image
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.listbox_source = new System.Windows.Forms.ListBox();
			this.listbox_target = new System.Windows.Forms.ListBox();
			this.btn_send_item_click = new System.Windows.Forms.Button();
			this.btn_back_item_click = new System.Windows.Forms.Button();
			this.btn_send_items_click = new System.Windows.Forms.Button();
			this.btn_back_items_click = new System.Windows.Forms.Button();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// listbox_source
			// 
			this.listbox_source.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listbox_source.FormattingEnabled = true;
			this.listbox_source.ItemHeight = 23;
			this.listbox_source.Items.AddRange(new object[] {
            "Duy",
            "Duyên",
            "Dũng",
            "Luân",
            "Hiếu",
            "Kiên",
            "Luân",
            "Linh"});
			this.listbox_source.Location = new System.Drawing.Point(36, 85);
			this.listbox_source.Name = "listbox_source";
			this.listbox_source.Size = new System.Drawing.Size(120, 188);
			this.listbox_source.TabIndex = 0;
			// 
			// listbox_target
			// 
			this.listbox_target.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listbox_target.FormattingEnabled = true;
			this.listbox_target.ItemHeight = 23;
			this.listbox_target.Location = new System.Drawing.Point(243, 85);
			this.listbox_target.Name = "listbox_target";
			this.listbox_target.Size = new System.Drawing.Size(143, 188);
			this.listbox_target.TabIndex = 1;
			this.listbox_target.SelectedIndexChanged += new System.EventHandler(this.listbox_target_SelectedIndexChanged);
			this.listbox_target.DoubleClick += new System.EventHandler(this.listbox_target_DoubleClick);
			// 
			// btn_send_item_click
			// 
			this.btn_send_item_click.Location = new System.Drawing.Point(162, 94);
			this.btn_send_item_click.Name = "btn_send_item_click";
			this.btn_send_item_click.Size = new System.Drawing.Size(75, 23);
			this.btn_send_item_click.TabIndex = 3;
			this.btn_send_item_click.Text = ">";
			this.btn_send_item_click.UseVisualStyleBackColor = true;
			this.btn_send_item_click.Click += new System.EventHandler(this.btn_send_item_click_Click);
			// 
			// btn_back_item_click
			// 
			this.btn_back_item_click.Location = new System.Drawing.Point(162, 140);
			this.btn_back_item_click.Name = "btn_back_item_click";
			this.btn_back_item_click.Size = new System.Drawing.Size(75, 23);
			this.btn_back_item_click.TabIndex = 4;
			this.btn_back_item_click.Text = "<";
			this.btn_back_item_click.UseVisualStyleBackColor = true;
			this.btn_back_item_click.Click += new System.EventHandler(this.btn_back_item_click_Click);
			// 
			// btn_send_items_click
			// 
			this.btn_send_items_click.Location = new System.Drawing.Point(162, 188);
			this.btn_send_items_click.Name = "btn_send_items_click";
			this.btn_send_items_click.Size = new System.Drawing.Size(75, 23);
			this.btn_send_items_click.TabIndex = 5;
			this.btn_send_items_click.Text = ">>";
			this.btn_send_items_click.UseVisualStyleBackColor = true;
			this.btn_send_items_click.Click += new System.EventHandler(this.btn_send_items_click_Click);
			// 
			// btn_back_items_click
			// 
			this.btn_back_items_click.Location = new System.Drawing.Point(162, 231);
			this.btn_back_items_click.Name = "btn_back_items_click";
			this.btn_back_items_click.Size = new System.Drawing.Size(75, 23);
			this.btn_back_items_click.TabIndex = 6;
			this.btn_back_items_click.Text = "<<";
			this.btn_back_items_click.UseVisualStyleBackColor = true;
			this.btn_back_items_click.Click += new System.EventHandler(this.btn_back_items_click_Click);
			// 
			// imageList1
			// 
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "deal_ofthe_week.png");
			this.imageList1.Images.SetKeyName(1, "desc_1.jpg");
			this.imageList1.Images.SetKeyName(2, "desc_2.jpg");
			this.imageList1.Images.SetKeyName(3, "desc_3.jpg");
			this.imageList1.Images.SetKeyName(4, "product_1.png");
			this.imageList1.Images.SetKeyName(5, "product_2.png");
			this.imageList1.Images.SetKeyName(6, "product_3.png");
			this.imageList1.Images.SetKeyName(7, "product_4.png");
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(515, 47);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(232, 259);
			this.pictureBox1.TabIndex = 7;
			this.pictureBox1.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btn_back_items_click);
			this.Controls.Add(this.btn_send_items_click);
			this.Controls.Add(this.btn_back_item_click);
			this.Controls.Add(this.btn_send_item_click);
			this.Controls.Add(this.listbox_target);
			this.Controls.Add(this.listbox_source);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox listbox_source;
		private System.Windows.Forms.ListBox listbox_target;
		private System.Windows.Forms.Button btn_send_item_click;
		private System.Windows.Forms.Button btn_back_item_click;
		private System.Windows.Forms.Button btn_send_items_click;
		private System.Windows.Forms.Button btn_back_items_click;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}

