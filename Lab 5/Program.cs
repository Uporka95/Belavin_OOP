using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ООП_19
{
	class Program
	{
		static Random rnd;
		static string mainMenuText = @"1. Работа с одномерным массивом
2. Работа с двумерным массивом
3. Работа с рваным массивом
4. Выход";

		static string dialog_1d = @"1. Cоздать массив
2. Вывести массив
3. Удалить элемент равный среднему арифметическому
4. Назад";

		static string dialog_jag = @"1. Cоздать массив
2. Вывести массив
3. Удалить все строки содержащие k
4. Назад";

		static string dialog_2d = @"1. Cоздать массив
2. Вывести массив
3. Добавить столбец в конец
4. Назад";

		static string dialog_input = @"1. Ввод массива вручную
2. Инициализация при помощи ДСЧ";


		static void Main(string[] args)
		{
			rnd = new Random();

			MainMenu();
		}


		static void MainMenu()
		{
			while (true)
			{
				Console.WriteLine(mainMenuText);

				ConsoleKey choice;
				choice = Console.ReadKey().Key;

				switch (choice)
				{

					case ConsoleKey.D1:
						Console.Clear();
						Choice1DArr();
						break;

					case ConsoleKey.D2:
						Console.Clear();
						Choice2DArr();
						break;

					case ConsoleKey.D3:
						Console.Clear();
						ChoiceJagArr();
						break;

					case ConsoleKey.D4:
						Environment.Exit(0);
						break;

					default:
						Console.Clear();
						break;
				}
			}
		}

		static void Choice1DArr()
		{
			int[] arr = null;
			while (true)
			{
				Console.WriteLine(dialog_1d);


				ConsoleKey choice;
				choice = Console.ReadKey().Key;

				switch (choice)
				{

					case ConsoleKey.D1:
						Console.Clear();
						Console.Write("Размер массива: ");
						ReadInt(out int size);
						Console.Clear();
						arr = Create1DArr(size, ManualEntryDialog());
						Console.Clear();
						Console.WriteLine("Массив создан \n");
						break;

					case ConsoleKey.D2:
						Console.Clear();
						if (arr != null)
						{
							PrintArray(arr);
							Console.WriteLine();
						}
						else Console.WriteLine("Массив пуст \n");
						break;

					case ConsoleKey.D3:
						Console.Clear();

						if (arr != null)
						{
							Console.WriteLine($"Среднее арифметичекое равно {Mean(arr)}");
							if (DeleteMean(ref arr))
								Console.WriteLine("Элемент удален");
							else Console.WriteLine("Элемент не найден");
						}
						else
							Console.WriteLine("Массив пуст. Элемент не удален. ");

						break;

					case ConsoleKey.D4:
						Console.Clear();
						return;

					default:
						Console.Clear();
						break;

				}
			}
		}

		static bool ManualEntryDialog()
		{
			Console.WriteLine(dialog_input);

			ConsoleKey choice;
			choice = Console.ReadKey().Key;

			bool f = false;
			switch (choice)
			{

				case ConsoleKey.D1:
					Console.Clear();
					f = true;
					break;

				case ConsoleKey.D2:
					f = false;
					break;

				default:
					Console.Clear();
					break;
			}
			Console.Write('\b');

			return f;
		}

		static void Choice2DArr()
		{
			int[,] arr = null;
			while (true)
			{
				Console.WriteLine(dialog_2d);
				ConsoleKey choice;
				choice = Console.ReadKey().Key;

				switch (choice)
				{

					case ConsoleKey.D1:

						Console.Clear();
						Console.Write("Размер массива: \n");
						var size = (col: 0, str: 0);

						Console.Write("Кол-во строк: ");
						ReadInt(out size.str);

						Console.Write("Кол-во столбцов: ");
						ReadInt(out size.col);

						Console.Clear();
						arr = Create2DArr(size.str, size.col, ManualEntryDialog());

						Console.Clear();
						Console.WriteLine("Массив создан \n");
						break;

					case ConsoleKey.D2:
						Console.Clear();
						if (arr != null)
						{
							PrintArray(arr);
							Console.WriteLine();
						}
						else Console.WriteLine("Массив пуст \n");
						break;

					case ConsoleKey.D3:
						Console.Clear();

						if (arr != null)
						{
							AddCol2D(ref arr);
							Console.WriteLine("Колонка добавлена \n");
						}
						else
							Console.WriteLine("Массив пуст. Колонка не добавлена.");

						break;

					case ConsoleKey.D4:
						Console.Clear();
						return;

					default:
						Console.Clear();
						break;
				}
			}
		}

		static void ChoiceJagArr()
		{
			int[][] arr = null;
			while (true)
			{
				Console.WriteLine(dialog_jag);


				ConsoleKey choice;
				choice = Console.ReadKey().Key;

				switch (choice)
				{

					case ConsoleKey.D1:
						Console.Clear();
						Console.Write("Размер массива: ");

						ReadInt(out int size);

						Console.Clear();
						arr = CreateJagArr(size, ManualEntryDialog());
						Console.Clear();

						Console.WriteLine("Массив создан \n");
						break;

					case ConsoleKey.D2:
						Console.Clear();
						if (arr != null)
						{
							PrintArray(arr);
							Console.WriteLine();
						}
						break;

					case ConsoleKey.D3:

						Console.Clear();
						Console.Write("Введите k: ");
						ReadInt(out int k);
						if (arr != null)
						{
							if (DelStrJag(ref arr, k))
								Console.WriteLine("Строки содержащие k удалены.");
							else Console.WriteLine("Элемент k не найден");
						}
						else
							Console.WriteLine("Массив пуст. Элемент не удален.");

						break;

					case ConsoleKey.D4:
						Console.Clear();
						return;

					default:
						Console.Clear();
						break;
				}
			}
		}

		static void ReadInt(out int res)
		{
			while (!int.TryParse(Console.ReadLine(), out res))
				Console.WriteLine("Ошибка ввода. Повторите.");
		}

		static int[] Create1DArr(int size, bool manual_entry = false)
		{
			int[] arr = new int[size];
			int res;

			for (int i = 0; i < size; i++)
			{
				if (manual_entry)
				{

					Console.Write($"[{i}]: ");
					ReadInt(out res);
					arr[i] = res;

				}
				else arr[i] = rnd.Next(50);
			}

			return arr;
		}

		static int[,] Create2DArr(int str, int col, bool manual_entry = false)
		{
			int[,] arr = new int[str, col];
			int res;

			for (int i = 0; i < str; i++)
				for (int j = 0; j < col; j++)
					if (manual_entry)
					{

						Console.Write($"[{i},{j}]: ");
						ReadInt(out res);
						arr[i, j] = res;
					}
					else arr[i, j] = rnd.Next(50);


			return arr;
		}

		static int[][] CreateJagArr(int col, bool manual_entry = false)
		{
			int[][] arr = new int[col][];
			int res;

			for (int i = 0; i < col; i++)
			{
				int col_len = rnd.Next(5, 10);
				arr[i] = new int[col_len];

				for (int j = 0; j < col_len; j++)
					if (manual_entry)
					{
						ReadInt(out res);
						arr[i][j] = res;
					}
					else arr[i][j] = rnd.Next(0, 50);
			}

			return arr;
		}

		static void PrintArray(int[] arr)
		{
			foreach (var item in arr)
			{
				Console.Write("{0,3} ", item);
			}
			Console.WriteLine();
		}

		static void PrintArray(int[][] arr)
		{
			foreach (int[] i in arr)
			{
				foreach (int j in i)
				{
					Console.Write("{0,3} ", j);
				}
				Console.WriteLine();
			}

		}

		static void PrintArray(int[,] arr)
		{

			for (int i = 0; i < arr.GetLength(0); i++)
			{
				for (int j = 0; j < arr.GetLength(1); j++)
				{
					Console.Write("{0,3} ", arr[i, j]);
				}
				Console.WriteLine();
			}
		}


		static int Mean(params int[] values)
		{
			int res = 0;

			foreach (var item in values)
			{
				res += item;
			}

			return res /= values.Length;
		}

		static bool DeleteMean(ref int[] arr)
		{

			bool mean_found = false;
			int mean = Mean(arr);

			for (int i = 0; i < arr.Length; ++i)
				if (arr[i] == mean) mean_found = true;


			if (mean_found)
			{
				mean_found = false;
				int[] new_arr = new int[arr.Length - 1];
				for (int i = 0, j = 0; i < new_arr.Length; ++i, ++j)
				{
					if (arr[j] == mean && !mean_found)
					{
						j++;
						mean_found = true;
					}

					new_arr[i] = arr[j];
				}

				if (new_arr.Length != 0)
					arr = new_arr;
				else
				{
					arr = null;
				}
				return true;
			}
			else return false;


		}

		static void AddCol2D(ref int[,] arr)
		{
			int[,] new_arr = new int[arr.GetLength(0), arr.GetLength(1) + 1];

			for (int i = 0; i < arr.GetLength(0); i++)
			{
				for (int j = 0; j < arr.GetLength(1); j++)
				{
					new_arr[i, j] = arr[i, j];
				}
			}

			for (int i = 0; i < new_arr.GetLength(0); i++)
			{
				new_arr[i, new_arr.GetLength(1) - 1] = rnd.Next(0, 50);
			}

			arr = new_arr;
		}

		static List<int> FindK(int[][] arr, int k)
		{

			List<int> ind = new List<int>();

			for (int i = 0; i < arr.Length; i++)
			{
				if (arr[i].Contains(k))
				{
					ind.Add(i);
					continue;
				}
			}
			return ind;
		}

		static bool DelStrJag(ref int[][] arr, int k)
		{
			int[][] new_arr;
			List<int> ind = FindK(arr, k);

			if (ind.Count == 0)
				return false;

			new_arr = new int[arr.Length - ind.Count][];


			for (int i = 0, j = 0; i < arr.Length; i++)
			{
				if (ind.Contains(i)) continue;
				new_arr[j] = new int[arr[i].Length];
				arr[i].CopyTo(new_arr[j], 0);
				j++;
			}

			if (new_arr.Length == 0)
				arr = null;
			else
				arr = new_arr;

			return true;
		}

	}


}
