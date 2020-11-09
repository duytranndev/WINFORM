using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HETHONG
{
    public partial class Main_Form : Form
    {
        public Main_Form(Form1 form1)
        {
            InitializeComponent();
        }

        private void khoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KHOA khoa = new KHOA(this);
            khoa.Show();
            this.Hide();
        }

        private void giangVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GIANGVIEN giangvien = new GIANGVIEN(this);
            giangvien.Show();
            this.Hide();
        }
    }
}
