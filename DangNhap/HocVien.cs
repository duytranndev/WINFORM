using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DangNhap
{
	class HocVien : Nguoi
	{
		private string thoi_gian_hoc;
		private string su_dung_thu_vien;
		private string su_dung_may_tinh;
		private string khoa_hoc;

		public HocVien() : base()
		{

		}

		public HocVien(string so_cm, string ho_ten, int nam_sinh, string khoa_hoc, string dia_chi, string gioi_tinh, string thoi_gian_hoc, string su_dung_thu_vien, string su_dung_may_tinh) : base(so_cm, ho_ten, nam_sinh, gioi_tinh, dia_chi)
		{
			this.thoi_gian_hoc = thoi_gian_hoc;
			this.su_dung_thu_vien = su_dung_thu_vien;
			this.su_dung_may_tinh = su_dung_may_tinh;
			this.khoa_hoc = khoa_hoc;
		}

		public string Thoi_gian_hoc { get => thoi_gian_hoc; set => thoi_gian_hoc = value; }
		public string Su_dung_thu_vien { get => su_dung_thu_vien; set => su_dung_thu_vien = value; }
		public string Su_dung_may_tinh { get => su_dung_may_tinh; set => su_dung_may_tinh = value; }
		public string Khoa_hoc { get => khoa_hoc; set => khoa_hoc = value; }
	}
	

}
