using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9
{
	class Triangle:IComparable<Triangle>
	{
		public Triangle() {
			id = cnt++;
		}
		public Triangle(double A, double B, double C)
		{
			//if (A >= B + C || B >= A + C || C >= A + B)
			//{
			//	Console.WriteLine("Стороны заданы неверно!");
			//	return;
			//}

			a = A;
			b = B;
			c = C;
			id = cnt++;
			Console.WriteLine($"Треугольник создан (id {id})");
		}

		public int CompareTo(Triangle tr)
		{
			if (getSquare() < 0) return 1;
			if (tr.getSquare() < 0) return -1;
			return this.getSquare().CompareTo(tr.getSquare());
		}

		public Triangle(Random rnd)
		{
			a = rnd.Next(1,10);
			b = rnd.Next(1,10);
			c = rnd.Next(1, (int)(a + b - 1));
			id = cnt++;
			Console.WriteLine($"Треугольник создан (id {id})");
		}

		private int id;

		private double a;
		private double b;
		private double c;

		static private int cnt = 0;

		static public int Count
		{
			get { return cnt; }

		}


		public int ID
		{
			get { return id; }
		}

		public double A
		{
			get { return a; }
			set {
				if (b != 0 && c != 0)
					if (value >= b + c)
					{
						Console.WriteLine($" A = {value}: Сторона больше суммы остальных катетов!");
						return;
					}
				a = value;
			}
		}
		public double B
		{
			get { return b; }
			set {
				if (c != 0 && a != 0)
					if (value >= a + c)
					{
						Console.WriteLine($" B = {value}: Сторона больше суммы остальных катетов!");
						return;
					}
				b = value;
			}
		}

		public double C
		{
			get { return c; }
			set {
				if (a != 0 && b != 0)
					if (value >= a + b)
					{
						Console.WriteLine($" C = {value}: Сторона больше суммы остальных катетов!");
						return;
					}
				c = value; }
		}

		public double getSquare()
		{
			if (A >= B + C || B >= A + C || C >= A + B)
			{
				return -1;
			}
			double p = (a + b + c) / 2;
			return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
		}

		public static double getSquare(Triangle tr)
		{
			if (tr.a >= tr.b + tr.c || tr.b >= tr.a + tr.c || tr.c >= tr.a + tr.b)
			{
				return -1;
			}
			double p = (tr.a + tr.b + tr.c) / 2;
			return Math.Sqrt(p * (p - tr.a) * (p - tr.b) * (p - tr.c));
			
			
		}


		public static Triangle operator ++(Triangle tr) => new Triangle(tr.a++, tr.b++, tr.c++);
		public static Triangle operator --(Triangle tr)
		{
			if (tr.a > 1 || tr.b > 1 || tr.c > 1) return null;
			else return new Triangle(tr.a--, tr.b--, tr.c--);
		}

		//public static implicit operator double(Triangle tr)
		//{
		//		return tr.getSquare();
		//}

		//public static explicit operator bool(Triangle tr)
		//{
		//	if (tr.a >= tr.b + tr.c || tr.b >= tr.a + tr.c || tr.c >= tr.a + tr.b)
		//		return false;
		//	return true;
		//}

		public static bool operator <=(Triangle tr1, Triangle tr2) => (tr1.getSquare() <= tr2.getSquare()) ? true : false;
		public static bool operator >=(Triangle tr1, Triangle tr2) => (tr1.getSquare() >= tr2.getSquare()) ? true : false;
		public static bool operator <(Triangle tr1, Triangle tr2) => (tr1.getSquare() < tr2.getSquare()) ? true : false;
		public static bool operator >(Triangle tr1, Triangle tr2) => (tr1.getSquare() > tr2.getSquare()) ? true : false;
	}
}
