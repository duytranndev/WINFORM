using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanTri_QuanLyNhanVien
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btb_login_Click(object sender, EventArgs e)
		{
			Main_Form main_Form = new Main_Form(this);
			if (this.txt_user.Text.ToUpper() == "admin".ToUpper() && this.txt_pass.Text.ToUpper() == "duy".ToUpper())
			{
				main_Form.admin = 1;
			}
			else if (this.txt_user.Text.ToUpper() == "123".ToUpper() && this.txt_pass.Text.ToUpper() == "123".ToUpper())
			{
				main_Form.admin = 0;
			}
			else this.btn_cancel_Click(this,e);
			main_Form.Show();
			this.Hide();
		}

		private void btn_cancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
