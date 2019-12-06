using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10
{

	class SortByName : IComparer<Organization>
	{
		public int Compare(Organization a, Organization b)
		{
			return String.Compare(a.Name, b.Name);
		}
	}
	class Program
	{
		static Organization[] orgs;
		static void Main(string[] args)
		{
			orgs = new Organization[8];

			orgs[0] = new Library("Звезда", 4, 50, 1000);
			orgs[1] = new Factory("Урал Калий", 3, 5, 200);
			orgs[2] = new Insurance("Мезинецстрах", 2, 15, 4000000);
			orgs[3] = new Shipbuilding("Якорь", 4, new string[] { "парусник", "яхту", "пароход" });
			orgs[4] = new Library("Читака", 5, 100, 5000);
			orgs[5] = new Shipbuilding("Starships", 4, new string[] { "эсминец", "авианосец", "подлодку" });
			orgs[6] = new Insurance("Большойпалецстрах", 2, 10000, 70000000);
			orgs[7] = new Factory("Норильский никель", 5, 10, 500);

			for (int i = 0; i < orgs.Length; i++)
			{
				orgs[i].GetInfo();
			}
			
			foreach(Organization org in orgs)
				org.GetService();

			Console.WriteLine($"Общий фонд всех страховых компаний: {GetInsurFonds()}");
			Console.WriteLine($"Всего библиотек в городе: {GetLibsNum()}");
			Console.WriteLine($"Всего книг во всех библиотеках: {GetBooksNum()}");
			Console.WriteLine();
			Console.WriteLine("Сортировка по рейтингу(IComparable):\n");

			Array.Sort(orgs);

			for (int i = 0; i < orgs.Length; i++)
			{
				orgs[i].GetInfo();
			}

			Console.WriteLine("Сортировка по имени(IComparer):\n");

			Array.Sort(orgs, new SortByName());

			for (int i = 0; i < orgs.Length; i++)
			{
				orgs[i].GetInfo();
			}
		}

		static int GetInsurFonds()
		{
			Insurance ins;
			int Fond = 0;
			if (orgs != null)
				foreach(Organization org in orgs)
				{
					ins = org as Insurance;
					if (ins != null) Fond += ins.Fond;
				}
			return Fond;
		}
		
		static int GetLibsNum()
		{
			Library lib;
			int num = 0;
			if (orgs != null)
				foreach (Organization org in orgs)
				{
					lib = org as Library;
					if (lib != null) num++;
				}
			return num;
		}

		static int GetBooksNum()
		{
			Library lib;
			int num = 0;
			if (orgs != null)
				foreach (Organization org in orgs)
				{
					lib = org as Library;
					if (lib != null) num += lib.Books;
				}
			return num;
		}

	}
}
