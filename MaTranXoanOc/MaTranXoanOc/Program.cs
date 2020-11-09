using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaTranXoanOc
{
	class Program
	{
		static int [,] M = new int[100,100];

		static int m, n;

		static void createArrXoanOc()
		{
			int cot = n-1,hang=m-1;
			int dem = 0;
			int gt = 1;

			while (dem <= m * n)
			{
				for(int i = dem; i <= cot; i++)
				{
					M[dem, i] = gt++; //trái sang phải
				}
				for(int i = dem + 1; i <= hang; i++)
				{
					M[i, cot] = gt++; //trên xuống dưới
				}
				for(int i = hang-1;)
			}

		}

		static void displayArr()
		{
			int i, j;
			for (i = 0; i < m; i++)
			{
				for (j = 0; j < n; j++)
				{
					Console.Out.Write(M[i, j] + "\t");
					//Console.ReadLine();
				}
			}
		}

		

		
		static void Main(string[] args)
		{
			Console.Out.Write("Nhap m = ");
			m = int.Parse(Console.ReadLine());
			Console.Out.Write("Nhap n = ");
			n = int.Parse(Console.ReadLine());
			createArrXoanOc();
			displayArr();
		}
	}
}
