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
    public partial class GIANGVIEN : Form
    {
        
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Winforms\HETHONG\HETHONG\HeThong.mdf;Integrated Security=True");
        string view_giangvien = "select * from GIANGVIEN";
        

        public GIANGVIEN(Main_Form main_Form)
        {
            InitializeComponent();
            ViewDB(view_giangvien);
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
            SqlCommand cmd = new SqlCommand("themGV", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            //
            SqlParameter magv = new SqlParameter("@magv", SqlDbType.NVarChar);
            magv.Value = txt_magv.Text;
            SqlParameter tengv = new SqlParameter("@tengv", SqlDbType.NVarChar);
            tengv.Value = txt_tengv.Text;
            SqlParameter ngaysinh = new SqlParameter("@ngaysinh", SqlDbType.NVarChar);
            ngaysinh.Value = txt_namsinh.Text;
            cmd.Parameters.Add(magv);
            cmd.Parameters.Add(tengv);
            cmd.Parameters.Add(ngaysinh);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                ViewDB(view_giangvien);
            }
            catch (Exception)
            {
                MessageBox.Show("them that bai");
                conn.Close();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string key = txt_magv.Text;
            try
            {
                if(MessageBox.Show("ban co muon xoa?","C#",MessageBoxButtons.OKCancel,MessageBoxIcon.Question).ToString() == "OK")
                {
                    Execute("delete from GIANGVIEN where magv='" + key + "'");
                    ViewDB(view_giangvien);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("xoa that bai");
               
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("suaGV", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            //
            SqlParameter magv = new SqlParameter("@magv", SqlDbType.NVarChar);
            magv.Value = txt_magv.Text;
            SqlParameter tengv = new SqlParameter("@tengv", SqlDbType.NVarChar);
            tengv.Value = txt_tengv.Text;
            SqlParameter ngaysinh = new SqlParameter("@ngaysinh", SqlDbType.NVarChar);
            ngaysinh.Value = txt_namsinh.Text;
            cmd.Parameters.Add(magv);
            cmd.Parameters.Add(tengv);
            cmd.Parameters.Add(ngaysinh);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                ViewDB(view_giangvien);
            }
            catch (Exception)
            {
                MessageBox.Show("sua that bai");
                conn.Close();
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_magv.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
            txt_tengv.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
            txt_namsinh.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();

        }
    }
}
