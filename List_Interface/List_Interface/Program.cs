using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Interface
{
	class Program
	{
		interface Sinh_Vien
		{
			string Ma_Sinh_Vien { get; set; }
			string Ten_Sinh_Vien { get; set; }
			void In_Sinh_Vien();
		}
		interface Giang_Vien
		{
			string Ma_Giang_Vien {	 get; set; }
			string Ten_Giang_Vien { get; set; }
			void In_Giang_Vien();
		}
		interface Mon_Hoc
		{
			string Ma_Mon { get; set; }
			string Ten_Mon { get; set; }
			void In_Mon();
		}
		public class Hoc_Tap : Sinh_Vien , Mon_Hoc
		{
			private double diem;
			private string masv;
			private string tensv;
			private string mamon;
			private string tenmon;
			
			public double Diem
			{
				get
				{
					return diem;
				}
				set
				{
					diem = value;
				}
			}
			

			public string Ma_Sinh_Vien {
				get
				{
					return masv;
				}
				set
				{
					masv = value;
				}
			}
			public string Ten_Sinh_Vien {
				get
				{
					return tensv;
				}
				set
				{
					tensv =value;
				}
			}
			public string Ma_Mon {
				get
				{
					return mamon;
				}
				set
				{
					mamon = value;
				}
			}
			public string Ten_Mon {
				get
				{
					return tenmon;
				}
				set
				{
					tenmon = value;
				}
			}

			public void In_Mon()
			{
				Console.Out.WriteLine("ma mon: {0}, ten mon: {1}", mamon, tenmon);
			}

			public void In_Sinh_Vien()
			{
				Console.Out.WriteLine("ma sinh vien: {0}, ten sinh vien: {1}", masv, tensv);
			}
			public void In()
			{
				Console.Out.WriteLine("diem: " + diem);
			}
		}

		public class Giang_Day : Giang_Vien, Mon_Hoc
		{
			private int sotiet;
			private string magv;
			private string tengv;
			private string mamon;
			private string tenmon;

			public int Sotiet {
				get
				{
					return sotiet;
				}
				set
				{
					sotiet = value;
				}
			}
			public string Ma_Giang_Vien {
				get
				{
					return magv;
				}
				set
				{
					magv = value;
				}
			}
			public string Ten_Giang_Vien {
				get
				{
					return tengv;
				}
				set
				{
					tengv = value;
				}
			}
			public string Ma_Mon {
				get
				{
					return mamon;
				}
				set
				{
					mamon = value;
				}
			}
			public string Ten_Mon {
				get
				{
					return tenmon;
				}
				set
				{
					tenmon = value;
				}
			}
			

			public void In_Giang_Vien()
			{
				Console.Out.WriteLine("ma giang vien: {0}, ten giang vien: {1}", magv, tengv);
			}

			public void In_Mon()
			{
				Console.Out.WriteLine("ma mon: {0}, ten mon: {1}", mamon, tenmon);
			}
			public void In()
			{
				Console.Out.WriteLine("so tiet: " + sotiet);
			}
		}

		class QuanLyHocTap
		{
			List<Object> L = new List<Object>();

			public void CreateList()
			{
				string sig = "";
				
				do
				{
					string key = "";
					bool isFind = true;
					Console.Write("Nhap H (hoc tap), G (giang day)");
					sig = Console.ReadLine();
					if (sig != "H" && sig != "G") break;
					if (sig == "H")
					{
						Hoc_Tap H = new Hoc_Tap();
						Console.Write("nhap ma sinh vien: ");
						key = Console.ReadLine();
						if (key.Contains(L.Ma_Sinh_Vien))
						{
							isFind = false;
							break;
						}
						if (!isFind)
						{
							continue;
						}
						Console.Write("ten sinh vien: ");
						H.Ten_Sinh_Vien = Console.ReadLine();
						Console.Write("ma mon: ");
						H.Ma_Mon = Console.ReadLine();
						Console.Write("ten mon: ");
						H.Ten_Mon = Console.ReadLine();
						Console.Write("diem mon hoc: ");
						H.Diem = double.Parse(Console.ReadLine());
						L.Add(H);
					}
					if (sig == "G")
					{
						Giang_Day G = new Giang_Day();
						Console.Write("ma giang vien: ");
						G.Ma_Giang_Vien = Console.ReadLine();
						Console.Write("ten giang vien: ");
						G.Ten_Giang_Vien = Console.ReadLine();
						Console.Write("ma mon: ");
						G.Ma_Mon = Console.ReadLine();
						Console.Write("ten mon: ");
						G.Ten_Mon = Console.ReadLine();
						Console.Write("so tiet day: ");
						G.Sotiet = int.Parse(Console.ReadLine());
						L.Add(G);
					}
				} while (sig == "H" || sig == "G");



			}
			public void View_List()
			{
				foreach(var item in L)
				{
					if(item is Hoc_Tap)
					{
						Hoc_Tap H = item as Hoc_Tap;
						H.In_Mon();
						H.In_Sinh_Vien();
						Console.WriteLine();
					}
					else
					{
						Giang_Day G = item as Giang_Day;
						G.In_Mon();
						G.In_Giang_Vien();
					}
				}
			}
		}


		static void Main(string[] args)
		{
			QuanLyHocTap Q = new QuanLyHocTap();
			Console.WriteLine();
			Q.CreateList();
			Console.WriteLine();
			Q.View_List();
			Console.ReadKey();
		}
	}
}
