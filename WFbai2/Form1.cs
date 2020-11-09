using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFbai2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void comboBox_signal_SelectedIndexChanged(object sender, EventArgs e)
		{
			string str = this.comboBox_signal.SelectedItem.ToString();
			double a = 0, b = 0, c = 0;
			try
			{
				a=double.Parse(this.txtBox_a.Text);
			}
			catch (System.Exception)
			{
				MessageBox.Show("TextBox empty data!!");
				this.txtBox_a.Select();
			}

			try
			{
				b = double.Parse(this.txtBox_b.Text);
			}
			catch (System.Exception)
			{
				MessageBox.Show("TextBox empty data!!");
				this.txtBox_b.Select();
			}

			switch (str)
			{
				case "cộng":
					c = a + b;
					break;
				case "trừ":
					c = a - b;
					break;
				case "nhân":
					c = a * b;
					break;
				case "chia":
					c = a / b;
					break;
			}
			this.txtBox_c.Text = c.ToString();
		}

		private void txtBox_a_Leave(object sender, EventArgs e)
		{
			try
			{
				double.Parse(txtBox_a.Text);
			}
			catch (System.Exception)
			{
				MessageBox.Show("Invalid Data!!");
				this.txtBox_a.Text = "";
				this.txtBox_a.Select();
			}
		}

		private void txtBox_b_Leave(object sender, EventArgs e)
		{
			try
			{
				double.Parse(txtBox_b.Text);
			}
			catch (System.Exception)
			{
				MessageBox.Show("Invalid Data!!");
				this.txtBox_b.Text = "";
				this.txtBox_b.Select();
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			MessageBox.Show("Welcome to my Project");
		}
	}
}
