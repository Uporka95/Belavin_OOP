using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;
using System.ComponentModel;

namespace Test
{

	public static class RndResource
	{

		static Random rnd = new Random();
		
		static List<string> FictionNames = new List<string>();
		static List<string> Genres;
		static List<string> Subjects;
		static List<string> MagazineNames;
		static List<string> Themes;
		static List<string> NewsNames;
		static List<string> NewsDests;
		static List<string> Editors;
		static List<string> Authors;
		static List<string> FIO;

		public static string GetRandomString(string res_name)
		{
			List<string> list = null;
			bool IsUniq = false;
			if (res_name.Contains("FIO")) IsUniq = true;

			foreach (var item in typeof(RndResource).GetRuntimeFields())
			{
				if (item.Name == res_name)
				{
					list = (List<string>)item.GetValue(null);
				}
			}
			if (list == null) throw new Exception("Указанный ресурс не найден");
				string ret = list.ElementAt(rnd.Next(0, list.Count));
			if (IsUniq) list.Remove(ret);

			return ret;
		}


		static public string Path { get; set; } = "";
		static string extension = ".txt";
		static RndResource()
		{
			//FilesExists();
			//FictionNames = GetFrom("FictionNames.txt");
			//TextbooksNames = GetFrom("TextbookNames.txt");
			//Genres = GetFrom("Genres.txt");
			//Subjects = GetFrom("Subjects.txt");
			//MagazineNames = GetFrom("MagazineNames.txt");
			//NewsNames = GetFrom("NewsNames.txt");
			//NewsDests = GetFrom("NewsDests.txt");
			foreach (var item in typeof(RndResource).GetRuntimeFields())
			{
				var i = item.FieldType.Name;
				var f = FictionNames.GetType().Name;
				if (i == f)
					item.SetValue(null, GetFrom(item.Name + extension));
			}
		}

		static void FilesExists()
		{
			foreach (var item in typeof(RndResource).GetRuntimeFields())
			{
				var i = item.FieldType.Name;
				var f = FictionNames.GetType().Name;
				if (i == f)
					if (!File.Exists(Path + item.Name)) File.Create(Path + item.Name + extension).Dispose();
			}

		}

		private static List<string> GetFrom(string filename)
		{
			string buf;
			List<string> newlist = new List<string>();
			StreamReader reader = new StreamReader(Path + filename);

			do
			{
				buf = reader.ReadLine();
				if (buf != null) newlist.Add(buf);
			} while (buf != null);


			return newlist;
		}
	}
}
