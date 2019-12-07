using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Lab_11
{

	class TestCollections
	{
		Stopwatch timer = new Stopwatch();
		Random rnd = new Random();

		public Queue<Organization> queue_orgs;
		public Queue<string> queue_str;
		public SortedDictionary<Organization, Library> sdict_orgs;
		public SortedDictionary<string, Library> sdict_str;

		private string[] rand_names = { "Читака", "Глобус", "СССР", "Ботан", "Курилка", "Школьная библиотека" };

		public TestCollections(int num)
		{
			queue_orgs = new Queue<Organization>(num);
			queue_str = new Queue<string>(num);
			sdict_orgs = new SortedDictionary<Organization, Library>();
			sdict_str = new SortedDictionary<string, Library>();
			Library lib;
			for (int i = 0; i < num; i++)
			{
				lib = new Library();

				queue_orgs.Enqueue(lib.BaseOrganization);
				queue_str.Enqueue(lib.BaseOrganization.ToString());
				sdict_orgs.Add(lib.BaseOrganization, lib);
				sdict_str.Add(lib.ToString(), lib);
			}

		}

		
		public string Test1Col()
		{
			return Test1() + Test2() + Test3() + Test4();
		}
		public string Test2Col()
		{
			return Test5() + Test6() + Test7() + Test8();
		}
		public string Test3Col()
		{
			return Test9() + Test10()
				+ Test11() + Test12();
		}
		public string Test4Col()
		{
			return Test13() + Test14() + Test15() + Test16() + Test17() + Test18() + Test19() + Test20();
		}

		public string Test1()
		{
			Organization org = queue_orgs.First();
			timer.Reset();
			timer.Start();
			queue_orgs.Contains(org);
			timer.Stop();
			return $"Поиск первого: {timer.ElapsedTicks}\n";
		}
		public string Test2()
		{
			Organization org = queue_orgs.Last();
			timer.Reset();
			timer.Start();
			queue_orgs.Contains(org);
			timer.Stop();
			return $"Поиск последнего: {timer.ElapsedTicks}\n";
		}
		public string Test3()
		{
			Organization org = queue_orgs.ElementAt(queue_orgs.Count / 2);
			timer.Reset();
			timer.Start();
			queue_orgs.Contains(org);
			timer.Stop();
			return $"Поиск центрального: {timer.ElapsedTicks}\n";
		}
		public string Test4()
		{
			Organization org = new Organization("", 0);
			timer.Reset();
			timer.Start();
			queue_orgs.Contains(org);
			timer.Stop();
			return $"Поиск несуществуюшего: {timer.ElapsedTicks}\n";
		}
		public string Test5()
		{
			string str = queue_orgs.First().ToString();
			timer.Reset();
			timer.Start();
			queue_str.Contains(str);
			timer.Stop();
			return $"Поиск первого: {timer.ElapsedTicks}\n";
		}
		public string Test6()
		{
			string str = queue_orgs.Last().ToString();
			timer.Reset();
			timer.Start();
			queue_str.Contains(str);
			timer.Stop();
			return $"Поиск последнего: {timer.ElapsedTicks}\n";
		}
		public string Test7()
		{
			string str = queue_orgs.ElementAt(queue_orgs.Count / 2).ToString();
			timer.Reset();
			timer.Start();
			queue_str.Contains(str);
			timer.Stop();
			return $"Поиск центрального: {timer.ElapsedTicks}\n";
		}
		public string Test8()
		{
			string str = new Organization("", 0).ToString();
			timer.Reset();
			timer.Start();
			queue_str.Contains(str);
			timer.Stop();
			return $"Поиск несуществуюшего: {timer.ElapsedTicks}\n";
		}
		public string Test9()
		{
			Organization org = queue_orgs.First();
			timer.Reset();
			timer.Start();
			sdict_orgs.ContainsKey(org);
			timer.Stop();
			return $"Поиск первого ключа: {timer.ElapsedTicks}\n";
		}
		public string Test10()
		{
			Organization org = queue_orgs.Last();
			timer.Reset();
			timer.Start();
			sdict_orgs.ContainsKey(org);
			timer.Stop();
			return $"Поиск последнего ключа: {timer.ElapsedTicks}\n";
		}
		public string Test11()
		{
			Organization org = queue_orgs.ElementAt(queue_orgs.Count / 2);
			timer.Reset();
			timer.Start();
			sdict_orgs.ContainsKey(org);
			timer.Stop();
			return $"Поиск центрального ключа: {timer.ElapsedTicks}\n";
		}
		public string Test12()
		{
			Organization org = new Organization("", 0);
			timer.Reset();
			timer.Start();
			sdict_orgs.ContainsKey(org);
			timer.Stop();
			return $"Поиск несуществуюшего ключа: {timer.ElapsedTicks}\n";

		}
		public string Test13()
		{
			string str = queue_orgs.First().ToString();
			timer.Reset();
			timer.Start();
			sdict_str.ContainsKey(str);
			timer.Stop();
			return $"Поиск первого ключа: {timer.ElapsedTicks}\n";
		}
		public string Test14()
		{
			string str = queue_orgs.Last().ToString();
			timer.Reset();
			timer.Start();
			sdict_str.ContainsKey(str);
			timer.Stop();
			return $"Поиск последнего ключа: {timer.ElapsedTicks}\n";
		}
		public string Test15()
		{
			string str = queue_orgs.ElementAt(queue_orgs.Count / 2).ToString();
			timer.Reset();
			timer.Start();
			sdict_str.ContainsKey(str);
			timer.Stop();
			return $"Поиск центрального ключа: {timer.ElapsedTicks}\n";
		}
		public string Test16()
		{
			string str = new Organization("", 0).ToString();
			timer.Reset();
			timer.Start();
			sdict_str.ContainsKey(str);
			timer.Stop();
			return $"Поиск несуществуюшего ключа: {timer.ElapsedTicks}\n";
		}
		public string Test17()
		{
			Library org = sdict_orgs.First().Value;
			timer.Reset();
			timer.Start();
			sdict_orgs.ContainsValue(org);
			timer.Stop();
			return $"Поиск первого значения: {timer.ElapsedTicks}\n";
		}
		public string Test18()
		{
			Library org = sdict_orgs.Last().Value;
			timer.Reset();
			timer.Start();
			sdict_orgs.ContainsValue(org);
			timer.Stop();
			return $"Поиск последнего значения: {timer.ElapsedTicks}\n";
		}
		public string Test19()
		{
			Library org = sdict_orgs.ElementAt(queue_orgs.Count / 2).Value;
			timer.Reset();
			timer.Start();
			sdict_orgs.ContainsValue(org);
			timer.Stop();
			return $"Поиск центрального значения: {timer.ElapsedTicks}\n";
		}
		public string Test20()
		{
			Library org = new Library("", 0, 0, 0);
			timer.Reset();
			timer.Start();
			sdict_orgs.ContainsValue(org);
			timer.Stop();
			return $"Поиск несуществуюшего значения: {timer.ElapsedTicks}\n";
		}
	}
}
