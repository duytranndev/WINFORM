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
using System.Diagnostics.Eventing.Reader;
using System.Runtime.InteropServices;

namespace Form_QuanLySinhVien_part2
{
	public partial class Form1 : Form
	{
		public static SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Winforms\Form_QuanLySinhVien_part2\Form_QuanLySinhVien_part2\App_Data\SINHVIEN.mdf;Integrated Security=True");
		string str,path_image;
		string sql_view = "SELECT masinhvien, tensinhvien, diachi, gioitinh, ngaysinh, diemlythuyet, diemthuchanh," +
				"(diemlythuyet*2 + diemthuchanh) / 3 AS diemtrungbinh, CASE " +
				"WHEN (diemlythuyet*2 + diemthuchanh) / 3 > 8 THEN N'Gioi'" +
				"WHEN (diemlythuyet*2 + diemthuchanh) / 3 > 7 THEN N'Kha'" +
				"WHEN (diemlythuyet*2 + diemthuchanh) / 3 > 5 THEN N'Trung Binh'" +
				"ELSE N'Yeu' END AS xeploai, anh FROM SINHVIEN";
		public Form1()
		{
			InitializeComponent();
			
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

		private void Excecute_Query(string query)
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
				MessageBox.Show("ERROR");
			}
		}
		
		private bool Check_key(string sql, string key)
		{
			bool ok = false;
			try
			{
				connect.Open();
				SqlCommand command = new SqlCommand(sql, connect);
				SqlDataReader data = command.ExecuteReader();
				if (data.Read() && (data.GetString(0).ToUpper() == key.ToUpper()))
					ok = true;
				connect.Close();
			}
			catch (Exception)
			{
				MessageBox.Show("ERROR");
			}
			return ok;
		}
		private void btn_first(object sender, EventArgs e)
		{

		}

		private void btn_previous(object sender, EventArgs e)
		{

		}

		private void btn_next(object sender, EventArgs e)
		{

		}

		private void btn_last(object sender, EventArgs e)
		{

		}

		private void btn_exit_Click(object sender, EventArgs e)
		{

		}

		private void btn_xoa_Click(object sender, EventArgs e)
		{
			string key = this.txt_masinhvien.Text;
			try
			{
				if (MessageBox.Show("ban co chac chan muon xoa ban ghi nay?", "C#", MessageBoxButtons.OKCancel, MessageBoxIcon.Question).ToString() == "OK")
				{
					string query = "delete from SINHVIEN where (masinhvien='" + key + "')";
					Excecute_Query(query);

					View_DataBase(sql_view);
				}
			}
			catch (Exception)
			{
				MessageBox.Show("error");
			}
		}

		private void btn_them_Click(object sender, EventArgs e)
		{
			string dd, mm, yyyy;
			dd = this.dateTimePicker_ngaysinh.Value.Day.ToString();
			mm = this.dateTimePicker_ngaysinh.Value.Month.ToString();
			yyyy = this.dateTimePicker_ngaysinh.Value.Year.ToString();
			string key = this.txt_masinhvien.Text;
			string sql = "SELECT masinhvien FROM SINHVIEN WHERE masinhvien ='"+key+"'";
			if(this.txt_masinhvien.Text !="" && !Check_key(sql, key))
			{
				string query = "INSERT INTO SINHVIEN VALUES('"
					+ this.txt_masinhvien.Text + "','"
					+ this.txt_tensinhvien.Text + "','"
					+ this.txt_diachi.Text + "','"
					+ this.combobox_gioitinh.Text + "','"
					+ yyyy + "/" + mm + "/" + dd + "','"
					+ this.txt_diemlythuyet.Text + "','"
					+ this.txt_diemthuchanh.Text + "','"
					+ path_image + "')";
				Excecute_Query(query);
				View_DataBase(sql_view);
				path_image = "";
			}
			else
			{
				MessageBox.Show("Khoa rong hoac trung", "Kiem tra lai khoa", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void dataGridView1_Click(int Index)
		{
			str = this.txt_masinhvien.Text = this.dataGridView1.Rows[Index].Cells[0].Value.ToString();
			this.txt_tensinhvien.Text = this.dataGridView1.Rows[Index].Cells[1].Value.ToString();
			this.txt_diachi.Text = this.dataGridView1.Rows[Index].Cells[2].Value.ToString();
			this.combobox_gioitinh.Text = this.dataGridView1.Rows[Index].Cells[3].Value.ToString();
			int dd = int.Parse(this.dataGridView1.Rows[this.dataGridView1.CurrentRow.Index].Cells[4].Value.ToString().Substring(0,2));
			int mm = int.Parse(this.dataGridView1.Rows[this.dataGridView1.CurrentRow.Index].Cells[4].Value.ToString().Substring(3,2));
			int yyyy = int.Parse(this.dataGridView1.Rows[this.dataGridView1.CurrentRow.Index].Cells[4].Value.ToString().Substring(6,4));
			this.dateTimePicker_ngaysinh.Value = new DateTime(yyyy, mm, dd);
			this.txt_diemlythuyet.Text = this.dataGridView1.Rows[Index].Cells[5].Value.ToString();
			this.txt_diemthuchanh.Text = this.dataGridView1.Rows[Index].Cells[6].Value.ToString();
			this.txt_diemtrungbinh.Text = Math.Round(double.Parse(this.dataGridView1.Rows[Index].Cells[7].Value.ToString()), 2).ToString();
			this.txt_xeploai.Text = this.dataGridView1.Rows[Index].Cells[8].Value.ToString();
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			dataGridView1_Click(this.dataGridView1.CurrentRow.Index);
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			
			View_DataBase(sql_view);
			dataGridView1_Click(this.dataGridView1.CurrentRow.Index);
		}

		

		private void btn_upanh_Click(object sender, EventArgs e)
		{
			this.openFileDialog1.ShowDialog();
			path_image = this.openFileDialog1.FileName;
			if (path_image != "openFileDialog!")
				this.pictureBox1.Image = Image.FromFile(path_image);
		}

		private void btn_sua_Click(object sender, EventArgs e)
		{

		}

		
	}
}
