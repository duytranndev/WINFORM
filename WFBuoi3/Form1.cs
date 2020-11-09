using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFBuoi3
{
	public partial class Form1 : Form
	{
		Internet I = new Internet(0, 0, 0, 0);

		public Form1()
		{
			InitializeComponent();
		}

		

		private void btn_run_click(object sender, EventArgs e)
		{
			I.Get_money();
			this.txt_money.Text = I.Money.ToString() + " đồng";
			this.txt_time_access.Text = I.Sum_time_hour.ToString() + ":" + I.Sum_time_minus.ToString();
		}

		private void btn_reset_click(object sender, EventArgs e)
		{
			txt_money.Clear();
			txt_time_access.Clear();
			txt_time_begin.Clear();
			txt_time_end.Clear();
		}

		private void btn_exit_click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void txt_time_begin_Leave(object sender, EventArgs e)
		{
			if(this.txt_time_begin.Text.Length==5 && this.txt_time_begin.Text.IndexOf(":") == 2)
			{
				try
				{
					I.Hour_begin = int.Parse(this.txt_time_begin.Text.Substring(0, 2));
					I.Minus_begin = int.Parse(this.txt_time_begin.Text.Substring(3));
					if(I.Hour_begin>24 || I.Hour_begin<0 || I.Minus_begin>60 || I.Minus_begin < 0)
					{
						MessageBox.Show("invalid data in textbox begin hour !");
						this.txt_time_begin.Text = "";
						this.txt_time_begin.Select();
					}
				}
				catch (System.Exception)
				{
					MessageBox.Show("invalid data in textbox begin hour!");
					this.txt_time_begin.Text = "";
					this.txt_time_begin.Select();
				}
			}
			else
			{
				MessageBox.Show("Invalid data in textbox begin hour !!");
				this.txt_time_begin.Text = "";
				this.txt_time_begin.Select();
			}
		}

		private void txt_time_end_Leave(object sender, EventArgs e)
		{
			if (this.txt_time_end.Text.Length == 5 && this.txt_time_end.Text.IndexOf(":") == 2)
			{
				try
				{
					I.Hour_end = int.Parse(this.txt_time_begin.Text.Substring(0, 2));
					I.Minus_end = int.Parse(this.txt_time_begin.Text.Substring(3));
					if (I.Hour_end > 24 || I.Hour_end < 0 || I.Minus_end > 60 || I.Minus_end < 0)
					{
						MessageBox.Show("invalid data in textbox end hour !");
						this.txt_time_end.Text = "";
						this.txt_time_end.Select();
					}
				}
				catch (System.Exception)
				{
					MessageBox.Show("invalid data in textbox end hour!");
					this.txt_time_end.Text = "";
					this.txt_time_end.Select();
				}
			}
			else
			{
				MessageBox.Show("Invalid data in textbox end hour !!");
				this.txt_time_end.Text = "";
				this.txt_time_end.Select();
			}
		}
	}
}
