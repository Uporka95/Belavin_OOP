using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{



	class Program
	{
		static string mainMenuText = @"1. Работа с массивом символов
2. Работа со строками
3. Выход";

		static string dialog_1d = @"1. Cоздать массив
2. Вывести массив
3. Удалить последнюю гласную
4. Назад";


		static string dialog_str = @"1. Ввести предложение
2. Вывести предложение
3. Поменять первое и последнее предложение местами
4. Назад";

		static string dialog_input = @"1. Ввод массива вручную
2. Инициализация при помощи ДСЧ";

		static string sentence = "Надстройка нетривиальна. Созерцание непредсказуемо. Структурализм абстрактен.";

		static char[] vowels = { 'А', 'а', 'Е', 'е', 'И', 'и', 'О', 'о', 'У', 'у', 'Э', 'э', 'Ю', 'ю', 'Я', 'я' };
		static Random rnd = new Random();

		static string str;

		static void Main(string[] args)
		{
			MainMenu();
			char[] str = Create1DArr(10);
			PrintArray(str);
			DelLastVowel(ref str);
			PrintArray(str);
		}



		static bool DelLastVowel(ref char[] arr)
		{
			int ind = -1, new_ind;
			foreach (char letter in vowels)
			{
				new_ind = Array.LastIndexOf(arr, letter);
				if (ind < new_ind)
					ind = new_ind;
			}

			if (ind == -1) return false;

			char[] new_arr = new char[arr.Length - 1];
			for (int i = 0, j = 0; i < new_arr.Length; ++i, ++j)
			{
				if (j == ind)
				{
					j++;
				}

				new_arr[i] = arr[j];
			}
			arr = new_arr;
			return true;
		}

		static char[] Create1DArr(int size, bool manual_entry = false)
		{
			char[] arr = new char[size];

			char res = 'А';

			for (int i = 0; i < size; i++)
			{
				if (manual_entry)
				{
					Console.Write($"[{i}]: ");
					ReadChar(out res);
					arr[i] = res;
				}
				else arr[i] = (char)(res + rnd.Next(63));
			}


			return arr;
		}
		static void PrintArray<T>(T[] arr)
		{
			foreach (var item in arr)
			{
				Console.Write("{0,3} ", item);
			}
			Console.WriteLine();
		}
		static void ReadInt(out int res)
		{
			while (!int.TryParse(Console.ReadLine(), out res))
				Console.WriteLine("Ошибка ввода. Повторите.");
		}
		static void ReadChar(out char res)
		{
			while (!char.TryParse(Console.ReadLine(), out res))
				Console.WriteLine("Ошибка ввода. Повторите.");
		}
		static void Ch1DArr()
		{
			char[] arr = null;
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
						int size;
						ReadInt(out size);
						Console.Clear();
						arr = Create1DArr(size, ManualEntryDialog());
						Console.Clear();
						Console.WriteLine("Массив создан \n");
						break;

					case ConsoleKey.D2:
						Console.Clear();
						PrintArray(arr);
						break;

					case ConsoleKey.D3:
						Console.Clear();
						if (DelLastVowel(ref arr))
							Console.WriteLine("Гласная удалена");
						else Console.WriteLine("В слове нет гласных \n");
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
						Ch1DArr();
						break;

					case ConsoleKey.D2:
						Console.Clear();
						ChStrings();
						break;

					case ConsoleKey.D3:
						Environment.Exit(0);
						break;

				}
			}
		}
		static void ChStrings()
		{
			while (true)
			{
				Console.WriteLine(dialog_str);

				ConsoleKey choice;
				choice = Console.ReadKey().Key;

				switch (choice)
				{
					case ConsoleKey.D1:
						Console.Clear();
						int num=0;
						bool man_entry = ManualEntryDialog();
						if (man_entry)
						{
							Console.Write("Кол-во предложений в строке: ");
							ReadInt(out num);
							Console.Clear();
						}
						str = CreateString(num, man_entry);
						Console.Clear();
						Console.WriteLine("Массив создан \n");
						break;

					case ConsoleKey.D2:
						Console.Clear();
						Console.WriteLine(str);
						break;

					case ConsoleKey.D3:
						Console.Clear();
						Invert(ref str);
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
		static string CreateString(int num, bool man_entry = false)
		{
			if (!man_entry) return sentence;

			StringBuilder str = new StringBuilder();
			for(int i = 0; i < num; i++)
			{
				Console.Write($"{i}-e: ");
				string strbuf = Console.ReadLine();
				strbuf = strbuf.Trim('.');
				if (strbuf.Length == 0) 
				{
					Console.WriteLine("Строка пуста. Повторите ввод.");
					i--; 
					continue;
				}
				str.Append(strbuf);
				str.Append(".");
			}
			return str.ToString();
		}

		static void Invert(ref string str)
		{
			string sec = str.Substring(str.LastIndexOf('.',str.Length-2) +1);	// Последнее предложение
			string first = str.Remove(str.IndexOf('.') + 1);					// Первое предложение
			str = str.Replace(first, sec);										// Замена первого на последнее
			str = str.Remove(str.LastIndexOf('.', str.Length - 2) + 1);         // Удаление последнего
			str = str.Insert(str.Length, first);								// Вставка первого в конец

		}
    }



}
