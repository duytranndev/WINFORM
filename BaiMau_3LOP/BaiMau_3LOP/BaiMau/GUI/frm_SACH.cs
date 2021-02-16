using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiMau.GUI
{
    public partial class frm_SACH : Form
    {
        BLL.BLL_THELOAI theloai;
        BLL.BLL_SACH sach;
        public frm_SACH()
        {
            theloai = new BLL.BLL_THELOAI(this);
            sach = new BLL.BLL_SACH(this);
            InitializeComponent();
        }
        public void LoadSach()
        {
            sach.LoadSach();
        }

        private void frm_SACH_Load(object sender, EventArgs e)
        {
            theloai.BangTheLoai();
            LoadSach();
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            sach.ThemSach();
            LoadSach();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            sach.XoaSach();
            LoadSach();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            sach.SuaSach();
            LoadSach();
        }
    }
}
