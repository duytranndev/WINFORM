using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFPTB2_OutSideClass
{
	class PhuongTrinh
	{
		private double a, b, c, x1, x2, x, delta;

		public PhuongTrinh(double a, double b, double c)
		{
			this.A = a;
			this.B = b;
			this.C = c;
		}

		public double A { get => a; set => a = value; }
		public double B { get => b; set => b = value; }
		public double C { get => c; set => c = value; }
		public double X1 { get => x1; set => x1 = value; }
		public double X2 { get => x2; set => x2 = value; }
		public double X { get => x; set => x = value; }
		public double Delta { get => delta; set => delta = value; }

		public int GiaiPt()
		{
			if (this.a == 0)
			{
				if (this.b == 0)
				{
					if (this.c == 0)
					{
						return 0;
					}
					else
					{
						return 1;
					}
				}
				else
				{
					this.x = -this.c / this.b;
					return 2;
				}
			}
			else
			{
				double delta;
				delta = Math.Pow(b, 2) - 4 * a * c;
				if (delta < 0)
				{
					this.delta = Math.Sqrt(-delta);
					return 3;
				}
				else if (delta == 0)
				{
					this.x1 = this.x2 = -this.b / (2 * this.a);
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
	}
}
