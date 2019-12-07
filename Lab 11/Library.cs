using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11
{
	internal class Library : Organization, ICloneable
	{
		static Random rnd = new Random(0);
		private string[] rand_names = { "Читака", "Глобус", "СССР", "Ботан", "Курилка", "Школьная библиотека" };
		public Library(string name, double rt, int readers, int books) : base(name, rt)
		{
			Readers = readers;
			Books = books;
		}
		public Library() 
		{
			
			Name = rand_names[rnd.Next(0, rand_names.Length - 1)];
			Readers = rnd.Next(50, 5000);
			Books = rnd.Next(1000, 10000);
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

		public override string ToString()
		{
			return $"{Name}{rating},{Readers},{Books}";
		}

		public object Clone()
		{
			return new Library(this.Name, this.Rating, this.Readers, this.Books);
		}
	}
}
