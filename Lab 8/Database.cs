using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Lab_8
{
	public enum Position
	{
		ToBegin, ToEnd
	}



	[Serializable]
	public class Book
	{
		public Book(string name, string author, string editor, DateTime edition) 
		{
			Name = name;
			Author = author;
			Editor = editor;
			Edition = edition;
			num++;
		}

		public string Name { get; set; }
		public string Author { get; set; }
		public string Editor { get; set; }
		public DateTime Edition { get; set; }

		[NonSerialized]
		static int num;
	}
	public static class Database
	{

		public static List<Book> database = new List<Book>();
		public static string PathToBin { set; get; }

		public static bool ReadData(string path)
		{
			PathToBin = path;
			
			FileStream fs = new FileStream(PathToBin, FileMode.OpenOrCreate, FileAccess.ReadWrite);
			BinaryFormatter bf = new BinaryFormatter();
			if (fs.Length != 0)
			{
				database = (List<Book>)bf.Deserialize(fs);
				fs.Close();
			}
			else return false;
			fs.Close();
			return true;
		}

		static public bool OverwriteData(string path)
		{
			if(!File.Exists(path)) File.Create(path);
			FileStream fs = new FileStream(path, FileMode.Truncate);
			BinaryFormatter bf = new BinaryFormatter();

			bf.Serialize(fs, database);
			fs.Close();
			return true;
		}

		public static void Add(Book book, Position pos)
		{
			if (pos == Position.ToBegin) database.Insert(0, book);
			if (pos == Position.ToEnd) database.Add(book);
			//FindByParam((x, y) => { if (x.Author == y) return true; return false; });
			
		}
		public static void Add(Book book, int pos)
		{
			database.Insert(pos, book);
			
			//FindByParam((x, y) => { if (x.Author == y) return true; return false; });

		}

		public static bool DeleteByPos(int pos)
		{
			if (pos + 1 > database.Count) return false;
			database.RemoveAt(pos);
			return true;
		}

		public static bool DeleteByName(string name)
		{
			bool found = false;
			foreach (Book item in database.ToArray())
			{
				if (item.Name == name)
				{
					database.Remove(item);
					found = true;
				}
			}
			return found;
		}


		public static List<Book> FindByAuthor(string str)
		{

			IEnumerable<Book> selectedBooks = from i in database where i.Author == str select i;
			var list = new List<Book>(selectedBooks);
			if (list.Count == 0) return null;
			return new List<Book>(selectedBooks);
		}

		public static List<Book> FindByName(string str)
		{

			IEnumerable<Book> selectedBooks = from i in database where i.Name == str select i;
			var list = new List<Book>(selectedBooks);
			if (list.Count == 0) return null;
			return new List<Book>(selectedBooks);
		}

		public static List<Book> FindByEditor(string str)
		{
			IEnumerable<Book> selectedBooks = from i in database where i.Editor == str select i;
			var list = new List<Book>(selectedBooks);
			if (list.Count == 0) return null;
			return new List<Book>(selectedBooks);
		}

		public static List<Book> FindByDate( DateTime min, DateTime max)
		{

			IEnumerable<Book> selectedBooks = from i in database
								where DateInRange(min,max,i.Edition)
								select i;

			var list = new List<Book>(selectedBooks);
			if (list.Count == 0) return null;
			return new List<Book>(selectedBooks);
		}

		public static bool DateInRange(DateTime min, DateTime max, DateTime x)
		{
			if (min.CompareTo(x) <= 0 && max.CompareTo(x) >= 0)
				return true;
			return false;

			
		}
	}
}
