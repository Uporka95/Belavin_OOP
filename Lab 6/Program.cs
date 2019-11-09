using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{



    class Program
    {
        static string mainMenuText = @"1. Работа с одномерным массивом
2. Работа со строками
3. Выход";

        static string dialog_1d = @"1. Cоздать массив
2. Вывести массив
3. Удалить последнюю гласную
4. Назад";


        static string dialog_2d = @"1. Cоздать строку
2. Вывести строку
3. Поменять первое и последнее предложение местами
4. Назад";

        static string dialog_input = @"1. Ввод массива вручную
2. Инициализация при помощи ДСЧ";

        static char[] vowels = { 'А', 'а', 'Е', 'е', 'И', 'и', 'О', 'о', 'У', 'у', 'Э', 'э', 'Ю', 'ю', 'Я', 'я' };
        static Random rnd = new Random();

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
                    res = (char)Console.Read();
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

        static void Choice1DArr()
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
                        Choice1DArr();
                        break;

                    case ConsoleKey.D2:
                        Console.Clear();
                        break;

                    case ConsoleKey.D3:
                        Console.Clear();
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

    }



}
