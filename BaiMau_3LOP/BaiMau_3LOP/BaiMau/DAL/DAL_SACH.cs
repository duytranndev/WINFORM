using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BaiMau.DAL
{
    class DAL_SACH
    {
        LOPDUNGCHUNG lopchung = new LOPDUNGCHUNG();
        public int ThemSach(string masach, string matheloai, string tensach, string sotrang, string tomtat, string hinhanh)
        {
            string sql = "Insert into SACH values ('"+masach+"','"+matheloai+"','"+tensach+"','"+sotrang+"','"+tomtat+"','"+hinhanh+"')";
            return lopchung.ThemXoaSua(sql);
        }
        public int XoaSach(string masach)
        {
            string sql = "Delete from SACH where MASACH = '" + masach + "'";
            return lopchung.ThemXoaSua(sql);
        }
        public int SuaSach(string masach, string matheloai, string tensach, string sotrang, string tomtat, string hinhanh)
        {
            string sql = "UPDATE SACH set MATHELOAI = '" + matheloai + "',TENSACH = '" + tensach + "',SOTRANG = '" + sotrang + "',TOMTAT = '" + tomtat + "',HINHANH = '" + hinhanh + "'where MASACH = '" + masach + "'";
            return lopchung.ThemXoaSua(sql);
        }
        public DataTable LoadSach()
        {
            string sql = "Select * from SACH";
            return lopchung.LoadDL(sql);
        }
    }
}
