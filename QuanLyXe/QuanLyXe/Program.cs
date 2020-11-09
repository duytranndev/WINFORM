using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyXe
{
	class Program
	{
		class XeHoi
		{
			private string bienSo, tenXe;
			private string trongTai;
			private DateTime ngayDangKiem = new DateTime();
			private int tieuChuan;
			public XeHoi()
			{

			}
			public XeHoi(string bienSo,string tenXe,int trongtai,DateTime ngayDangKiem,int tieuChuan)
			{
				this.bienSo = bienSo;
				this.TenXe = tenXe;
				this.TrongTai = TrongTai;
				this.NgayDangKiem = ngayDangKiem;
				this.TieuChuan = tieuChuan;
			}

			public string B {
				get
				{
					return bienSo;
				}
				set
				{
					bienSo = value;
				}
			}
			public string TenXe { get => tenXe; set => tenXe = value; }
			public string TrongTai { get => trongTai; set => trongTai = value; }
			public DateTime NgayDangKiem { get => ngayDangKiem; set => ngayDangKiem = value; }
			public int TieuChuan { get => tieuChuan; set => tieuChuan = value; }

			public virtual void In()
			{
				Console.WriteLine("Bien so:\t\t{0}\nTen xe:\t\t{1}\nTrong tai:\t\t{2}\nNgay dang kiem:\t\t{3}/{4}/{5}\nTieu chuan hang:\t\t{6}",
					bienSo, tenXe, trongTai, ngayDangKiem.Day,ngayDangKiem.Month,ngayDangKiem.Year,tieuChuan);
			}
		}

		class XeDuLich : XeHoi
		{
			private int soChoNgoi;

			public XeDuLich(string bienSo, string tenXe, int trongtai, DateTime ngayDangKiem, int tieuChuan,int soChoNgoi) : base(bienSo, tenXe, trongtai, ngayDangKiem, tieuChuan)
			{
				this.SoChoNgoi = SoChoNgoi;
			}

			public int SoChoNgoi { get => soChoNgoi; set => soChoNgoi = value; }

			public override void In()
			{
				base.In();
				Console.WriteLine("So cho ngoi:\t\t{0}", soChoNgoi);
			}

		}

		class XeChoHang : XeHoi
		{
			private double soTan;

			public XeChoHang(string bienSo, string tenXe, int trongtai, DateTime ngayDangKiem, int tieuChuan,double soTan) : base(bienSo, tenXe, trongtai, ngayDangKiem, tieuChuan)
			{
				this.SoTan = SoTan;
			}

			public double SoTan { get => soTan; set => soTan = value; }

			public override void In()
			{
				base.In();
				Console.WriteLine("So tan:\t\t{0}", SoTan);
			}
		}

		class QuanLyXe
		{
			private Dictionary<string, Object> List = new Dictionary<string, object>();
			int yyyy, mm, dd;

			public void YYYY_MM_DD(string yy_mm_dd,ref int yyyy,ref int mm,ref int dd)
			{
				int k = 0;
				for(int i = 0; i < yy_mm_dd.Length; i++)
				{
					if((yy_mm_dd[i] ==' ') || (i == yy_mm_dd.Length - 1))
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
				string bienso = "";
				do
				{
					Console.Write("Nhap bien so xe: ");
					bienso = Console.ReadLine();
					if (bienso == "") break;
					if (List.ContainsKey(bienso))//trùng key
					{
						Console.Write("Key same, please typing again ~~");
						continue;
					}
					string tenxe;
					int tieuchuan, sochongoi, trongtai;
					double sotan;
					Console.Write("Nhap ten xe: ");
					tenxe = Console.ReadLine();
					Console.Write("Nhap trong tai: ");
					trongtai = int.Parse(Console.ReadLine());
					Console.Write("Nhap ngay dang kiem: ");
					string Ngay_Dang_Kiem = Console.ReadLine();
					YYYY_MM_DD(Ngay_Dang_Kiem, ref yyyy, ref mm, ref dd);
					DateTime ngayDangKiem = new DateTime(yyyy, mm, dd);
					Console.Write("Nhap tieu chuan: ");
					tieuchuan = int.Parse(Console.ReadLine());
					Console.Write("Nhap loai xe: H-Xe hang, D-Du Lich....");
					string str_loai_xe = Console.ReadLine();
					if (str_loai_xe == "H")
					{
						Console.Write("So tan: ");
						sotan = double.Parse(Console.ReadLine());
						XeChoHang H = new XeChoHang(bienso, tenxe, trongtai, ngayDangKiem, tieuchuan, sotan);
						List.Add(H.B,H);
					}
					else if (str_loai_xe == "D")
					{
						Console.Write("So cho ngoi: ");
						sochongoi = int.Parse(Console.ReadLine());
						XeDuLich D = new XeDuLich(bienso, tenxe, trongtai, ngayDangKiem, tieuchuan, sochongoi);
						List.Add(D.B, D);
					}
					else continue;

				} while (bienso != "");
			}

			public void Xem()
			{
				foreach(var dic in List)
				{
					XeHoi P = (XeHoi)List[dic.Key];
					P.In();
				}
			}
			public void Xem_Cho_Hang()
			{
				foreach(var dic in List)
				{
					XeHoi P = (XeHoi)List[dic.Key];
					if (P is XeChoHang) P.In();
				}
			}
			public void Xem_Du_Lich()
			{
				foreach (var dic in List)
				{
					XeHoi P = (XeHoi)List[dic.Key];
					if (P is XeDuLich) P.In();
				}
			}

		}

		static void Main(string[] args)
		{
			QuanLyXe Q = new QuanLyXe();
			Q.Create();
			Q.Xem();
			Q.Xem_Cho_Hang();
			Q.Xem_Du_Lich();
			Console.ReadKey();
		}
	}
}
