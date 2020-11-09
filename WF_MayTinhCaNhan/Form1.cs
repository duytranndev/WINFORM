using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_MayTinhCaNhan
{
	public partial class Form1 : Form
	{
		//chuyển biểu thức trung tố sang hậu tố rồi đánh giá
		class So
		{
			private double a, b, c;

			public So(double a, double b)
			{
				this.a = a;
				this.b = b;
			}

			public double A { get => a; set => a = value; }
			public double B { get => b; set => b = value; }
			public double C { get => c; set => c = value; }

			public double Sum()
			{
				return c = a + b;
			}
			public double Sub()
			{
				return c = a - b;
			}
			public double Mul()
			{
				return c = a * b;
			}
			public double Div()
			{
				return c = a / b;
			}
		}

		
		public Form1()
		{
			InitializeComponent();
		}

		private void btn_0_click(object sender, EventArgs e)
		{
			this.textBox1.Text = this.textBox1.Text + this.btn_0.Text;
		}

		private void btn_1_click(object sender, EventArgs e)
		{
			this.textBox1.Text = this.textBox1.Text + this.btn_1.Text;
		}

		private void btn_2_click(object sender, EventArgs e)
		{
			this.textBox1.Text = this.textBox1.Text + this.btn_2.Text;
		}

		private void btn_3_click(object sender, EventArgs e)
		{
			this.textBox1.Text = this.textBox1.Text + this.btn_3.Text;
		}

		private void btn_4_click(object sender, EventArgs e)
		{
			this.textBox1.Text = this.textBox1.Text + this.btn_4.Text;
		}

		private void btn_5_click(object sender, EventArgs e)
		{
			this.textBox1.Text = this.textBox1.Text + this.btn_5.Text;
		}

		private void btn_6_click(object sender, EventArgs e)
		{
			this.textBox1.Text = this.textBox1.Text + this.btn_6.Text;
		}

		private void btn_7_click(object sender, EventArgs e)
		{
			this.textBox1.Text = this.textBox1.Text + this.btn_7.Text;
		}

		private void btn_8_click(object sender, EventArgs e)
		{
			this.textBox1.Text = this.textBox1.Text + this.btn_8.Text;
		}

		private void btn_9_click(object sender, EventArgs e)
		{
			this.textBox1.Text = this.textBox1.Text + this.btn_9.Text;
		}

		So Number = new So(0, 0);
		string sig = "";

		private void btn_sum_click(object sender, EventArgs e)
		{
			if (sig == "") Number.A = double.Parse(this.textBox1.Text);
			sig = "+";
			this.textBox1.Clear();
		}

		

		private void btn_sub_click(object sender, EventArgs e)
		{
			if (sig == "") Number.A = double.Parse(this.textBox1.Text);
			sig = "-";
			this.textBox1.Clear();
		}

		private void btn_mul_click(object sender, EventArgs e)
		{
			if (sig == "") Number.A = double.Parse(this.textBox1.Text);
			sig = "*";
			this.textBox1.Clear();
		}

		private void btn_div_click(object sender, EventArgs e)
		{
			if (sig == "") Number.A = double.Parse(this.textBox1.Text);
			sig = "/";
			this.textBox1.Clear();
		}

		private void btn_ce_click(object sender, EventArgs e)
		{
			Number.A = Number.B = 0;
			sig = "";
			this.textBox1.Clear();
		}

		private void btn_equa_click(object sender, EventArgs e)
		{
			Number.B = double.Parse(this.textBox1.Text);
			switch (sig)
			{
				case "+":
					Number.Sum();
					break;
				case "-":
					Number.Sub();
					break;
				case "*":
					Number.Mul();
					break;
				case "/":
					if (Number.B != 0) Number.Div();
					else
					{
						this.textBox1.Text = "Invalid";
						MessageBox.Show("Division by zero !!!"," Invalid Data!",MessageBoxButtons.OK,MessageBoxIcon.Error);
						this.btn_ce_click(this,e);
					}
					break;
			}
			this.textBox1.Text = Number.C.ToString();
		}
	}
}
