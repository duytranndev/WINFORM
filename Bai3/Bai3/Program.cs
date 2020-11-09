using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
	class Program
	{
		static double a, b, c, x;

		static int giai_PT(double a, double b, ref double x)
		{
			if (a == 0)
			{
				if (b == 0) return 0;
				else return 1;
			}
			else
			{
				x = -b / a;
				return 2;
			}

		}
		static void Main(string[] args)
		{
			Console.Out.Write("a=");
			a = (double)Double.Parse(Console.ReadLine());
			Console.Out.Write("b=");
			b = (double)Double.Parse(Console.ReadLine());
			int ok = giai_PT(a, b, ref x);

			if (ok == 0) Console.Out.WriteLine("PTVSN");
			else
			{
				if (ok == 1) Console.Out.WriteLine("PTVN");
				else Console.Out.WriteLine("PT co nghiem :x = {0:F3}\n", x);
				Console.ReadLine();
			}
		}
	}
}
