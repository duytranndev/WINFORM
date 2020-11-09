using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaTranDuongCheo
{
	class Program
	{
		static int[,] A = new int[100, 100];
		static int n;

		static void createArr()
		{
			int i, j;
		
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

			for (i = 1; i <= n; i++)
			{
				for (j = 1; j <= n; j++)
				{
					try
					{
						Console.Out.Write("M[" + i + "," + j + "]= ");
						A[i, j] = int.Parse(Console.ReadLine());
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
			for (i = 1; i <= n; i++)
			{
				for (j = 1; j <= n; j++)
				{
					Console.Out.Write(A[i, j] + "\t");
					//Console.ReadLine();
				}
			}
		}

		static void tongDuongChinh()
		{
			int i = 0,j = 0;
			int k = 1,tong = 0;

			while (k <= n * n)
			{
				tong += A[i, j];
				i++;
				j++;
				k++;
			}
			Console.Out.Write("Tong duong chinh : " + tong+"\n");
		}

		static void tongDuongPhu()
		{
			int kq = 0;
			for (int i = 1; i <= n; i++)
			{
				kq = kq + A[i,n+1-i];
			}
			Console.Out.Write("Tong duong phu: " + kq+"\n");
		}
		
		static void sortArray()
		{
			for(int i = 1; i < n; i++)
			{
				for(int j = i + 1; j <= n; j++)
				{
					if (A[j, n+1-j] < A[i, n+1-i])
					{
						int t = A[j, n + 1 - j];
						A[j, n + 1 - j] = A[i, n + 1 - i];
						A[i, n + 1 - i] = t;
					}
				}
			}
		}


		static void Main(string[] args)
		{
			createArr();
			displayArr();
			tongDuongPhu();
			tongDuongChinh();

			sortArray();
			Console.Out.WriteLine("Mang sau khi sap xep: ");
			displayArr();
			
			Console.ReadLine();
		}
	}
}
