using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QuanLySinhVien
{
	class Student
	{
		private String maSv;
		private String tenSv;
		private int namSinh;
		private String lop;
		private String diaChi;
		private double diem;

		public string MaSv { get => maSv; set => maSv = value; }
		public string TenSv { get => tenSv; set => tenSv = value; }
		public int NamSinh { get => namSinh; set => namSinh = value; }
		public string Lop { get => lop; set => lop = value; }
		public string DiaChi { get => diaChi; set => diaChi = value; }
		public double Diem { get => diem; set => diem = value; }

		public Student()
		{

		}


		public Student(String maSv, String tenSv, int namSinh, String lop, String diaChi, double diem)
		{
			this.MaSv = maSv;
			this.TenSv = tenSv;
			this.NamSinh = namSinh;
			this.Lop = lop;
			this.DiaChi = diaChi;
			this.Diem = diem;
		}

		public string XepLoai()
		{
			if (Diem >= 9) return "Xuat sac";
			if (Diem >= 8) return "Gioi";
			if (Diem >= 7) return "Kha";
			if (Diem >= 6) return "Trung binh kha";
			if (Diem >= 5) return "Trung binh";
			else return "yeu";
		}

		public void Xem()
		{
			Console.Out.WriteLine("MaSv: {0}\t TenSv: {1}\tNamSinh: {2}\tLop: {3}\tDiaChi: {4}\tDiem: {5}\tXepLoai: {6}",
				MaSv, TenSv, NamSinh, Lop, DiaChi, Diem, this.XepLoai());
		}
	}

	class Class { 

		private Student[] L = new Student[50];
		private int si_so;

		public Class()
		{

		}

		public Class(int n)
		{
			si_so = n;
		}

		public void Chen(Student x, int k)
		{
			int i;
			if (k > 0 && k <= si_so + 1)
			{
				if (k <= si_so)
				{
					for (i = si_so; i < k; i--)
					{
						L[i] = L[i + 1];
					}
				}
				L[k] = x;
				si_so = si_so + 1;
			}
		}

		public void Tao()
		{
			
			int i;
			String masv, tensv, lop, diachi;
			double diem = 0;
			int namSinh = 0;
			for (i = 1; i <= si_so; i++)
			{
				L[i] = new Student("", "", 0, "", "", 0);
				Console.Out.WriteLine("Nhap sinh vien thu {0}", i);

				Console.Out.Write("Ma sinh vien: ");
				
				L[i].MaSv= Console.ReadLine().ToString();
				bool sig = true;

				for(int j = i - 1; j >= 1; j--)
				{
					if(L[i].MaSv == L[j].MaSv)
					{
						sig = false;
						break;
					}
				}
				if (!sig)
				{
					i--;
					continue;
				}

				Console.Out.Write("Ten sinh vien: ");
				tensv = Console.ReadLine();
				try
				{
					do
					{
						Console.Out.Write("nam sinh: ");
						namSinh = int.Parse(Console.ReadLine());
					} while (namSinh <= 0);
				}catch(Exception e)
				{
					Console.Out.Write(e);
				}
				Console.Out.Write("Lop: ");
				lop = Console.ReadLine();
				Console.Out.Write("Dia chi: ");
				diachi = Console.ReadLine();

				try
				{
					do
					{
						Console.Out.Write("Diem: ");
						diem = double.Parse(Console.ReadLine());
					} while (diem < 0);

				}catch(Exception e)
				{
					Console.Out.Write(e);
				}

				Student T = new Student(L[i].MaSv, tensv, namSinh, lop, diachi, diem);
				L[i] = T;
			}
		}

		public void Xem()
		{
			int i;
			for (i = 1; i <= si_so; i++)
			{
				Console.Out.WriteLine("Thong tin sinh vien thu {0}", i);
				L[i].Xem();
			}
		}
		public void Xoa(int k)
		{
			
			for(int i = k; i < si_so; i++)
			{
				L[i] = L[i + 1];
			}
			si_so--;
			
			
		}

	}

	class Program
	{
		

		static void Main(string[] args)
		{
			int si_so=0;
			
			try
			{
				do
				{
					Console.Out.Write("Nhap si so lop: ");
					si_so = int.Parse(Console.ReadLine());
				} while (si_so <= 0);
			}catch(Exception e)
			{
				Console.Out.Write(e);
			}

			Class List = new Class(si_so);
			List.Tao();
			List.Xem();
			


			Console.ReadLine();

		}
	}
}
