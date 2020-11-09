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
    public partial class NHACUNGCAP : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Winforms\QUAN_LY_HANG\QUAN_LY_HANG\Quan_Ly_Hang.mdf;Integrated Security=True");
        string view_ncc = "select * from NHACUNGCAP";
        public NHACUNGCAP(Form1 form1)
        {
            InitializeComponent();
            ViewDaTa(view_ncc);
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
            catch (Exception) {
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
            SqlCommand cmd = new SqlCommand("insert into NHACUNGCAP (ma_ncc, ten_ncc) values (@ma_ncc, @ten_ncc)", conn);
            
            SqlParameter ma_ncc = new SqlParameter();
            ma_ncc.ParameterName = "@ma_ncc";
            ma_ncc.Value = txt_mancc.Text;

            SqlParameter ten_ncc = new SqlParameter();
            ten_ncc.ParameterName = "@ten_ncc";
            ten_ncc.Value = txt_tenncc.Text;

            cmd.Parameters.Add(ma_ncc);
            cmd.Parameters.Add(ten_ncc);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Them thanh cong");
                ViewDaTa(view_ncc);
            }
            catch (Exception)
            {
                MessageBox.Show("Them that bai");
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update NHACUNGCAP set ten_ncc= @ten_ncc where ma_ncc= @ma_ncc",conn);

            SqlParameter ma_ncc = new SqlParameter();
            ma_ncc.ParameterName = "@ma_ncc";
            ma_ncc.Value = txt_mancc.Text;

            SqlParameter ten_ncc = new SqlParameter();
            ten_ncc.ParameterName = "@ten_ncc";
            ten_ncc.Value = txt_tenncc.Text;

            cmd.Parameters.Add(ma_ncc);
            cmd.Parameters.Add(ten_ncc);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("sua thanh cong");
                ViewDaTa(view_ncc);
            }
            catch (SqlException)
            {
                MessageBox.Show("Sua that bai, Vui long ko thay doi ma ncc");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_mancc.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
            txt_tenncc.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string key = txt_mancc.Text;
            string sql = "select ma_ncc from NHACUNGCAP where ma_ncc='"+key+"'";
            if(MessageBox.Show("Ban co chac chan muon xoa?","C# pro",MessageBoxButtons.OKCancel,MessageBoxIcon.Question).ToString() == "OK")
            {
                Execute_Query("delete NHACUNGCAP where ma_ncc='" + key+ "'");
                MessageBox.Show("xoa thanh cong");
                ViewDaTa(view_ncc);
            }
            else
            {
                MessageBox.Show("xoa that bai");
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
