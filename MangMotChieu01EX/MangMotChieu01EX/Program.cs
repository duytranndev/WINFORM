using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangMotChieu01EX
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
				Console.Out.Write("M[{0}] = {1}" + "\t", i, M[i]);
				Console.Out.WriteLine();
			}
		}

		static void sortArr()
		{
			int i, j;
			for (i = 0; i < size; i++)
			{
				for (j = i + 1; j < size; j++)
				{
					if (M[j] < M[i])
					{
						M[j] = M[i] ^ M[j] ;
						M[j] = M[j] ^ M[i];
						M[i] = M[i] ^ M[j];
					}
				}
			}
		}

		static void chanLe()
		{
			int i, j;
			i = 0;j = size - 1;
			while (i < j)
			{
				if (M[i] % 2 == 0 && M[j] % 2 != 0)
				{
					i++;
					j--;
				}
				else if (M[i] % 2 == 0 && M[j] % 2 == 0) i++;
				else if (M[i] % 2 != 0 && M[j] % 2 == 0)
				{
					M[j] = M[i] ^ M[j];
					M[j] = M[j] ^ M[i];
					M[i] = M[i] ^ M[j];

					i++; j--;
				}
				else if (M[i] % 2 != 0 && M[j] % 2 != 0) j--;
			}	
		}

		//static void sortchanle()
		//{
		//	int i, j, k;
		//	for (i = 0; i < size - 1; i++) if (m[i] % 2 != 0) break;
		//	k = i;
		//	for (i = 0; i < k - 1; i++)
		//		for (j = i + 1; j < k; j++)
		//			if (m[j] < m[i])
		//			{

		//			}

		//}


		static void them()
		{
			Console.Out.Write("Moi ban nhap vi tri can them vao: ");
			int k = int.Parse(Console.ReadLine());
			Console.Out.Write("Moi ban nhap vao gia tri muon them: ");
			int x = int.Parse(Console.ReadLine());
			
			for(int i=size; i > k + 1; i--)
			{
				M[i] = M[i - 1];
			}
			M[k] = x;
			size++;
		}

		static void xoaViTri()
		{
			Console.Out.Write("Moi ban nhap vi tri muon xoa: ");
			int k = int.Parse(Console.ReadLine());

			for(int i=k; i < size; i++)
			{
				M[i] = M[i + 1];
			}
			size--;
		}

		static void xoaPhanTu()
		{
			Console.Out.Write("moi ban nhap phan ti muon xoa: ");
			int x = int.Parse(Console.ReadLine());

			for(int i = 0; i < size; i++)
			{
				if (M[i] == x)
				{
					M[i] = M[i + 1];
				}
			}
			size--;
		}

		static void timKiem()
		{
			Console.Out.Write("Moi ban nhap gia tri muon tim: ");
			int x =
		}


		static void Main(string[] args)
		{
			
		}
	}
}
