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

namespace HETHONG
{
    public partial class KHOA : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Winforms\HETHONG\HETHONG\HeThong.mdf;Integrated Security=True");
        string view_khoa = "select * from KHOA";
        

        public KHOA(Main_Form main_Form)
        {
            InitializeComponent();
            ViewDB(view_khoa);
        }

        public void ViewDB(string sql)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            dataGridView1.DataSource = dt;
        }
        public void Execute(string query)
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
                MessageBox.Show("Error");
                conn.Close();
            }
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("themKhoa",conn);
            cmd.CommandType = CommandType.StoredProcedure;
            //dua tham so vao cmd
            SqlParameter makhoa = new SqlParameter("@makhoa", SqlDbType.NVarChar);
            makhoa.Value = txt_makhoa.Text;
            SqlParameter tenkhoa = new SqlParameter("@tenkhoa", SqlDbType.NVarChar);
            tenkhoa.Value = txt_tenkhoaa.Text;
            cmd.Parameters.Add(makhoa);
            cmd.Parameters.Add(tenkhoa);

            //thi hanh

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                ViewDB(view_khoa);
            }
            catch (Exception)
            {
                MessageBox.Show("trung khoa");
                conn.Close();
            }

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string key = txt_makhoa.Text;
            try
            {
                if(MessageBox.Show("ban co muon xoa?","C#",MessageBoxButtons.OKCancel,MessageBoxIcon.Question).ToString() == "OK")
                {
                    Execute("delete from KHOA where makhoa='" + key + "'");
                    ViewDB(view_khoa);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Xoa that bai");
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("suaKhoa", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter makhoa = new SqlParameter("@makhoa", SqlDbType.NVarChar);
            makhoa.Value = txt_makhoa.Text;
            SqlParameter tenkhoa = new SqlParameter("@tenkhoa", SqlDbType.NVarChar);
            tenkhoa.Value = txt_tenkhoaa.Text;

            cmd.Parameters.Add(makhoa);
            cmd.Parameters.Add(tenkhoa);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                ViewDB(view_khoa);
            }
            catch (Exception)
            {
                MessageBox.Show("Xoa that bai");
                conn.Close();
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_makhoa.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
            txt_tenkhoaa.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
        }
    }
}
