using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace KT_GIUAKY
{
    public partial class NCC : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Winforms\KT_GIUAKY\KT_GIUAKY\QLVT.mdf;Integrated Security=True");
        string view_ncc = "select * from NCC";
        public NCC(MAIN_FORM mAIN_FORM)
        {
            InitializeComponent();
            ViewNCC(view_ncc);
        }
        private void Execute(string query)
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
                MessageBox.Show("ERROR");
                conn.Close();
            }
        }
        private void ViewNCC(string sql)
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
            string query = "insert into NCC (ma_ncc, ten_ncc) values (@ma_ncc, @ten_ncc)";
            SqlCommand cmd = new SqlCommand(query,conn);

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
                MessageBox.Show("Them thanh cong");
                conn.Close();
                ViewNCC(view_ncc);

            }
            catch (Exception)
            {
                MessageBox.Show("Them that bai");
                conn.Close();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string key = txt_mancc.Text;
            if (MessageBox.Show("Ban co chac chan?", "C#", MessageBoxButtons.OKCancel, MessageBoxIcon.Question).ToString() == "OK")
            {
                Execute("delete NCC where ma_ncc='" + key + "'");
                MessageBox.Show("Xoa thanh cong");
                ViewNCC(view_ncc);
            }
            else
            {
                MessageBox.Show("Xoa that bai");
            }
        }
        private void btn_sua_Click(object sender, EventArgs e)
        {
            string query = "update NCC set ten_ncc = @ten_ncc where ma_ncc = @ma_ncc";
            SqlCommand cmd = new SqlCommand(query, conn);

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
                MessageBox.Show("Sua thanh cong");
                conn.Close();
                ViewNCC(view_ncc);

            }
            catch (Exception)
            {
                MessageBox.Show("Sua that bai");
                conn.Close();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_mancc.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
            txt_tenncc.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
