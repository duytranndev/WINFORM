using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangMotChieu
{
	class Program
	{
		static int[] M = new int[100];
		static int size;

		static void taoMang()
		{
			int i;
			loop:
			try
			{
				Console.Out.Write("n = ");
				size = int.Parse(Console.ReadLine());
			}
			catch (FormatException)
			{
				Console.Out.Write("Invalid data");
			}

			if (size == 0) goto loop;

			for (i = 0; i < size; i++)
			{
				try
				{
					Console.Out.Write("M[" + i + "] = ");
					M[i] = int.Parse(Console.ReadLine());
				}
				catch (FormatException)
				{
					Console.Out.Write("Invalid data !!");
				}
			}
		}


		static void hienThi()
		{
			int i;
			for (i = 0; i < size; i++)
			{
				Console.Out.Write("M[{0}] = {1}" + "\t",i,M[i]);
				Console.Out.WriteLine();
			}
		}


		static void Main(string[] args)
		{
			taoMang();
			hienThi();

			Console.ReadLine();
			
		}
	}
}
