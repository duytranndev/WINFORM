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

namespace KiemTra
{
    public partial class QuanLyHocTap : Form
    {
        public static SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Winforms\KiemTra\KiemTra\KiemTra\App_Data\VT.mdf;Integrated Security=True");
        string str, sql_view;
        private Form1 Form1;
        public QuanLyHocTap(Form1 form1)
        {

			InitializeComponent();
            string sql = "SELECT * FROM VT";
            View_DataBase(sql);
        }

        

        private void View_DataBase(string sql)
        {
            try
            {
                connect.Open();
                SqlCommand sqlCommand = new SqlCommand(sql, connect);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable data = new DataTable();
                dataAdapter.Fill(data);
                connect.Close();
                this.dataGridView1.DataSource = data;
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR!! day la bi sai o View Database");
            }
        }

        private void Execute_Query(string query)
        {
            try
            {
                connect.Open();
                SqlCommand command = new SqlCommand(query, connect);
                command.ExecuteNonQuery();
                connect.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("error day bi sai o Execute");
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string key = this.txt_masv.Text;
            string sql = "SELECT MaSv FROM VT WHERE MaSv='" + key + "'";
            if (this.txt_masv.Text != "" && Check_Key(sql, key))
            {
                string query = "UPDATE SINHVIEN SET TenSinhVien ='" + this.txt_tensv.Text
                    + "',NgaySinh='" + this.txt_ngaysinh.Text
                    + "',Diem='" + this.txt_diem.Text
                    + "'WHERE (MaSinhVien ='" + this.txt_masv.Text + "')";
                Execute_Query(query);
                sql_view = "SELECT * FROM VT";
                View_DataBase(sql_view);
            }
            else
            {
                MessageBox.Show("Khoa rong hoac trung", "Kiem tra lai khoa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {

        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txt_masv.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
            this.txt_tensv.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
            this.txt_ngaysinh.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
            this.txt_diem.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value.ToString();
        }

        private bool Check_Key(string sql, string key)
        {
            bool ok = false;
            try
            {
                connect.Open();
                SqlCommand command = new SqlCommand(sql, connect);
                SqlDataReader data = command.ExecuteReader();
                if (data.Read() && (data.GetString(0).ToUpper() == key.ToUpper()))
                {
                    ok = true;
                }
                connect.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("error day la bi sai o check key");
            }
            return ok;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            
            string key = this.txt_masv.Text;
            string sql = "SELECT MaSv FROM VT WHERE MaSv ='" + key + "'";

            if (this.txt_masv.Text != "" && !Check_Key(sql, key))
            {
                string query = "insert into VT values('"
                    + this.txt_masv.Text + "','"
                    + this.txt_tensv.Text + "','"
                    + this.txt_ngaysinh.Text + "','"
                    + this.txt_diem.Text + "')";
                Execute_Query(query);
                sql = "SELECT * FROM VT";
                View_DataBase(sql);
            }
            else
            {
                MessageBox.Show("Khoa rong hoac trung", "Kiem tra lai khoa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                    
        }

        
    }
}
