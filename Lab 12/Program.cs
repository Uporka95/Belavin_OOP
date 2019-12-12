using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12
{
	class Program
	{
		static void Main(string[] args)
		{
			UList list = new UList();
			Library lib = new Library();
			Library clone = (Library)lib.Clone();
			list.Add("fff");
			list.Add("fsss");
			list.Add("aaa");
			list.Add(5);
			list.Add(0.5);
			list.Add(lib);

			Console.WriteLine("\nВывод списка:");

			foreach (object obj in list)
				Console.WriteLine(obj);

			list.Remove("fff");
			Console.WriteLine("\nУдаление элемента:");

			foreach (object obj in list)
				Console.WriteLine(obj);

			//Console.WriteLine(list.Contains(clone));
			list.DelLastOdd();

			Console.WriteLine("\nУдаление послeднего четного инф. поля:");

			foreach (object obj in list)
				Console.WriteLine(obj);

			list = null;

			UDList dlist = new UDList();
			dlist.Add("fff");
			dlist.Add("sss");


			Console.WriteLine("\nВывод двусвязного списка:");
			foreach (object obj in dlist)
				Console.WriteLine(obj);


			dlist.Insert(new Library(),2);
			Console.WriteLine("\nВставка элемента на позицию:");
			foreach (object obj in dlist)
				Console.WriteLine(obj);

			USTree tree = new USTree(new Library(), null);
			tree.Add(new Library());
			tree.Add(new Library());
			tree.Add(new Library());
			tree.Add(new Library());
			tree.Add(new Library());
			tree.Add(new Library());
			tree.Add(new Library());

			tree.Print(0);
		}
	}
}
