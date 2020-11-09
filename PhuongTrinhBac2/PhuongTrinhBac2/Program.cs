using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhuongTrinhBac2
{
	class Program
	{
		static double a, b, c,x1,x2;

		static double giai_PT(double a,double b,double c,ref double x1,ref double x2)
		{
			if (a == 0)
				if (b == 0)
					if (c == 0)
					{
						Console.Out.Write("PTVSN");
						return 0;
					}
					else
					{
						Console.Out.Write("ptvn");
						return 1;
					}
				else {
					x1 = -c / b;
					Console.Out.Write("PT bac nhat : x=" + x1);
					return 2;
				}
			else
			{
				double delta;
				delta = Math.Pow(b, 2) - 4 * a * c;
				if (delta < 0)
				{
					Console.Out.Write("PT vo nghiem thuc");
					return 3;

				}
				else if (delta == 0)
				{
					x1 = -b / (2 * a);
					x2 = x1;
					Console.Out.Write("PT co nghiem kep x1 = x2 = " + x1);
					return 4;
				}
				else
				{
					x1 = (-b + Math.Sqrt(delta)) / (2 * a);
					x2 = (-b - Math.Sqrt(delta)) / (2 * a);

					return 5;
				}
			}
		}

		static void Main(string[] args)
		{
			Console.Out.Write("a = ");
			a = (double)Double.Parse(Console.ReadLine());
			Console.Out.Write("b = ");
			b = (double)Double.Parse(Console.ReadLine());
			Console.Out.Write("c = ");
			c = (double)Double.Parse(Console.ReadLine());
			giai_PT(a, b, c, ref x1, ref x2);

			Console.Out.Write("phuong trinh co 2 nghiem phan biet:\n x1 = {0:F2}, \t x2 = {1:F2} ", x1, x2);
			Console.ReadLine();
		}
	}
}
