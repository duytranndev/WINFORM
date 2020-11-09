using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DangNhap
{
	public partial class XemThongTin : Form
	{
		private Thong_tin_hoc_vien Thong_Tin_Hoc_Vien;
		public XemThongTin(Thong_tin_hoc_vien Thong_Tin_Hoc_Vien)
		{
			InitializeComponent();
			this.Thong_Tin_Hoc_Vien = Thong_Tin_Hoc_Vien;

		}

		public XemThongTin(XemThongTin xemThongTin)
		{
		}

		private void XemThongTin_Load(object sender, EventArgs e)
		{
			int i = 0;
			foreach (var item in Thong_Tin_Hoc_Vien.List)
			{
				i++;
				HocVien T = item.Value as HocVien;
				dataGridView1.Rows.Add(i.ToString(), T.So_cm, T.Ho_ten, T.Nam_sinh, T.Khoa_hoc, T.Dia_chi, T.Gioi_tinh, T.Thoi_gian_hoc, T.Su_dung_thu_vien, T.Su_dung_may_tinh);
			}
		}

		private void btn_xem(object sender, EventArgs e)
		{

		}

		private void btn_exit(object sender, EventArgs e)
		{
			this.Close();
		}

		private void XemThongTin_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.Hide();
			Thong_Tin_Hoc_Vien.Show();
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
