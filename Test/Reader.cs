using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Test
{
	class Reader
	{
		[DisplayName("Имя")]
		public string Firstname { get; set; }
		[DisplayName("Фамилия")]
		public string Lastname { get; set; }
		[DisplayName("Отчество")]
		public string Patronymic { get; set; }
		[DisplayName("Выданные книги")]
		public ObservableCollection<PrintEdition> SharedBooks { set; get; } = new ObservableCollection<PrintEdition>();

		private Reader()
		{
			string rnd = RndResource.GetRandomString("FIO");
			var fio = rnd.Split(' ');
			Firstname = fio[1];
			Lastname = fio[0];
			Patronymic = fio[2];
		}

		public Reader(string fname, string lname, string patr)
		{
			Firstname = fname;
			Lastname = lname;
			Patronymic = patr;
		}

		public void Take(params PrintEdition[] items)
		{
			foreach (var item in items)
			{
				if (!SharedBooks.Contains(item)) 
				SharedBooks.Add(item);
			}
		}
		public void TakeBack(params PrintEdition[] items)
		{
			foreach (var item in items)
			{
				if (SharedBooks.Contains(item))
				SharedBooks.Remove(item);
			}
		}

		public override string ToString()
		{
			return $"{Lastname} {Firstname} {Patronymic}";
		}

		public static Reader CreateReader() => new Reader();

	}
}
