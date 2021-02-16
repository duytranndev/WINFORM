using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiMau.BLL
{
    class BLL_SACH
    {
        DAL.DAL_SACH dalsach = new DAL.DAL_SACH();
        GUI.frm_SACH sach;
        public BLL_SACH(GUI.frm_SACH f)
        {
            sach = f;
        }
        public void LoadSach()
        {
            sach.dataGridView1.DataSource = dalsach.LoadSach();

        }
        public void ThemSach()
        {
            int ketqua = dalsach.ThemSach(sach.txt_MaSach.Text,sach.cb_TheLoai.SelectedValue.ToString(),sach.txt_TenSach.Text,sach.txt_SoTrang.Text,sach.txt_TomTat.Text,sach.txt_HinhAnh.Text);
            if (ketqua >= 1)
                MessageBox.Show("Thêm thành công");
            else MessageBox.Show("Thêm thất bai");
        }
        public void SuaSach()
        {
            int ketqua = dalsach.SuaSach(sach.txt_MaSach.Text, sach.cb_TheLoai.SelectedValue.ToString(), sach.txt_TenSach.Text, sach.txt_SoTrang.Text, sach.txt_TomTat.Text, sach.txt_HinhAnh.Text);
            if (ketqua >= 1)
                MessageBox.Show("Sua thành công");
            else MessageBox.Show("Sua thất bai");
        }
        public void XoaSach()
        {
            int ketqua = dalsach.XoaSach(sach.txt_MaSach.Text);
            if (ketqua >= 1)
                MessageBox.Show("Xóa thành công");
            else MessageBox.Show("Xóa thất bai");
        }
    }
}
