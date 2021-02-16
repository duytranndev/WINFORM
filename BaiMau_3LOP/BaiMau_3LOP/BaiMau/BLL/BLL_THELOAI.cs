using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BaiMau.BLL
{
    class BLL_THELOAI
    {
        DAL.DAL_THELOAI theloai = new DAL.DAL_THELOAI();
        GUI.frm_SACH sach;
        public BLL_THELOAI(GUI.frm_SACH f)
        {
            sach = f;
        }
        public void  BangTheLoai()
        {
            sach.cb_TheLoai.DataSource = theloai.LayBangTheLoai();
            sach.cb_TheLoai.DisplayMember = "TENTHELOAI";
            sach.cb_TheLoai.ValueMember = "MATHELOAI";
        }
    }
}
