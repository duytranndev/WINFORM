using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUAN_LY_HANG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void nHÀCUNGCẤPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NHACUNGCAP nhaCungCap = new NHACUNGCAP(this);
            nhaCungCap.Show();
            this.Hide();
        }

        private void mẶTHÀNGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MATHANG matHang = new MATHANG(this);
            matHang.Show();
            this.Hide();
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
