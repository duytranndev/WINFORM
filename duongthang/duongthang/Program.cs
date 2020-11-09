using System;

namespace duongthang
{
	class Program
	{
		public class Point
		{
			private double x;
			private double y;

			public Point()
			{
				this.x = this.y = 0;
			}
			public Point(double x,double y)
			{
				this.x = x;
				this.y = y;
			}
			~Point()
			{
				this.x = 0;
				this.y = 0;
			}
			public double GetX()
			{
				return this.x;
			}
			public double GetY()
			{
				return this.y;
			}
			public void ViewPoint()
			{
				Console.Out.WriteLine("x: {0}\ty: {1}\t", this.x, this.y);
			}
		}

		public class Line
		{
			private Point A = new Point();
			private Point B = new Point();
			public Line(Point A,Point B)
			{
				this.A = A;
				this.B = B;
			}
			public double GetLine()
			{
				return Math.Sqrt(Math.Pow(A.GetX() - B.GetX(), 2) + Math.Pow(A.GetY() - B.GetY(), 2));
			}
			public void ViewLine()
			{
				A.ViewPoint();
				B.ViewPoint();
			}
		}
		static Point A = new Point(0, 0);
		static Point B = new Point(3, 2);
		static Line L = new Line(A, B);

		static void Main(string[] args)
		{
			L.ViewLine();
			Console.Out.WriteLine("Length: {0:F3}", L.GetLine());
			Console.ReadLine();
		}
	}
}
