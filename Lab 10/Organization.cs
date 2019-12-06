using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10
{
	internal abstract class Organization : IComparable
	{
		protected string name;
		protected int rating;

		public Organization(string name, int rt)
		{
			Name = name;
			Rating = rt;
		}

		public virtual string Name { get => name; protected set => name = String.Format($"'{value}'"); }
		public int Rating { get => rating; protected set => rating = value; }
		public virtual void GetService()
		{
			Console.WriteLine($"{Name} предоставляет вам услугу: ");
		}
		public virtual void GetInfo()
		{
			Console.WriteLine($"Информация об организации {Name}:");
			Console.WriteLine($"Рейтинг: {Rating}");
		}
		
		public int CompareTo(object o)
		{
			return this.rating.CompareTo(((Organization)o).rating);
		}
	}
}
