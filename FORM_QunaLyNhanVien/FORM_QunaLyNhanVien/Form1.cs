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

namespace FORM_QunaLyNhanVien
{
	public partial class Form1 : Form
	{
		SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Winforms\FORM_QunaLyNhanVien\FORM_QunaLyNhanVien\NhanVien.mdf;Integrated Security=True");
		string  sql,path_img;
		string sql_view = "select* from NhanVien";
		public Form1()
		{
			InitializeComponent();
		}
		public void Execute_Query(string query)
		{
			conn.Close();
			try
			{
				conn.Open();
				SqlCommand command = new SqlCommand(query, conn);
				command.ExecuteNonQuery();
				conn.Close();
			}
			catch (SqlException)
			{
				MessageBox.Show("error");
			}
		}

		public bool Check_Key(string sql, string key)
		{
			
			bool ok = false;
			try
			{
				conn.Open();
				SqlCommand command = new SqlCommand(sql, conn);
				SqlDataReader data = command.ExecuteReader();
				
				if (data.Read() && data.GetString(0).ToUpper() == key.ToUpper())
					ok = false;
				conn.Close();
			}
			catch (SqlException)
			{
				MessageBox.Show("error");
			}
			return ok;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			sql = "select * from NhanVien";
			ShowDatabase(sql);
		}

		private void btn_upload_Click(object sender, EventArgs e)
		{

		}

		private void btn_xoa_Click(object sender, EventArgs e)
		{
			string key = txt_manv.Text;
			try
			{
				if(MessageBox.Show("Ban co muon xoa?", "OK", MessageBoxButtons.OKCancel, MessageBoxIcon.Question).ToString() == "OK")
				{
					string query = "delete NhanVien where (manv='" + key + "')";
					Execute_Query(query);
					ShowDatabase(sql_view);
				}
			}
			catch (SqlException)
			{
				MessageBox.Show("Xoa that bai");
			}
		}

		public void ShowDatabase(string sql)
		{
			conn.Close();
			try
			{
				conn.Open();
				SqlCommand command = new SqlCommand(sql, conn);
				SqlDataAdapter da = new SqlDataAdapter(command);
				DataTable dt = new DataTable();
				conn.Close();
				da.Fill(dt);
				
				dataGridView1.DataSource = dt;
				
			}
			catch (SqlException)
			{
				MessageBox.Show("error");
			}
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			txt_manv.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
			txt_tennv.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
			txt_ngaysinh.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
			//txt_manv.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
		}

		private void btn_sua_Click(object sender, EventArgs e)
		{
			path_img = "";
			string key = this.txt_manv.Text;
			string sql = "SELECT manv FROM NhanVien WHERE manv='" + key + "'";
			if (this.txt_manv.Text != "" && Check_Key(sql, key))
			{
				string query = "UPDATE NhanVien SET tennv ='" + this.txt_tennv.Text
					+ "',ngaysinh='" + this.txt_ngaysinh.Text
					+ "',anh='" + path_img
					+ "'WHERE (manv ='" + this.txt_manv.Text + "')";
				Execute_Query(query);
				ShowDatabase(sql_view);
			}
			else
			{
				MessageBox.Show("Sua that bai");
			}
		}

		private void btn_them_Click(object sender, EventArgs e)
		{
			path_img = "AAA";
			string key = txt_manv.Text;
			sql = "select manv from NhanVien where manv='" + txt_manv + "'";
			if(txt_manv.Text !="" && !Check_Key(sql, key))
			{
				string query = "insert into NhanVien (manv,tennv,ngaysinh,anh) values('"
					+ txt_manv.Text + "','"
					+ txt_tennv.Text + "','"
					+ txt_ngaysinh.Text + "','"
					+ path_img + "')";
				Execute_Query(query);
				sql_view = "select * from NhanVien";
				ShowDatabase(sql_view);
				path_img = "";
			}
			else
			{
				MessageBox.Show("error");
			}
		}
	}
}
