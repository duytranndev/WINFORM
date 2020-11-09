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
	public partial class Thong_tin_hoc_vien : Form
	{
		public Dictionary<string, Object> List = new Dictionary<string, Object>();
		HocVien hocvien = new HocVien();

		private Form1 Form1;
		private Thong_tin_hoc_vien thong_tin_hoc_vien;

		public Thong_tin_hoc_vien(Form1 Form1)
		{
			InitializeComponent();
			this.Form1 = Form1;
		}

		public Thong_tin_hoc_vien(Thong_tin_hoc_vien thong_tin_hoc_vien)
		{
			this.thong_tin_hoc_vien = thong_tin_hoc_vien;
		}

		private void btn_xem(object sender, EventArgs e)
		{
			XemThongTin xemThongTin = new XemThongTin(this);
			xemThongTin.Show();
			this.Hide();
		}

		private void btn_save(object sender, EventArgs e)
		{
			bool ok = false;
			string so_cm = "", ho_ten = "", gioi_tinh = "", dia_chi = "", thoi_gian_hoc = "", khoa_hoc = "", su_dung_thu_vien = "", su_dung_may_tinh = "";
			int nam_sinh = 0;
			so_cm = this.txt_cm.Text;
			ho_ten = this.txt_hoten.Text;
			dia_chi = this.txt_diachi.Text;
			if (listbox_nam_sinh.SelectedItem !=null)
			{
				nam_sinh = int.Parse(listbox_nam_sinh.SelectedItem.ToString());
				ok = true;
			}
			else
			{
				MessageBox.Show("Chưa chọn năm sinh");
				ok = false;
			}
			if (rdb_nam.Checked == true) gioi_tinh = "nam";
			else gioi_tinh = "nu";
			if(listbox_thoigianhoc.SelectedItem != null)
			{
				thoi_gian_hoc = listbox_thoigianhoc.SelectedItem.ToString();
				ok = true;
			}
			else
			{
				MessageBox.Show("Chưa chọn thời gian học");
				ok = false;
			}

			if(combobox_khoahoc.SelectedItem != null)
			{
				khoa_hoc = combobox_khoahoc.SelectedItem.ToString();
				ok = true;
			}
			else
			{
				MessageBox.Show("Chưa chọn khóa học");
				ok = false;
			}

			if (cb_library.Checked) su_dung_thu_vien = "Có sử dụng thư viện";
			else su_dung_thu_vien = "";
			if (cb_caculate.Checked) su_dung_may_tinh = "Có sử dụng máy tính";
			else su_dung_may_tinh = "";

			if (so_cm == "" || ho_ten == "" || gioi_tinh == "" || dia_chi == "" || nam_sinh == 0)
			{
				MessageBox.Show("Thông tin chưa đầy đủ");
				ok = false;
			}
			else ok = true;
			if (ok)
			{
				HocVien P = new HocVien(so_cm, ho_ten, nam_sinh, khoa_hoc, dia_chi,  gioi_tinh, thoi_gian_hoc, su_dung_thu_vien, su_dung_may_tinh);
				if (List.ContainsKey(so_cm)) MessageBox.Show("Trùng khóa");
				else
				{
					List.Add(so_cm, P);
					MessageBox.Show("Lưu thành công");
					txt_cm.Text = "";
				}
			}
		}

		private void btn_exit(object sender, EventArgs e)
		{
			Form1.Close();
		}

		
		

		private void Thong_tin_hoc_vien_FormClosing(object sender, FormClosingEventArgs e)
		{
			Form1.Close();
		}

		private void Thong_tin_hoc_vien_Load(object sender, EventArgs e)
		{

		}
		private void thong_tin_hoc_vien_Activated(object sender, EventArgs e)
		{
			listbox_nam_sinh.SetSelected(0, true);
			listbox_thoigianhoc.SetSelected(0, true);
		}
		
	}
}
