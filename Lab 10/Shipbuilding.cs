using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10
{
	class Shipbuilding : Organization, ICloneable
	{
		public string[] ShipTypes { private set; get; }
		public override string Name { get => base.name; protected set => base.name = String.Format($"судостроительная компания '{value}'"); }
		private Random rnd = new Random();

		public Shipbuilding(string name, int rt, string[] ship_types) : base(name,rt)
		{
			ShipTypes = ship_types;
		}
		public override void GetService()
		{
			base.GetService();
			if (ShipTypes.Length == 0 || ShipTypes == null)
				Console.WriteLine("Корабли еще не спроектированы!");
			else Console.WriteLine($"Компания построила для вас {ShipTypes[rnd.Next(0, ShipTypes.Length - 1)]}\n");
		}

		public override void GetInfo()
		{
			base.GetInfo();
			Console.WriteLine("Кол-во моделей кораблей для производства: " + ShipTypes.Length + '\n');
		}

		public object Clone()
		{
			return new Shipbuilding(this.Name, this.Rating, this.ShipTypes);
		}
	}
}
