using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace QUAN_LY_HANG
{
    public partial class MATHANG : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Winforms\QUAN_LY_HANG\QUAN_LY_HANG\Quan_Ly_Hang.mdf;Integrated Security=True");
        string view_hang = "select * from MATHANG";
        public MATHANG(Form1 form1)
        {
            InitializeComponent();
            ViewDaTa(view_hang);
        }
        private void Execute_Query(string query)
        {
            conn.Close();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception)
            {
                conn.Close();
            }
        }
        private void ViewDaTa(string sql)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            dataGridView1.DataSource = dt;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            string query = "insert into MATHANG (ma_hang, ten_hang, ngay_vao_kho) values (@ma_hang, @ten_hang, @ngay_vao_kho)";
            SqlCommand cmd = new SqlCommand(query,conn);

            SqlParameter ma_hang = new SqlParameter();
            ma_hang.ParameterName = "@ma_hang";
            ma_hang.Value = txt_mahang.Text;

            SqlParameter ten_hang = new SqlParameter();
            ten_hang.ParameterName = "@ten_hang";
            ten_hang.Value = txt_tenhang.Text;

            SqlParameter ngay_vao_kho = new SqlParameter();
            ngay_vao_kho.ParameterName = "@ngay_vao_kho";
            ngay_vao_kho.Value = txt_ngayvaokho.Text;

            cmd.Parameters.Add(ma_hang);
            cmd.Parameters.Add(ten_hang);
            cmd.Parameters.Add(ngay_vao_kho);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("them thanh cong");
                ViewDaTa(view_hang);
            }
            catch (Exception)
            {
                MessageBox.Show("them that bai");
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string key = txt_mahang.Text;
            string sql = "select ma_hang from MATHANG where ma_hang='" + key + "'";
            if(MessageBox.Show("Ban co chan chan muon xoa?","C# pro",MessageBoxButtons.OKCancel,MessageBoxIcon.Question).ToString() == "OK")
            {
                Execute_Query("delete MATHANG where ma_hang='" + key + "'");
                MessageBox.Show("xoa thanh cong");
                ViewDaTa(view_hang);
            }
            else
            {
                MessageBox.Show("xoa that bai");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_mahang.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
            txt_tenhang.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
            txt_ngayvaokho.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string query = "update MATHANG set ten_hang= @ten_hang, ngay_vao_kho = @ngay_vao_kho where ma_hang= @ma_hang";
            SqlCommand cmd = new SqlCommand(query,conn);

            SqlParameter ma_hang = new SqlParameter();
            ma_hang.ParameterName = "@ma_hang";
            ma_hang.Value = txt_mahang.Text;

            SqlParameter ten_hang = new SqlParameter();
            ten_hang.ParameterName = "@ten_hang";
            ten_hang.Value = txt_tenhang.Text;

            SqlParameter ngay_vao_kho = new SqlParameter();
            ngay_vao_kho.ParameterName = "@ngay_vao_kho";
            ngay_vao_kho.Value = txt_ngayvaokho.Text;

            cmd.Parameters.Add(ma_hang);
            cmd.Parameters.Add(ten_hang);
            cmd.Parameters.Add(ngay_vao_kho);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Sua thanh cong");
                ViewDaTa(view_hang);
            }
            catch (Exception)
            {
                MessageBox.Show("Sua that bai");
            }
        }
    }
}
