using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HinhTron
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
			public virtual double X
			{
				get
				{
					return this.x;
				}
				set
				{
					this.x = value;
				}
			}
			public virtual double Y
			{
				get
				{
					return this.y;
				}
				set
				{
					this.y = value;
				}
			}

			public void View()
			{
				Console.Out.Write("x:{0}\t y:{1}", this.x, this.y);
			}

		}

		class Cycle: Point
		{
			private double r;

			public Cycle(double x, double y , double r) : base(x, y)
			{
				this.r = r;
			}
			public override double X
			{
				get
				{
					return this.X;
				}
				set
				{
					base.X = value;
				}
			}
			public override double Y
			{
				get
				{
					return this.Y;
				}
				set
				{
					base.Y = value;
				}
			}
			public double Circumference()
			{
				return 2 * r * Math.PI;
			}
			public double Area()
			{
				return Math.Pow(r, 2) * Math.PI;
			}
			public new void View()
			{
				base.View();
				Console.Out.Write("\tr:{0}\n", this.r);
			}
			public double Line()
			{
				return Math.Sqrt(Math.Pow(base.X, 2) + Math.Pow(base.Y, 2));
			}
			public void Move(int new_x,int new_y)
			{
				base.X = new_x;
				base.Y = new_y;
			}

		}

		public static void Input(ref double x, ref double y)
		{
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
			catch(Exception e)
			{
				Console.Out.Write(e);
			}
		}


		static void Main(string[] args)
		{
			double x = 0, y = 0, r = 0;
			Console.WriteLine("To input co-ordinate: ");
			Input(ref x, ref y);
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
			Cycle C = new Cycle(x, y, r);
			C.View();
			Console.Out.Write("Chu vi: {0:F3}, Dien tich: {1:F3}, Khoang cach tu tam den goc toa do: {2:F3}\n",
				C.Circumference(), C.Area(), C.Line());
			Console.Out.WriteLine("To input new co-ordinate: ");
			Input(ref x, ref y);
			C.X = x;
			C.Y = y;
			C.View();
			Console.Out.Write("Chu vi: {0:F3}, Dien tich: {1:F3}, Khoang cach tu tam den goc toa do: {2:F3}\n",
				C.Circumference(), C.Area(), C.Line());
			Console.ReadLine();
		}
	}
}
