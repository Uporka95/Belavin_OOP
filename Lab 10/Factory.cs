using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10
{
	class Factory : Organization
	{

		public int Conveers { private set; get; }
		public int Employeers{ private set; get; }

		public override string Name { get => base.name; protected set => base.name = String.Format($"завод '{value}'"); }
		public Factory(string name, int rt, int conv_cnt, int emp_cnt) : base(name, rt)
		{
			Conveers = conv_cnt;
			Employeers = emp_cnt;
		}
		public override void GetService()
		{
			base.GetService();
			Console.WriteLine("Рабочие бастуют! Услуги не оказываются!\n");
		}

		public override void GetInfo()
		{
			base.GetInfo();
			Console.WriteLine("Кол-во рабочих: " + Employeers + ", конвееров задействовано: " + Conveers + '\n');
		}
	}
}
