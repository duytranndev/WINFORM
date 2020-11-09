using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_Buoi4
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			MessageBox.Show("hê lô thế giới!");
		}

		private void btn_exit_click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btn_call_click(object sender, EventArgs e)
		{
			if(this.rdb_ok.Checked && this.rdb_asterick.Checked)
			{
				MessageBox.Show("Chao cac em sinh vien !!", "C# Programming", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			if (this.rdb_ok.Checked && this.rdb_error.Checked)
			{
				MessageBox.Show("Chao cac em sinh vien !!", "C# Programming", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			if (this.rdb_ok.Checked && this.rdb_exclamtion.Checked)
			{
				MessageBox.Show("Chao cac em sinh vien !!", "C# Programming", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			if (this.rdb_ok.Checked && this.rdb_hand.Checked)
			{
				MessageBox.Show("Chao cac em sinh vien !!", "C# Programming", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			if (this.rdb_ok.Checked && this.rdb_information.Checked)
			{
				MessageBox.Show("Chao cac em sinh vien !!", "C# Programming", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			if (this.rdb_ok.Checked && this.rdb_none.Checked)
			{
				MessageBox.Show("Chao cac em sinh vien !!", "C# Programming", MessageBoxButtons.OK, MessageBoxIcon.None);
			}
			if (this.rdb_ok.Checked && this.rdb_question.Checked)
			{
				MessageBox.Show("Chao cac em sinh vien !!", "C# Programming", MessageBoxButtons.OK, MessageBoxIcon.Question);
			}
			if (this.rdb_ok.Checked && this.rdb_warning.Checked)
			{
				MessageBox.Show("Chao cac em sinh vien !!", "C# Programming", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}

			//---------------------------------------------------------------------------------//

			if (this.rdb_okCancel.Checked && this.rdb_asterick.Checked)
			{
				MessageBox.Show("Chao cac em sinh vien !!", "C# Programming", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
			}
			if (this.rdb_okCancel.Checked && this.rdb_error.Checked)
			{
				MessageBox.Show("Chao cac em sinh vien !!", "C# Programming", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
			}
			if (this.rdb_okCancel.Checked && this.rdb_exclamtion.Checked)
			{
				MessageBox.Show("Chao cac em sinh vien !!", "C# Programming", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
			}
			if (this.rdb_okCancel.Checked && this.rdb_hand.Checked)
			{
				MessageBox.Show("Chao cac em sinh vien !!", "C# Programming", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);
			}
			if (this.rdb_okCancel.Checked && this.rdb_information.Checked)
			{
				MessageBox.Show("Chao cac em sinh vien !!", "C# Programming", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
			}
			if (this.rdb_okCancel.Checked && this.rdb_none.Checked)
			{
				MessageBox.Show("Chao cac em sinh vien !!", "C# Programming", MessageBoxButtons.OKCancel, MessageBoxIcon.None);
			}
			if (this.rdb_okCancel.Checked && this.rdb_question.Checked)
			{
				MessageBox.Show("Chao cac em sinh vien !!", "C# Programming", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
			}
			if (this.rdb_okCancel.Checked && this.rdb_stop.Checked)
			{
				MessageBox.Show("Chao cac em sinh vien !!", "C# Programming", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
			}
			if (this.rdb_okCancel.Checked && this.rdb_warning.Checked)
			{
				MessageBox.Show("Chao cac em sinh vien !!", "C# Programming", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
			}

			//--------------------------------------------------------------------------//

			if (this.rdb_yesNo.Checked && this.rdb_asterick.Checked)
			{
				MessageBox.Show("Chao cac em sinh vien !!", "C# Programming", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
			}
			if (this.rdb_yesNo.Checked && this.rdb_error.Checked)
			{
				MessageBox.Show("Chao cac em sinh vien !!", "C# Programming", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
			}
			if (this.rdb_yesNo.Checked && this.rdb_exclamtion.Checked)
			{
				MessageBox.Show("Chao cac em sinh vien !!", "C# Programming", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
			}
			if (this.rdb_yesNo.Checked && this.rdb_hand.Checked)
			{
				MessageBox.Show("Chao cac em sinh vien !!", "C# Programming", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
			}
			if (this.rdb_yesNo.Checked && this.rdb_information.Checked)
			{
				MessageBox.Show("Chao cac em sinh vien !!", "C# Programming", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
			}
			if (this.rdb_yesNo.Checked && this.rdb_none.Checked)
			{
				MessageBox.Show("Chao cac em sinh vien !!", "C# Programming", MessageBoxButtons.YesNo, MessageBoxIcon.None);
			}
			if (this.rdb_yesNo.Checked && this.rdb_question.Checked)
			{
				MessageBox.Show("Chao cac em sinh vien !!", "C# Programming", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			}
			if (this.rdb_yesNo.Checked && this.rdb_stop.Checked)
			{
				MessageBox.Show("Chao cac em sinh vien !!", "C# Programming", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
			}
			if (this.rdb_yesNo.Checked && this.rdb_warning.Checked)
			{
				MessageBox.Show("Chao cac em sinh vien !!", "C# Programming", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
			}

			//--------------------------------------------------------------------------//

			if (this.rdb_yesNoCancel.Checked && this.rdb_asterick.Checked)
			{
				MessageBox.Show("Chao cac em sinh vien !!", "C# Programming", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Asterisk);
			}
			if (this.rdb_yesNoCancel.Checked && this.rdb_error.Checked)
			{
				MessageBox.Show("Chao cac em sinh vien !!", "C# Programming", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error);
			}
			if (this.rdb_yesNoCancel.Checked && this.rdb_exclamtion.Checked)
			{
				MessageBox.Show("Chao cac em sinh vien !!", "C# Programming", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
			}
			if (this.rdb_yesNoCancel.Checked && this.rdb_hand.Checked)
			{
				MessageBox.Show("Chao cac em sinh vien !!", "C# Programming", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Hand);
			}
			if (this.rdb_yesNoCancel.Checked && this.rdb_information.Checked)
			{
				MessageBox.Show("Chao cac em sinh vien !!", "C# Programming", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
			}
			if (this.rdb_yesNoCancel.Checked && this.rdb_none.Checked)
			{
				MessageBox.Show("Chao cac em sinh vien !!", "C# Programming", MessageBoxButtons.YesNoCancel, MessageBoxIcon.None);
			}
			if (this.rdb_yesNoCancel.Checked && this.rdb_question.Checked)
			{
				MessageBox.Show("Chao cac em sinh vien !!", "C# Programming", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
			}
			if (this.rdb_yesNoCancel.Checked && this.rdb_stop.Checked)
			{
				MessageBox.Show("Chao cac em sinh vien !!", "C# Programming", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Stop);
			}
			if (this.rdb_yesNoCancel.Checked && this.rdb_warning.Checked)
			{
				MessageBox.Show("Chao cac em sinh vien !!", "C# Programming", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
			}

			//--------------------------------------------------------------------------//

			if (this.rdb_retryCancel.Checked && this.rdb_asterick.Checked)
			{
				MessageBox.Show("Chao cac em sinh vien !!", "C# Programming", MessageBoxButtons.RetryCancel, MessageBoxIcon.Asterisk);
			}
			if (this.rdb_retryCancel.Checked && this.rdb_error.Checked)
			{
				MessageBox.Show("Chao cac em sinh vien !!", "C# Programming", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
			}
			if (this.rdb_retryCancel.Checked && this.rdb_exclamtion.Checked)
			{
				MessageBox.Show("Chao cac em sinh vien !!", "C# Programming", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
			}
			if (this.rdb_retryCancel.Checked && this.rdb_hand.Checked)
			{
				MessageBox.Show("Chao cac em sinh vien !!", "C# Programming", MessageBoxButtons.RetryCancel, MessageBoxIcon.Hand);
			}
			if (this.rdb_retryCancel.Checked && this.rdb_information.Checked)
			{
				MessageBox.Show("Chao cac em sinh vien !!", "C# Programming", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
			}
			if (this.rdb_retryCancel.Checked && this.rdb_none.Checked)
			{
				MessageBox.Show("Chao cac em sinh vien !!", "C# Programming", MessageBoxButtons.RetryCancel, MessageBoxIcon.None);
			}
			if (this.rdb_retryCancel.Checked && this.rdb_question.Checked)
			{
				MessageBox.Show("Chao cac em sinh vien !!", "C# Programming", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question);
			}
			if (this.rdb_retryCancel.Checked && this.rdb_stop.Checked)
			{
				MessageBox.Show("Chao cac em sinh vien !!", "C# Programming", MessageBoxButtons.RetryCancel, MessageBoxIcon.Stop);
			}
			if (this.rdb_retryCancel.Checked && this.rdb_warning.Checked)
			{
				MessageBox.Show("Chao cac em sinh vien !!", "C# Programming", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
			}

			//--------------------------------------------------------------------------//

			if (this.rdb_abortRetryIgnore.Checked && this.rdb_asterick.Checked)
			{
				MessageBox.Show("Chao cac em sinh vien !!", "C# Programming", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Asterisk);
			}
			if (this.rdb_abortRetryIgnore.Checked && this.rdb_error.Checked)
			{
				MessageBox.Show("Chao cac em sinh vien !!", "C# Programming", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
			}
			if (this.rdb_abortRetryIgnore.Checked && this.rdb_exclamtion.Checked)
			{
				MessageBox.Show("Chao cac em sinh vien !!", "C# Programming", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Exclamation);
			}
			if (this.rdb_abortRetryIgnore.Checked && this.rdb_hand.Checked)
			{
				MessageBox.Show("Chao cac em sinh vien !!", "C# Programming", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Hand);
			}
			if (this.rdb_abortRetryIgnore.Checked && this.rdb_information.Checked)
			{
				MessageBox.Show("Chao cac em sinh vien !!", "C# Programming", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Information);
			}
			if (this.rdb_abortRetryIgnore.Checked && this.rdb_none.Checked)
			{
				MessageBox.Show("Chao cac em sinh vien !!", "C# Programming", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.None);
			}
			if (this.rdb_abortRetryIgnore.Checked && this.rdb_question.Checked)
			{
				MessageBox.Show("Chao cac em sinh vien !!", "C# Programming", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Question);
			}
			if (this.rdb_abortRetryIgnore.Checked && this.rdb_stop.Checked)
			{
				MessageBox.Show("Chao cac em sinh vien !!", "C# Programming", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Stop);
			}
			if (this.rdb_abortRetryIgnore.Checked && this.rdb_warning.Checked)
			{
				MessageBox.Show("Chao cac em sinh vien !!", "C# Programming", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Warning);
			}

			//--------------------------------------------------------------------------//
		}
	}
}
