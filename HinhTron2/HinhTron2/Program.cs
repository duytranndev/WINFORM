using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HinhTron2
{
	class Program
	{
		public class Point
		{
			private double x, y;

			public Point()
			{
				this.x = this.y = 0;
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
			public void ViewPoint()
			{
				Console.Out.WriteLine("x: {0}\t,y: {1}\t", this.x, this.y);
		
			}

		}
		class Cycle: Point
		{
			private double r;

			public Cycle(double x, double y, double r) : base(x, y)
			{
				this.r = r;
			}
			public double Circumference()
			{
				return 2 * r * Math.PI;
			}
			public double Area()
			{
				return Math.Pow(r, 2) * Math.PI;
			}
			public new void ViewPoint()
			{
				base.ViewPoint();
				Console.Out.Write("\tr:{0}\n", this.r);
			}
		}

		class Cylinder : Cycle
		{
			private double h;

			public Cylinder(double x, double y, double r, double h) : base(x, y, r)
			{
				this.h = h;
			}
			public double Volume()
			{
				return h * this.Area();
			}
			public double Circum_Cylinder()
			{
				return 2 * Area() + Circumference() * h;
			}

			public new void ViewPoint()
			{
				base.ViewPoint();
				Console.Out.Write("\th:{0}\n", this.h);
			}

		}

		static void Main(string[] args)
		{
			double x = 0, y = 0, r = 0, h = 0;
			try
			{
				Console.Out.Write("To input x: ");
				x = double.Parse(Console.ReadLine());
			}
			catch(Exception e)
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
			catch(Exception e)
			{
				Console.Out.Write(e);
			}
			try
			{
				do
				{
					Console.Out.Write("To input h: ");
					h = double.Parse(Console.ReadLine());
				} while (h < 0);
			}
			catch (Exception e)
			{
				Console.Out.Write(e);
			}

			Cylinder C = new Cylinder(x, y, r, h);
			C.ViewPoint();
			Console.Out.WriteLine("Chu vi: {0:F3}, Dien tich: {1:F3}", C.Circum_Cylinder(), C.Volume());
			Console.ReadLine();

		}
	}
}
