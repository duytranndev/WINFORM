using System;

namespace sophuc
{
	class Program
	{
		public struct Complex_number
		{
			public double real;
			public double imaginary;
		}
		public static Complex_number A = new Complex_number();
		public static Complex_number B = new Complex_number();
		public static Complex_number C = new Complex_number();

		//Xem số phức
		public static void Print_Complex(Complex_number C)
		{
			Console.Write("{0:f2} + {1:f2}i\n", C.real, C.imaginary);
		}
		//nhập số phức
		public static void Write_Complex(ref Complex_number C)
		{
			try
			{
				Console.Out.Write("Real component: ");
				C.real = double.Parse(Console.ReadLine());
			}
			catch(FormatException)
			{
				Console.Out.Write("Invalid data!!");
			}

			try
			{
				Console.Out.Write("Real imaginary: ");
				C.imaginary = double.Parse(Console.ReadLine());
			}
			catch (FormatException)
			{
				Console.Out.Write("Invalid data!!");
			}
		}

		//tổng 2 số phức
		public static Complex_number Sum(Complex_number A, Complex_number B)
		{
			Complex_number C = new Complex_number();
			C.real = A.real + B.real;
			C.imaginary = A.imaginary + B.imaginary;

			return C;
		}

		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
		}
	}
}
