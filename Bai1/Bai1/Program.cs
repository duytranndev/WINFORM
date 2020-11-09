using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
	class Program
	{
		static double r, cv, dt;
		static double chu_vi()
		{
			return 2 * r * Math.PI;
		}
		static double dien_tich()
		{
			return Math.Pow(r, 2)*Math.PI;
		}
		static void Main(string[] args)
		{
			do
			{
				Console.Out.Write("nhap ban kinh r: ");
				r = (double)Double.Parse(Console.ReadLine());
				if (r >= 0)
				{
					cv = chu_vi();
					dt = dien_tich();
					Console.Out.Write("Chu vi duong tron ban kinh " + r + "\t:" + "{0:F3},{1:F3}\n", cv,dt);
					Console.Out.Write("Dien tich duong tron ban kinh " + r + "\t:" + "{0:F3}\n", dt);
				}
			} while (r >= 0);
		}
	}
}