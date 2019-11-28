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
	public struct Book
	{
		public Book(string name, string author, string editor, string edition) 
		{
			Name = name;
			Author = author;
			Editor = editor;
			Edition = DateTime.Parse(edition);
		}

		public string Name { get; set; }
		public string Author { get; set; }
		public string Editor { get; set; }
		public DateTime Edition { get; set; }

		[NonSerialized]
		static string num;
	}
	public static class Database
	{

		static List<Book> database = new List<Book>();
		static string PathToBin { set; get; }

		public static void ReadData(string path)
		{
			PathToBin = path;
			Book buf;
			FileStream fs = new FileStream(PathToBin, FileMode.Open);
			BinaryFormatter bf = new BinaryFormatter();

			while (true)
			{
				buf = (Book)bf.Deserialize(fs);
				if (buf.Author == null) break;
				database.Add(buf);
			}
		}

		static void OverwriteData()
		{
			FileStream fs = new FileStream(PathToBin, FileMode.Truncate);
			BinaryFormatter bf = new BinaryFormatter();

			foreach (Book item in database)
			{
				bf.Serialize(fs, item);
			}
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

		public static void DeleteByPos(int pos)
		{
			database.RemoveAt(pos);
		}

		public static void DeleteByName(string name)
		{
			foreach (Book item in database)
			{
				if (item.Name == name) database.Remove(item);
			}
		}


		public static void FindByAuthor(string str)
		{

			var selectedBooks = from i in database where i.Author == str select i;

		}

		public static void FindByDate( DateTime min, DateTime max)
		{

			//var selectedBooks = from i in database where (
			//					select i;

		}
	}
}
