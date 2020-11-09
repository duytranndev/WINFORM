using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDIForm
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		SUB_FORM_A Sub_Form_A;
		SUB_FORM_B Sub_Form_B;

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void openSubFormAToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (Sub_Form_A == null)
			{
				Sub_Form_A = new SUB_FORM_A();
				Sub_Form_A.FormClosed += new FormClosedEventHandler(SUB_FORM_A_Form_Closed);
				Sub_Form_A.MdiParent = this;
				Sub_Form_A.Show();
			}
			else Sub_Form_A.Activate();
		}

		private void SUB_FORM_A_Form_Closed(object sender, FormClosedEventArgs e)
		{
			Sub_Form_A = null;
		}

		private void openSubFormBToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (Sub_Form_B == null)
			{
				Sub_Form_B = new SUB_FORM_B();
				Sub_Form_B.FormClosed += new FormClosedEventHandler(SUB_FORM_B_Form_Closed);
				Sub_Form_B.MdiParent = this;
				Sub_Form_B.Show();
			}
			else Sub_Form_B.Activate();
		}

		private void SUB_FORM_B_Form_Closed(object sender, FormClosedEventArgs e)
		{
			Sub_Form_B = null;
		}
	}
}
