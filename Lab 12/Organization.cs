using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12
{
	internal class Organization : IComparable
	{
		static Random rnd = new Random();
		protected string name;
		protected double rating;

		public Organization(string name, double rt)
		{
			this.name = name;
			Rating = rt;
		}

		public Organization()
		{
			
			Rating  = rnd.Next(0, 4) + rnd.NextDouble();
		}

		public virtual string Name { get => name; protected set => name = String.Format($"'{value}'"); }
		public double Rating { get => rating; protected set => rating = value; }
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
		public override string ToString()
		{
			return $"{Name}{rating}";
		}

		public override bool Equals(object obj)
		{
			if ((obj == null) || !this.GetType().Equals(obj.GetType()))
				return false;
			else 
			{
				Organization org = (Organization)obj;
				return (this.name == org.name && this.rating == org.rating);
			}
			
		}
	}
}
