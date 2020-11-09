using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DangNhap
{
	class Nguoi
	{
		private string so_cm;
		private string ho_ten;
		private int nam_sinh;
		private string gioi_tinh;
		private string dia_chi;

		public Nguoi()
		{

		}
		public Nguoi(string so_cm, string ho_ten, int nam_sinh, string gioi_tinh, string dia_chi)
		{
			this.so_cm = so_cm;
			this.ho_ten = ho_ten;
			this.nam_sinh = nam_sinh;
			this.gioi_tinh = gioi_tinh;
			this.dia_chi = dia_chi;
		}


		public string So_cm { get => so_cm; set => so_cm = value; }
		public string Ho_ten { get => ho_ten; set => ho_ten = value; }
		public int Nam_sinh { get => nam_sinh; set => nam_sinh = value; }
		public string Gioi_tinh { get => gioi_tinh; set => gioi_tinh = value; }
		public string Dia_chi { get => dia_chi; set => dia_chi = value; }
	}
}
