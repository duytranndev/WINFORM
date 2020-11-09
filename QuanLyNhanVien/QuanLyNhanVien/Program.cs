using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyNhanVien
{
	class Program
	{
		class Nguoi
		{
			private string ten;
			private DateTime ngaySinh = new DateTime();
			private string diaChi;

			public Nguoi()
			{

			}
			public Nguoi(string ten,DateTime ngaySinh,string diaChi)
			{
				this.Ten = ten;
				this.NgaySinh = ngaySinh;
				this.DiaChi = diaChi;
			}

			public string Ten { get => ten; set => ten = value; }
			public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
			public string DiaChi { get => diaChi; set => diaChi = value; }

			public virtual void In()
			{
				Console.WriteLine("Ten: {0}\tNgay sinh: {1}/{2}/{3}\tDia chi: {4}",
					ten, ngaySinh.Day, ngaySinh.Month, ngaySinh.Year, diaChi);
			}
			
		}

		class NhanVien : Nguoi
		{
			private string maNhanVien;
			private double luong,phuCap;
			private string chucVu;

			public NhanVien()
			{

			}

			public NhanVien(string ten, DateTime ngaySinh, string diaChi,string maNhanVien,double luong,double phuCap,string chucVu) 
				: base(ten, ngaySinh, diaChi)
			{
				this.MaNhanVien = maNhanVien;
				this.Luong = luong;
				this.PhuCap = phuCap;
				this.ChucVu = chucVu;
			}

			public string MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
			public double Luong { get => Luong1; set => Luong1 = value; }
			public double PhuCap { get => PhuCap1; set => PhuCap1 = value; }
			public double Luong1 { get => luong; set => luong = value; }
			public double PhuCap1 { get => phuCap; set => phuCap = value; }
			public string ChucVu { get => chucVu; set => chucVu = value; }

			public override void In()
			{
				base.In();
				Console.WriteLine("Ma nhan vien: {0}\t  Muc thu nhap: {1}\tLuong: {2}\tPhu cap: {3}\tChuc vu: {4}", maNhanVien, luong + phuCap,luong, phuCap, chucVu);
			}
		}

		class Phong
		{
			private Dictionary<string, Object> List = new Dictionary<string, object>();

			int yyyy, mm, dd;
			public void YYYY_MM_DD(string yy_mm_dd, ref int yyyy, ref int mm, ref int dd)
			{
				int k = 0;
				for (int i = 0; i < yy_mm_dd.Length; i++)
				{
					if ((yy_mm_dd[i] == ' ') || (i == yy_mm_dd.Length - 1))
					{
						if (k == 0) dd = int.Parse(yy_mm_dd.Substring(k, i - k + 1).Trim());
						else if (i < yy_mm_dd.Length - 1) mm = int.Parse(yy_mm_dd.Substring(k, i - k + 1).Trim());
						else yyyy = int.Parse(yy_mm_dd.Substring(k, i - k + 1).Trim());
						k = i;
					}

				}
			}
			public void Create()
			{
				string maNhanVien = "";
				
				do
				{
					Console.Write("Nhap ma nhan vien: ");
					maNhanVien = Console.ReadLine();
					if (maNhanVien == "") break;
					if (List.ContainsKey(maNhanVien))//trùng key
					{
						Console.Write("Ma nhan vien da ton tai, moi nhap lai....\n");
						continue;
					}
					string ten;
					string diaChi;
					double luong;
					double phuCap;
					string chucVu;
					Console.Write("Moi nhap ten nhan vien: ");
					ten = Console.ReadLine();
					Console.Write("Moi nhap dia chi: ");
					diaChi = Console.ReadLine();
					Console.Write("Nhap ngay sinh: ");
					string ngay_sinh = Console.ReadLine();
					YYYY_MM_DD(ngay_sinh, ref yyyy, ref mm, ref dd);
					DateTime ngaysinh = new DateTime(yyyy, mm, dd);
					Console.Write("Moi nhap chuc vu: ");
					chucVu = Console.ReadLine();
					Console.Write("Moi ban nhap luong: ");
					luong = double.Parse(Console.ReadLine());
					Console.Write("Moi ban nhap phu cap: ");
					phuCap = double.Parse(Console.ReadLine());

					NhanVien N = new NhanVien(ten,ngaysinh,diaChi,maNhanVien,luong,phuCap,chucVu);

					List.Add(N.MaNhanVien, N);
				} while (maNhanVien != "");
			}
			
			public void Xem()
			{
				foreach(var item in List)
				{
					NhanVien N = (NhanVien)List[item.Key];
					N.In();
				}
			}
		}
		static void Main(string[] args)
		{
			Phong phong = new Phong();
			phong.Create();
			phong.Xem();
			Console.ReadKey();
		}
	}
}
