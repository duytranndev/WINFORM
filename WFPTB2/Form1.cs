using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFPTB2
{
	public partial class Form1 : Form
	{
		class PhuongTrinh
		{
			private double a, b, c, x1, x2, x, delta;

			public PhuongTrinh(double a, double b, double c)
			{
				this.A = a;
				this.B = b;
				this.C = c;
			}

			public double A { get => a; set => a = value; }
			public double B { get => b; set => b = value; }
			public double C { get => c; set => c = value; }
			public double X1 { get => x1; set => x1 = value; }
			public double X2 { get => x2; set => x2 = value; }
			public double X { get => x; set => x = value; }
			public double Delta { get => delta; set => delta = value; }

			public int GiaiPt()
			{
				if (this.a == 0)
				{
					if (this.b == 0)
					{
						if (this.c == 0)
						{
							return 0;
						}
						else
						{
							return 1;
						}
					}
					else
					{
						this.x = -this.c / this.b;
						return 2;
					}
				}
				else
				{
					double delta;
					delta = Math.Pow(b, 2) - 4 * a * c;
					if(delta < 0)
					{
						this.delta = Math.Sqrt(-delta);
						return 3;
					}
					else if (delta == 0)
					{
						this.x1 = this.x2 = -this.b / (2 * this.a);
						return 4;
					}
					else
					{
						x1 = (-b + Math.Sqrt(delta)) / (2 * a);
						x2 = (-b - Math.Sqrt(delta)) / (2 * a);
						return 5;
					}
				}
				
			}
		}
		PhuongTrinh P = new PhuongTrinh(0, 0, 0);
		public Form1()
		{
			InitializeComponent();
		}

		
		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void btn_Run_Click(object sender, EventArgs e)
		{
			double a = 0, b = 0, c = 0;
			int signal = 0;
			try
			{
				a = double.Parse(this.txt_a.Text);
			}
			catch (System.Exception)
			{
				MessageBox.Show("TextBpx a empty Data");
				this.txt_a.Select();
			}

			try
			{
				b = double.Parse(this.txt_b.Text);
			}
			catch (System.Exception)
			{
				MessageBox.Show("TextBpx b empty Data");
				this.txt_b.Select();
			}

			try
			{
				c= double.Parse(this.txt_c.Text);
			}
			catch (System.Exception)
			{
				MessageBox.Show("TextBpx c empty Data");
				this.txt_c.Select();
			}
			P.A = a;
			P.B = b;
			P.C = c;
			signal = P.GiaiPt();
			switch (signal)
			{
				case 0:
					MessageBox.Show("phuong trinh vo so nghiem!!");
					btn_Reset_Click(this, e);
					break;
				case 1:
					MessageBox.Show("phuong trinh vo nghiem");
					btn_Reset_Click(this, e);
					break;
				case 2:
					this.txt_x.Text = P.X.ToString();
					break;
				case 3:
					MessageBox.Show("phuong trinh co nghiem phuc: ");
					double real = -(P.B / (2 * P.A));
					double imgainary = (P.Delta / (2 * P.A));
					this.txt_x1.Text = real.ToString();
					this.txt_x1.Text = this.txt_x1.Text + "+i." + imgainary.ToString();
					this.txt_x2.Text = real.ToString();
					this.txt_x2.Text = this.txt_x2.Text + "-i." + imgainary.ToString();
					break;
				case 4:
					MessageBox.Show("Phuong trinh co nghiem kep: ");
					this.txt_x1.Text = this.txt_x2.Text = (-(P.B / (2 * P.A))).ToString();
					break;
				case 5:
					this.txt_x1.Text = P.X1.ToString();
					this.txt_x2.Text = P.X2.ToString();
					break;
			}
		}

		private void btn_Reset_Click(object sender, EventArgs e)
		{
			this.txt_a.Text = this.txt_c.Text = this.txt_c.Text = "";
			this.txt_x.Text = this.txt_x1.Text = this.txt_x2.Text = "";
		}

		private void btn_Click_Exit(object sender, EventArgs e)
		{
			this.Close();
		}

		private void txt_a_Leave(object sender, EventArgs e)
		{
			try
			{
				double.Parse(txt_a.Text);
			}
			catch (System.Exception)
			{
				MessageBox.Show("Invalid data in textbox a");
				this.txt_a.Text = "";
				this.txt_a.Select();
			}
		}

		private void txt_b_Leave(object sender, EventArgs e)
		{
			try
			{
				double.Parse(txt_b.Text);
			}
			catch (System.Exception)
			{
				MessageBox.Show("Invalid data in textbox b");
				this.txt_b.Text = "";
				this.txt_b.Select();
			}
		}

		private void txt_c_Leave(object sender, EventArgs e)
		{
			try
			{
				double.Parse(txt_c.Text);
			}
			catch (System.Exception)
			{
				MessageBox.Show("Invalid data in textbox c");
				this.txt_c.Text = "";
				this.txt_c.Select();
			}
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}
	}
}
