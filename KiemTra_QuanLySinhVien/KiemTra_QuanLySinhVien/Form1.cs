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
using System.IO;

namespace KiemTra_QuanLySinhVien
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			
		}
		public static SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Winforms\KiemTra_QuanLySinhVien\KiemTra_QuanLySinhVien\App_Data\SINHVIEN.mdf;Integrated Security=True");
		string str, sql_view,path_img;
		string sql = "select * from SINHVIEN";

		private void Form1_Load(object sender, EventArgs e)
		{
			
			View_DataBase(sql);
		}



		private void View_DataBase(string sql)
		{
			connect.Open();
			SqlCommand command = new SqlCommand(sql, connect);
			SqlDataAdapter da = new SqlDataAdapter(command);
			DataTable dt = new DataTable();
			da.Fill(dt);
			connect.Close();
			this.dataGridView1.DataSource = dt;
		}

		


		private void Execute_Query(string query)
		{
			connect.Close();
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
				connect.Close();
			}
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
					View_DataBase(sql_view);
				}
			}
			catch (Exception)
			{
				MessageBox.Show("error");
			}
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{

			this.txt_masv.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
			this.txt_tensv.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
			this.txt_ngaysinh.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
			this.txt_diem.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value.ToString();
			try
			{
				pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			}
			catch (Exception)
			{
				MessageBox.Show("");
			}
			
		}

		private void btn_upload_Click(object sender, EventArgs e)
		{
			
			this.openFileDialog1.ShowDialog();
			path_img = this.openFileDialog1.FileName;
			if (path_img != "openFileDialog1")
				this.pictureBox1.Image = Image.FromFile(path_img);
		}

		private void btn_sua_Click_1(object sender, EventArgs e)
		{

		}

		private void btn_them_Click_1(object sender, EventArgs e)
		{
			string query = "insert into SINHVIEN (MaSinhVien, TenSinhVien, NgaySinh, Diem, Anh) " +
				"values (@masinhvien, @tensinhvien, @ngaysinh, @diem, @anh)";
			SqlCommand cmd = new SqlCommand(query,connect);

			SqlParameter masv = new SqlParameter();
			masv.ParameterName = "@masinhvien";
			masv.Value = txt_masv.Text;

			SqlParameter tensv = new SqlParameter();
			tensv.ParameterName = "@tensinhvien";
			tensv.Value = txt_tensv.Text;

			SqlParameter ngaysinh = new SqlParameter();
			ngaysinh.ParameterName = "@ngaysinh";
			ngaysinh.Value = txt_ngaysinh.Text;

			SqlParameter diem = new SqlParameter();
			diem.ParameterName = "@diem";
			diem.Value = txt_diem.Text;

			SqlParameter anh = new SqlParameter();
			masv.ParameterName = "@anh";
			masv.Value = this.pictureBox1.Image;

			cmd.Parameters.Add(masv);
			cmd.Parameters.Add(tensv);
			cmd.Parameters.Add(ngaysinh);
			cmd.Parameters.Add(diem);
			cmd.Parameters.Add(anh);

            try
            {
				connect.Open();
				cmd.ExecuteNonQuery();
				connect.Close();
				View_DataBase(sql);
            }
            catch (Exception)
            {
				MessageBox.Show("them that bai");
            }

		}

		private void btn_thoat_Click(object sender, EventArgs e)
		{

		}

		

		
	}
}
