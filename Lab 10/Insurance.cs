using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10
{
	class Insurance : Organization
	{
		public int Clients { get; private set; }
		public int Fond { get; private set; }
		public override string Name { get => base.name; protected set => base.name = String.Format($"страховая компания '{value}'"); }
		public Insurance(string name, int rt, int clients, int fond) :base(name,rt)
		{
			Clients = clients;
			Fond = fond;
		}

		public override void GetService()
		{
			base.GetService();
			Console.WriteLine("Компания застраховала ваш маш безымянный палец левой ноги!\n");
		}

		public override void GetInfo()
		{
			base.GetInfo();
			Console.WriteLine("Кол-во клиентов: " + Clients + '\n');
		}
	}
}
