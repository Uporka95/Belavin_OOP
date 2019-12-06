using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orgs
{
	class Library : Organization
	{
		public Library(string name, int rt, int readers, int books) : base(name, rt)
		{
			Readers = readers;
			Books = books;
		}
		public override string Name { get => base.name; protected set => base.name = String.Format($"библиотека '{value}'"); }
	
		public int Readers { get; private set; }
		public int Books { get; private set; }
		public Organization BaseOrganization
		{
			get
			{
				return new Organization(name, rating);
			}
		}
		public override void GetService()
		{
			base.GetService();
			Console.WriteLine("Вы получили на руки книгу! Не забудьте вернуть.\n");
		}

		public override void GetInfo()
		{
			base.GetInfo();
			Console.WriteLine("Кол-во читателей: " + Readers + ", Кол-во книг: " + Books + '\n');
		}
	}
}
