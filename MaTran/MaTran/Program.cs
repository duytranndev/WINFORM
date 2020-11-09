using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaTran
{
	class Program
	{
		static int[,] M = new int[100,100];
		static int m, n;

		static void createArr()
		{
			int i, j;

			loop_m:
			try
			{
				Console.Out.Write("m= ");
				m = int.Parse(Console.ReadLine());
			}
			catch (FormatException)
			{
				Console.Out.Write("Invalid data!!");
			}
			if (m == 0) goto loop_m;

			loop_n:
			try
			{
				Console.Out.Write("n= ");
				n = int.Parse(Console.ReadLine());
			}
			catch (FormatException)
			{
				Console.Out.Write("Invalid data!!");
			}

			if (n == 0) goto loop_n;

			for (i = 0; i < m; i++)
			{
				for (j = 0; j < n; j++)
				{
					try
					{
						Console.Out.Write("M[" + i + "," +j + "]= ");
						M[i, j] = int.Parse(Console.ReadLine());
					}
					catch (FormatException)
					{
						Console.Out.Write("Invalid data!!");
						i--;
					}
				}
			}
		}
		static void displayArr()
		{
			int i, j;
			for (i = 0; i < m; i++)
			{
				for (j = 0; j < n; j++)
				{
					Console.Out.Write( M[i, j] + "\t");
					//Console.ReadLine();
				}
			}
		}

		static void sortArr()
		{
			int i, j, k;
			int[] L = new int[100];

			for (i = 0; i < m; i++)
			{
				for (j = 0; j < n; j++)
				{
					k = i * n + j;
					L[k] = M[i, j];
				}
			}
			for(i = 0; i < m * n - 1; i++)
			{
				for(j = i + 1; j < m * n; j++)
				{
					if (L[j] < L[i])
					{
						L[i] = L[i] ^ L[j];
						L[j] = L[j] ^ L[i];
						L[i] = L[i] ^ L[j];
					}
				}
			}
			k = 0;
			while (k < m * n)
			{
				i = k / n;
				j = k - i * n;
				M[i, j] = L[k];
				k++;
			}
		}


		static void Main(string[] args)
		{
			createArr();
			displayArr();
			Console.Out.WriteLine("Mang sau khi sap xep la:");
			sortArr();
			displayArr();
			Console.Out.Write("Nhap bat ky de ket thuc");
			Console.ReadLine();

		}
	}
}
