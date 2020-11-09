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

namespace SINHVIEN
{
    public partial class MainForm : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Winforms\SINHVIEN\SINHVIEN\SinhVien.mdf;Integrated Security=True");
        string sql, str;
        string sql_view = "select * from SinhVien";
        public MainForm(Form1 form1)
        {
            InitializeComponent();
            ViewDB(sql_view);
        }
        private bool Check_Key(string sql,string key)
        {
            bool ok = false;
            
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand(sql, conn);
                SqlDataReader data = command.ExecuteReader();
                if(data.Read() && data.GetString(0).ToUpper() == "key".ToUpper())
                {
                    ok = true;
                    conn.Close();
                }
            }
            catch(Exception)
            {
                MessageBox.Show("error");
                conn.Close();
            }
            return ok;
        }

        private void Execute(string query)
        {
            conn.Close();
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand(query, conn);
                command.ExecuteNonQuery();
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
            
            SqlCommand cmd = new SqlCommand("them", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            //dua tham so vao cmd
            SqlParameter masv = new SqlParameter("@MASV", SqlDbType.NVarChar);
            masv.Value = this.txt_masv.Text;
            SqlParameter tensv = new SqlParameter("@TENSV", SqlDbType.NVarChar);
            tensv.Value = this.txt_tensv.Text;
            cmd.Parameters.Add(masv);
            cmd.Parameters.Add(tensv);

            //thi hanh` procedure
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                ViewDB(sql_view);
            }
            catch (Exception)
            {
                MessageBox.Show("Trung khoa");
                conn.Close();
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string key = txt_masv.Text;
            try
            {
                if(MessageBox.Show("Ban co chac chan muon xoa?","VN no1",MessageBoxButtons.OKCancel,MessageBoxIcon.Question).ToString() == "OK")
                {
                    Execute("delete from sinhvien where masv='" + key + "'");
                    ViewDB(sql_view);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Xoa that bai");
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_masv.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
            txt_tensv.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            //dua tham so vao cmd
            SqlParameter masv = new SqlParameter("@MASV", SqlDbType.NVarChar);
            masv.Value = this.txt_masv.Text;
            SqlParameter tensv = new SqlParameter("@TENSV", SqlDbType.NVarChar);
            tensv.Value = this.txt_tensv.Text;
            cmd.Parameters.Add(masv);
            cmd.Parameters.Add(tensv);

            //thi hanh` procedure
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                ViewDB(sql_view);
            }
            catch (Exception)
            {
                MessageBox.Show("sua that bai");
                conn.Close();
            }
        }

        private void ViewDB(string sql)
        {
            conn.Open();
            SqlCommand command = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            dataGridView1.DataSource = dt;
        }
    }
}
