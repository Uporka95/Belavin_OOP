using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9
{
	class Program
	{
		static void Main(string[] args)
		{
			Random rnd = new Random();
			Triangle tr1 = new Triangle(6, 5, 3);
			Triangle tr2 = new Triangle(2, 2, 3);
			Triangle tr3 = new Triangle(rnd);
			Triangle tr4 = new Triangle(rnd);
			Console.WriteLine();

			Console.WriteLine($@"Треугольник {tr1.ID}:
Сторона А:	{tr1.A}
Сторона B:	{tr1.B}
Сторона C:	{tr1.C}
Площадь:	{tr1.getSquare()}
");

			Console.WriteLine($"Площадь треугольника {tr1.ID} равна {Triangle.getSquare(tr1)} (Статическая функция)\n");
			Console.WriteLine($"Всего треугольников создано: {Triangle.Count}");

			//Console.WriteLine((double)tr1);

			TriangleArray arr = new TriangleArray(3, TriangleArray.FillByConsole);
			int id_min = arr.MinSqare();
			Console.WriteLine($"Треугольник {id_min} имеет минимальную площадь: {arr[id_min].getSquare()}");

			Console.WriteLine($"Треугольников создано: {Triangle.Count}");
		}
	}
}
