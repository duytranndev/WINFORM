using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SINHVIEN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if(txt_user.Text.ToString().ToUpper()=="admin".ToUpper() && txt_pass.Text.ToString().ToUpper() == "admin".ToUpper())
            {
                MainForm mainForm = new MainForm(this);
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Dang nhap that bai");
            }
        }
    }
}
