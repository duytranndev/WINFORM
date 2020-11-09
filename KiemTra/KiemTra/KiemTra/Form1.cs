using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KiemTra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_ok(object sender, EventArgs e)
        {
            if (this.txt_user.Text.ToUpper() == "admin".ToUpper() && this.txt_pass.Text.ToUpper() == "duy".ToUpper())
            {
                QuanLyHocTap QuanLyHocTap = new QuanLyHocTap(this);
                QuanLyHocTap.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Mời bạn nhập lại thông tin đăng nhập");
            }
        }

        private void btn_exit(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
