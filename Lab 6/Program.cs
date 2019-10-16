using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{

	

	class Program
	{
		static char[] vowels = {'А','а','Е','е','И','и','О','о','У','у','Э','э','Ю','ю','Я','я'};
		static Random rnd = new Random();

		static void Main(string[] args)
		{
			char[] str = Create1DArr(10);
			PrintArray(str);
			DelLastVowel(ref str);
			PrintArray(str);
		}

		

	static void DelLastVowel(ref char[] arr)
	{
		int ind = 0, new_ind;
		foreach (char letter in vowels)
		{
			new_ind = Array.LastIndexOf(arr, letter);
			if( ind < new_ind )
				ind = new_ind;
		}	

		char[] new_arr = new char[arr.Length - 1];
				for (int i = 0, j = 0; i < new_arr.Length; ++i, ++j)
				{
					if (arr[j] == ind)
					{
						j++;
					}

					new_arr[i] = arr[j];
				}
		arr = new_arr;
	}

	static char[] Create1DArr(int size, bool manual_entry = false)
		{
			char[] arr = new char[size];
			char res = 'А';

			for (int i = 0; i < size; i++)
			{
				arr[i] = (char)(res + rnd.Next(63));
			}

			return arr;
		}

	static void PrintArray(char[] arr)
		{
			foreach (var item in arr)
			{
				Console.Write("{0,3} ", item);
			}
			Console.WriteLine();
		}
	}

	
}
