using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HinhCau
{
	class Program
	{
		public class Point
		{
			private double x, y;

			public Point()
			{
				this.x = 0;
				this.y = 0;
			}
			public Point(double x, double y)
			{
				this.x = x;
				this.y = y;
			}
			~Point()
			{
				this.x = 0;
				this.y = 0;
			}
			public double Get_x()
			{
				return this.x;
			}
			public double Get_y()
			{
				return this.y;
			}
			public void View()
			{
				Console.Out.WriteLine("x: {0},y: {1} ", this.x, this.y);
			}
		}
		class Globular : Point
		{
			private double r;
			public Globular(double x, double y, double r) : base(x, y)
			{
				this.r = r;
			}
			public double TheTich()//thể tích
			{
				return (4 / 3) * Math.PI * Math.Pow(r, 3);
			}
			public double DienTich()
			{
				return 4 * Math.PI * Math.Pow(r, 2);
			}
			public new void View()
			{
				base.View();
				Console.Out.WriteLine("r: " + this.r);
			}


			static void Main(string[] args)
			{
				double x = 0, y = 0, r = 0;
				try
				{
					Console.Out.Write("To input x: ");
					x = double.Parse(Console.ReadLine());
				}
				catch (Exception e)
				{
					Console.Out.Write(e);
				}
				try
				{
					Console.Out.Write("To input y: ");
					y = double.Parse(Console.ReadLine());
				}
				catch (Exception e)
				{
					Console.Out.Write(e);
				}
				try
				{
					do
					{
						Console.Out.Write("To input r: ");
						r = double.Parse(Console.ReadLine());
					} while (r < 0);
				}
				catch (Exception e)
				{
					Console.Out.Write(e);
				}


				Globular C = new Globular(x, y, r);
				C.View();
				Console.Out.WriteLine("The tich: {0:F3}, Dien tich: {1:F3}", C.TheTich(), C.DienTich());
				Console.ReadLine();
			}
		}
	}

}