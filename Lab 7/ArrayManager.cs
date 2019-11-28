using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab_7
{
	static class ArrayManager
	{
		static Random rnd = new Random();

		static public int[] Create1DArr(bool manual_entry = false)
		{
			int[] arr = new int[rnd.Next(50)];
			int res;

			for (int i = 0; i < arr.Length; i++)
			{
				if (manual_entry)
				{
				}
				else arr[i] = rnd.Next(50);
			}

			return arr;
		}

		static public int[,] Create2DArr(int str, int col, bool manual_entry = false)
		{
			int[,] arr = new int[str, col];
			int res;

			for (int i = 0; i < str; i++)
				for (int j = 0; j < col; j++)
					if (manual_entry)
					{
					}
					else arr[i, j] = rnd.Next(50);


			return arr;
		}

		static public int[][] CreateJagArr(int col, bool manual_entry = false)
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
					}
					else arr[i][j] = rnd.Next(0, 50);
			}

			return arr;
		}

		static public int Mean(params int[] values)
		{
			int res = 0;

			foreach (var item in values)
			{
				res += item;
			}

			return res /= values.Length;
		}


		static public bool DeleteMean(ref int[] arr)
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

		static public void AddCol2D(ref int[,] arr)
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

		static public List<int> FindK(int[][] arr, int k)
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

		static public bool DelStrJag(ref int[][] arr, int k)
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

		static public string PrintArray(int[] arr)
		{
			if (arr == null) return "";
			StringBuilder str = new StringBuilder();

			foreach (var item in arr)
			{
				str.AppendFormat("{0,3} ", item);
			}
			return str.ToString();
		}

		static public string PrintArray(int[][] arr)
		{
			if (arr == null) return "";
			StringBuilder str = new StringBuilder();

			foreach (int[] i in arr)
			{
				foreach (int j in i)
				{
					str.AppendFormat("{0,3} ", j);
				}
				str.AppendLine();
			}
			return str.ToString();

		}

		static public string PrintArray(int[,] arr)
		{
			if (arr == null) return "";
			StringBuilder str = new StringBuilder();

			for (int i = 0; i < arr.GetLength(0); i++)
			{
				for (int j = 0; j < arr.GetLength(1); j++)
				{
					str.AppendFormat("{0,-3} ", arr[i, j]);
				}
				str.AppendLine();
			}
			return str.ToString();
		}

		static private bool Null<T>(T obj)
		{
			if (obj == null)
			{
				MessageBox.Show("Массив пуст!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return true;
			}
			return false;
		}

		static public int [,] ParseAs2D(string str)
		{
			string[] rows = str.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
			if (str.Length == 0) return null;
			string[] values_buf = rows[0].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
			int[,] arr = new int[rows.Length, values_buf.Length];

			for (int i = 0; i < arr.GetLength(0); i++)
			{
				rows[i] = rows[i].Trim('\n');
				values_buf = rows[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

				for (int j = 0; j < arr.GetLength(1); j++)
					arr[i, j] = Convert.ToInt32(values_buf[j]);
			}

			return arr;
		}

		static public int[] ParseAs1D(string str)
		{
			if (str.Length == 0) return null;
			string[] values = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
			int[] arr = new int[values.Length];

			for (int i = 0; i < arr.GetLength(0); i++)
					arr[i] = Convert.ToInt32(values[i]);
			

			return arr;
		}

		static public int[][] ParseAsJag(string str)
		{
			if (str.Length == 0) return null;
			string[] rows = str.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);

			string[] values_buf = rows[0].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
			int[][] arr = new int[rows.Length][];

			for (int i = 0; i < arr.GetLength(0); i++)
			{
				rows[i] = rows[i].Trim('\n');
				values_buf = rows[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
				arr[i] = new int[values_buf.Length];

				for (int j = 0; j < arr[i].Length; j++)
					arr[i][j] = Convert.ToInt32(values_buf[j]);
			}

			return arr;
		}
	}
}
