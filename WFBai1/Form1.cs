using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFBai1
{
	public partial class Form1 : Form
	{
		double a, b, c;
		public Form1()
		{
			InitializeComponent();
		}

		

		private void label1_Click(object sender, EventArgs e)
		{

		}

		

		private void btn_tru_Click(object sender, EventArgs e)
		{
			if (txt_so1.Text == "" || txt_so2.Text == "")
			{
				MessageBox.Show("Sai du lieu nhap vao!!");
				return;
			}
			a = double.Parse(txt_so1.Text);
			b = double.Parse(txt_so2.Text);
			c = a - b;
			txt_ketqua.Text = c.ToString();
		}

		private void btn_nhan_Click(object sender, EventArgs e)
		{
			if (txt_so1.Text == "" || txt_so2.Text == "")
			{
				MessageBox.Show("Sai du lieu nhap vao!!");
				return;
			}
			a = double.Parse(txt_so1.Text);
			b = double.Parse(txt_so2.Text);
			c = a * b;
			txt_ketqua.Text = c.ToString();
		}

		

		private void btn_cong(object sender, EventArgs e)
		{
			if (txt_so1.Text == "" || txt_so2.Text == "")
			{
				MessageBox.Show("Sai du lieu nhap vao!!");
				return;
			}
			a = double.Parse(txt_so1.Text);
			b = double.Parse(txt_so2.Text);
			c = a + b;
			txt_ketqua.Text = c.ToString();
		}

		private void btn_chia(object sender, EventArgs e)
		{
			if (txt_so1.Text == "" || txt_so2.Text == "")
			{
				MessageBox.Show("Sai du lieu nhap vao!!");
				return;
			}
			a = double.Parse(txt_so1.Text);
			b = double.Parse(txt_so2.Text);
			c = a / b;
			txt_ketqua.Text = c.ToString();
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
	}
}
	