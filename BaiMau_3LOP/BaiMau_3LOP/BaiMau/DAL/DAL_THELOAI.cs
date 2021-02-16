using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BaiMau.DAL
{
    class DAL_THELOAI
    {
        LOPDUNGCHUNG lopchung = new LOPDUNGCHUNG();
        public DataTable LayBangTheLoai()
        {
            string sql = "Select * from THELOAI";
            return lopchung.LoadDL(sql);
        }
    }
}
