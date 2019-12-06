using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9
{
	class TriangleArray
	{
		
		Triangle[] arr;

		public TriangleArray(int size, Random rnd)
		{
			arr = new Triangle[size];

			for (int i = 0; i < arr.Length; i++)
				arr[i] = new Triangle(rnd);
		}

		public TriangleArray(int size, Action<Triangle[]> fill)
		{
			arr = new Triangle[size];
			fill(arr);
		}

		static public void FillByConsole(Triangle[] array)
		{
			double buf;
			for (int i = 0; i < array.Length; i++)
			{
				Triangle tr = new Triangle();
				Console.WriteLine($"Треугольник {i}: ");

				Console.Write("катет А: ");
				while (!double.TryParse(Console.ReadLine(), out buf))
					Console.Write("Некоректный ввод, повторите: ");	
				tr.A = buf;

				Console.Write("катет B: ");
				while (!double.TryParse(Console.ReadLine(), out buf))
					Console.Write("Некоректный ввод, повторите: ");
				tr.B = buf;

				Console.Write("катет C: ");
				while (!double.TryParse(Console.ReadLine(), out buf))
					Console.Write("Некоректный ввод, повторите: ");
				tr.C = buf;

				array[i] = tr;
			}
		}

		public int MinSqare()
		{
			return Array.IndexOf(arr, arr.Min());
		}

		public Triangle this[int i]
		{
			get
			{
				return arr[i];
			}
			set
			{
				arr[i] = value;
			}
		}
	}
}
