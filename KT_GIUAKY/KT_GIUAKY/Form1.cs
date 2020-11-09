using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KT_GIUAKY
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if(txt_user.Text.ToString().ToUpper() == "admin".ToUpper() && txt_pass.Text.ToString().ToUpper() == "admin".ToUpper())
            {
                MAIN_FORM main = new MAIN_FORM(this);
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai ten dang nhap hoac mat khau");
            }
        }

        private void txt_user_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                this.btn_login_Click(sender, e);
            }
        }

        private void txt_pass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                this.btn_login_Click(sender, e);
            }
        }
    }
}
