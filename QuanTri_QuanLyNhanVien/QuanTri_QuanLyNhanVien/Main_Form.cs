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

namespace QuanTri_QuanLyNhanVien
{
	public partial class Main_Form : Form
	{
		private Form1 Form1;
		public int admin = 0;
		public static SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Winforms\QuanTri_QuanLyNhanVien\QuanTri_QuanLyNhanVien\App_Data\QUAN_LY_NHAN_VIEN.mdf;Integrated Security=True");
		int index = 0;
		DataTable db;
		public Main_Form(Form1 Form1)
		{
			InitializeComponent();
		}

		public void Execute_Query(string query)
		{
			try
			{
				conn.Open();
				SqlCommand command = new SqlCommand(query, conn);
				int k = command.ExecuteNonQuery();
				conn.Close();
			}
			catch (SqlException)
			{
				MessageBox.Show("error", "C# gamming", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
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
				if(data.Read() && data.GetString(0).ToUpper() == key.ToUpper())
				{
					ok = true;
				}
				conn.Close();
			}
			catch (SqlException)
			{
				MessageBox.Show("error", "C# gamming", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
			}
			return ok;

		}

		private void phongBanToolStripMenuItem_Click(object sender, EventArgs e)
		{
			PhongBan phongBan = new PhongBan(this);
			phongBan.Show();
			this.Hide();
		}

		private void nhanVienToolStripMenuItem_Click(object sender, EventArgs e)
		{
			NhanVien nhanVien = new NhanVien(this);
			nhanVien.Show();
			this.Hide();
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		public static DataSet docAllDLStored(string stored, string[] vals, string[] pars)
		{
			Main_Form.conn.Open();
			SqlCommand command = new SqlCommand(stored, Main_Form.conn);
			SqlDataAdapter da = new SqlDataAdapter(command);
			DataSet ds = new DataSet();
			for (int i = 0; i < vals.Length; i++)
				command.Parameters.Add(new SqlParameter(pars[i], vals[i]));
			command.CommandType = CommandType.StoredProcedure;
			da.Fill(ds);
			return ds;
		}
	}
}
