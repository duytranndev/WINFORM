using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DangNhap
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btn_dangnhap(object sender, EventArgs e)
		{
			if(this.txt_name.Text.ToUpper()=="admin".ToUpper() && this.txt_pass.Text == "duy")
			{
				Thong_tin_hoc_vien Thong_Tin_Hoc_Vien = new Thong_tin_hoc_vien(this);
				Thong_Tin_Hoc_Vien.Show();
				this.Hide();
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		

		private void txt_name_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == 13) this.btn_dangnhap(sender, e);
		}

		private void txt_pass_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == 13) this.btn_dangnhap(sender, e);
		}
	}
}
