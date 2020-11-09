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

namespace Form_QuanLySinhVien
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			string sql = "select * from SINHVIEN";
			View_database(sql);
		}
		public static SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Winforms\Form_QuanLySinhVien\Form_QuanLySinhVien\App_Data\SINHVIEN.mdf;Integrated Security=True");
		string str, sql_view, path_image;
		private void View_database(string sql)
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
				MessageBox.Show("Error");
			}
		}
		private void Form1_Load(object sender, EventArgs e)
		{

		}
		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			this.txt_masv.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
			this.txt_tensv.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
			this.txt_diachi.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
			this.txt_gioitinh.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value.ToString();
			this.txt_diem.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value.ToString();

		}

		private bool CheckKey(string sql, string key)
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
				MessageBox.Show("error");
			}
			return ok;
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
				MessageBox.Show("error");
			}
		}

		private void btn_them_click(object sender, EventArgs e)
		{
			string key = this.txt_masv.Text;
			string sql = "SELECT MaSinhVien FROM SINHVIEN WHERE MaSinhVien='" + key + "'";
			if (this.txt_masv.Text != "" && !CheckKey(sql, key))
			{
				string query = "insert into SINHVIEN values('"
					+ this.txt_masv.Text + "','"
					+ this.txt_tensv.Text + "','"
					+ this.txt_diachi.Text + "','"
					+ this.txt_gioitinh.Text + "','";
				Execute_Query(query);
				sql = "SELECT * FROM SINHVIEN";
				View_database(sql);
			}
			else
			{
				MessageBox.Show("Khoa rong hoac trung", "Kiem tra lai khoa", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}

		}

		private void btn_thoat_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btn_xoa_Click(object sender, EventArgs e)
		{
			string key = this.txt_masv.Text;
			try
			{
				if (MessageBox.Show("Ban co chac chan xoa ban ghi nay?", "C#",
					MessageBoxButtons.OKCancel, MessageBoxIcon.Question).ToString() == "OK")
				{
					Execute_Query(@"DELETE FROM SINHVIEN WHERE (MaSinhVien = '" + key + "')");
					sql_view = "SELECT * FROM SINHVIEN";
					View_database(sql_view);
				}
			}
			catch (Exception)
			{
				MessageBox.Show("error");
			}
		}

		private void btn_sua_Click(object sender, EventArgs e)
		{
			string key = this.txt_masv.Text;
			string sql = "SELECT MaSinhVien FROM SINHVIEN WHERE MaSinhVien='" + key + "'";
			if (this.txt_masv.Text != "" && CheckKey(sql, key))
			{
				string query = "UPDATE SINHVIEN SET TenSinhVien ='" + this.txt_tensv.Text
					+ "',DiaChi='" + this.txt_diachi.Text
					+ "',GioiTinh='" + this.txt_gioitinh.Text
					+ "',Diem='" + this.txt_diem.Text
					+ "'WHERE (MaSinhVien ='" + this.txt_masv.Text + "')";
				Execute_Query(query);
				sql_view = "SELECT * FROM SINHVIEN";
				View_database(sql_view);
			}
			else
			{
				MessageBox.Show("Khoa rong hoac trung", "Kiem tra lai khoa", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
	}
}
