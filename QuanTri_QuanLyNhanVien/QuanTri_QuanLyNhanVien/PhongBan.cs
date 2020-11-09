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

namespace QuanTri_QuanLyNhanVien
{
	public partial class PhongBan : Form
	{
		string sql="";
		public PhongBan(Main_Form main_Form)
		{
			InitializeComponent();
			View_database(sql);
		}
		public void Execute_Query(string query)
		{
			try
			{
				Main_Form.conn.Open();
				SqlCommand command = new SqlCommand(query, Main_Form.conn);
				int k = command.ExecuteNonQuery();
				Main_Form.conn.Close();
			}
			catch (SqlException)
			{
				MessageBox.Show("Error");
			}
		}
		public void View_database(string sql)
		{
			try
			{
				Main_Form.conn.Open();
				SqlCommand command = new SqlCommand(sql, Main_Form.conn);
				SqlDataAdapter da = new SqlDataAdapter(command);
				DataTable dt = new DataTable();
				da.Fill(dt);
				Main_Form.conn.Close();
				this.dataGridView1.DataSource = dt;
			}
			catch (SqlException)
			{
				MessageBox.Show("Error");
			}
			
		}

		public bool Check_Key(string sql, string key)
		{
			try
			{
				Main_Form.conn.Open();
				SqlCommand command = new SqlCommand(sql, Main_Form.conn);
				SqlDataReader data = command.ExecuteReader();
				if()
			}
		}
		private void btn_them_Click(object sender, EventArgs e)
		{

		}

		private void btn_sua_Click(object sender, EventArgs e)
		{

		}

		private void btn_xoa_Click(object sender, EventArgs e)
		{

		}

		private void btn_thoat_Click(object sender, EventArgs e)
		{

		}
	}
}
