using System;

namespace phanso1._1
{
	using System;

	
		class Program
		{
			public class Fraction
			{
				private int numerator;
				private int denominator;

				public Fraction()
				{

				}


				public int Get_numeration()
				{
					return this.numerator;
				}
				public void Set_numeration(int numeration)
				{
					this.numerator = numerator;
				}
				public int Get_denominator()
				{
					return this.denominator;
				}
				public void Set_denominator(int denominator)
				{
					this.denominator = denominator;
				}
				public void Input()
				{
					try
					{
						Console.Out.Write("To input numerator: ");
						this.numerator = int.Parse(Console.ReadLine());
					}
					catch (Exception e)
					{
						Console.Out.Write(e);
					}

					try
					{
						do
						{
							Console.Out.Write("To input denominator: ");
							this.denominator = int.Parse(Console.ReadLine());
						} while (this.denominator == 0);
					}
					catch (Exception e)
					{
						Console.Out.Write(e);
					}
				}

				public void Output()
				{
					Console.Out.WriteLine("{0} / {1}", this.numerator, this.denominator);
				}
			}

			static int UCLN(int a, int b)
			{
				a = Math.Abs(a);
				b = Math.Abs(b);
				if (a == 0) return b;
				if (b == 0) return a;
				while (a != b)
				{
					if (a > b)
					{
						a = a - b;
					}
					else
					{
						b = b - a;
					}
				}
				return a;
			}

			static Fraction Multi(Fraction A, Fraction B)
			{
				Fraction C = new Fraction();
				int numeration, denominator, UC;
				numeration = A.Get_numeration() * B.Get_numeration();
				denominator = A.Get_denominator() * B.Get_denominator();
				UC = UCLN(numeration, denominator);
				numeration = numeration / UC;
				denominator = denominator / UC;
				C.Set_numeration(numeration);
				C.Set_denominator(denominator);

				return C;
			}

			static Fraction Division(Fraction A, Fraction B)
			{
				Fraction C = new Fraction();
				int numeration, denominator, UC;
				numeration = A.Get_numeration() * B.Get_denominator();
				denominator = A.Get_denominator() * B.Get_numeration();
				UC = UCLN(numeration, denominator);
				numeration = numeration / UC;
				denominator = denominator / UC;
				C.Set_numeration(numeration);
				C.Set_denominator(denominator);

				return C;

			}

			static Fraction Subtraction(Fraction A, Fraction B)
			{
				Fraction C = new Fraction();
				int numeration, denominator, UC;
				numeration = A.Get_numeration() * B.Get_denominator() - A.Get_denominator() * B.Get_numeration();
				denominator = A.Get_denominator() * B.Get_denominator();
				UC = UCLN(numeration, denominator);
				numeration = numeration / UC;
				denominator = denominator / UC;
				C.Set_numeration(numeration);
				C.Set_denominator(denominator);

				return C;
			}

			static Fraction Sum(Fraction A, Fraction B)
			{
				Fraction C = new Fraction();
				int numeration, denominator, UC;
				numeration = A.Get_numeration() * B.Get_denominator() + A.Get_denominator() * B.Get_numeration();
				denominator = A.Get_denominator() * B.Get_denominator();
				UC = UCLN(numeration, denominator);
				numeration = numeration / UC;
				denominator = denominator / UC;
				C.Set_numeration(numeration);
				C.Set_denominator(denominator);

				return C;
			}

			public static Fraction A = new Fraction();
			public static Fraction B = new Fraction();
			public static Fraction C = new Fraction();
			public static Fraction D = new Fraction();
			public static Fraction E = new Fraction();
			public static Fraction F = new Fraction();

			static void Main(string[] args)
			{
				A.Input();
				A.Output();
				B.Input();
				B.Output();
				C = Multi(A, B);
				Console.Out.Write("Tich A,B: ");
				C.Output();
				D = Division(A, B);
				Console.Out.Write("Thuong A,B: ");
				D.Output();
				E = Subtraction(A, B);
				Console.Out.Write("Hieu A,B: ");
				E.Output();
				F = Sum(A, B);
				Console.Out.Write("Tong A,B: ");
				F.Output();
			}
		}
	}


