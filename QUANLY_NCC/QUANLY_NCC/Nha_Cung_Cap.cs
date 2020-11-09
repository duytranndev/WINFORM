using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace QUANLY_NCC
{
    public partial class Nha_Cung_Cap : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Winforms\QUANLY_NCC\QUANLY_NCC\QuanLyHang.mdf;Integrated Security=True");
        string sql, key;
        string sql_view_ncc = "select * from NHACUNGCAP";
        public Nha_Cung_Cap()
        {
            InitializeComponent();
            sql = "select * from NHACUNGCAP";
            ViewDB(sql);
        }
        public void ViewDB(string sql)
        {

            conn.Open();
            SqlCommand command = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            dataGridView1.DataSource = dt;
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("them", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            //dua tham so vao cmd
            SqlParameter mancc = new SqlParameter("@MA_NCC", SqlDbType.NVarChar);
            mancc.Value = this.txt_mancc.Text;
            SqlParameter tenncc = new SqlParameter("@TEN_NCC", SqlDbType.NVarChar);
            tenncc.Value = this.txt_tenncc.Text;
            SqlParameter diachi = new SqlParameter("@DIA_CHI", SqlDbType.NVarChar);
            diachi.Value = this.txt_diachi.Text;
            SqlParameter sdt = new SqlParameter("@SO_DIEN_THOAI", SqlDbType.NVarChar);
            sdt.Value = this.txt_sodienthoai.Text;
            cmd.Parameters.Add(mancc);
            cmd.Parameters.Add(tenncc);
            cmd.Parameters.Add(diachi);
            cmd.Parameters.Add(sdt);

            //thi hanh` procedure
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                ViewDB(sql_view_ncc);
            }
            catch (Exception)
            {
                MessageBox.Show("Trung khoa");
                conn.Close();
            }
        }
    }
}
