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
		delegate string Tests();
		Tests tests;
		Stopwatch timer = new Stopwatch();
		Random rnd = new Random();

		private Queue<Organization> queue_orgs;
		private Queue<string> queue_str;
		private SortedDictionary<Organization, Library> sdict_orgs;
		private SortedDictionary<string, Library> sdict_str;

		private string[] rand_names = { "Читака", "Глобус", "СССР", "Ботан", "Курилка", "Школьная библиотека" };

		public TestCollections(int num)
		{
			queue_orgs = new Queue<Organization>(num);
			queue_str = new Queue<string>(num);
			sdict_orgs = new SortedDictionary<Organization, Library>();
			sdict_str = new SortedDictionary<string, Library>();

			for (int i = 0; i < num; i++)
			{
				Library lib = new Library(
					rand_names[rnd.Next(0, rand_names.Length - 1)],
					rnd.Next(0, 5),
					rnd.Next(50, 5000),
					rnd.Next(1000, 10000));

				queue_orgs.Enqueue(lib.BaseOrganization);
				queue_str.Enqueue(lib.BaseOrganization.ToString());
				sdict_orgs.Add(lib.BaseOrganization, lib);
				sdict_str.Add(lib.ToString(), lib);
			}



		}

		public string Test1()
		{
			Organization org = queue_orgs.First();
			timer.Reset();
			timer.Start();
			queue_orgs.Contains(org);
			timer.Stop();
			tests += Test1;
			return $"Поиск первого в коллекции 1(TKey): {timer.ElapsedTicks}";
		}
		public string Test2()
		{
			Organization org = queue_orgs.Last();
			timer.Reset();
			timer.Start();
			queue_orgs.Contains(org);
			timer.Stop();
			tests += Test2;
			return $"Поиск последнего в коллекции 1(TKey): {timer.ElapsedTicks}";
		}
		public string Test3()
		{
			Organization org = queue_orgs.ElementAt(queue_orgs.Count / 2);
			timer.Reset();
			timer.Start();
			queue_orgs.Contains(org);
			timer.Stop();
			tests += Test3;
			return $"Поиск центрального коллекции 1(TKey): {timer.ElapsedTicks}";
		}
		public string Test4()
		{
			Organization org = new Organization("", 0);
			timer.Reset();
			timer.Start();
			queue_orgs.Contains(org);
			timer.Stop();
			tests += Test4;
			return $"Поиск несуществуюшего в коллекции 1(TKey): {timer.ElapsedTicks}";
		}
		public string Test5()
		{
			string str = queue_orgs.First().ToString();
			timer.Reset();
			timer.Start();
			queue_str.Contains(str);
			timer.Stop();
			tests += Test5;
			return $"Поиск первого в коллекции 1(string): {timer.ElapsedTicks}";
		}
		public string Test6()
		{
			string str = queue_orgs.Last().ToString();
			timer.Reset();
			timer.Start();
			queue_str.Contains(str);
			timer.Stop();
			tests += Test6;
			return $"Поиск последнего в коллекции 1(string): {timer.ElapsedTicks}";
		}
		public string Test7()
		{
			string str = queue_orgs.ElementAt(queue_orgs.Count / 2).ToString();
			timer.Reset();
			timer.Start();
			queue_str.Contains(str);
			timer.Stop();
			tests += Test7;
			return $"Поиск центрального коллекции 1(string): {timer.ElapsedTicks}";
		}
		public string Test8()
		{
			string str = new Organization("", 0).ToString();
			timer.Reset();
			timer.Start();
			queue_str.Contains(str);
			timer.Stop();
			tests += Test8;
			return $"Поиск несуществуюшего в коллекции 1(string): {timer.ElapsedTicks}";
		}
		public string Test9()
		{
			Organization org = queue_orgs.First();
			timer.Reset();
			timer.Start();
			sdict_orgs.ContainsKey(org);
			timer.Stop();
			tests += Test9;
			return $"Поиск первого в коллекции 2(TKey,TValue): {timer.ElapsedTicks}";
		}
		public string Test10()
		{
			Organization org = queue_orgs.Last();
			timer.Reset();
			timer.Start();
			sdict_orgs.ContainsKey(org);
			timer.Stop();
			tests += Test10;
			return $"Поиск последнего в коллекции 1(string): {timer.ElapsedTicks}";
		}
		public string Test11()
		{
			Organization org = queue_orgs.ElementAt(queue_orgs.Count / 2);
			timer.Reset();
			timer.Start();
			sdict_orgs.ContainsKey(org);
			timer.Stop();
			tests += Test11;
			return $"Поиск центрального ключа коллекции 2(TKey,TValue): {timer.ElapsedTicks}";
		}
		public string Test12()
		{
			Organization org = new Organization("", 0);
			timer.Reset();
			timer.Start();
			sdict_orgs.ContainsKey(org);
			timer.Stop();
			tests += Test12;
			return $"Поиск несуществуюшего ключа в коллекции 2(TKey,TValue): {timer.ElapsedTicks}";

		}
		public string Test13()
		{
			string str = queue_orgs.First().ToString();
			timer.Reset();
			timer.Start();
			sdict_str.ContainsKey(str);
			timer.Stop();
			tests += Test13;
			return $"Поиск первого ключа в коллекции 2(string,TValue): {timer.ElapsedTicks}";
		}
		public string Test14()
		{
			string str = queue_orgs.Last().ToString();
			timer.Reset();
			timer.Start();
			sdict_str.ContainsKey(str);
			timer.Stop();
			tests += Test14;
			return $"Поиск первого ключа в коллекции 2(string,TValue): {timer.ElapsedTicks}";
		}
		public string Test15()
		{
			string str = queue_orgs.ElementAt(queue_orgs.Count / 2).ToString();
			timer.Reset();
			timer.Start();
			sdict_str.ContainsKey(str);
			timer.Stop();
			tests += Test15;
			return $"Поиск центрального ключа коллекции 2(string,TValue): {timer.ElapsedTicks}";
		}
		public string Test16()
		{
			string str = new Organization("", 0).ToString();
			timer.Reset();
			timer.Start();
			sdict_str.ContainsKey(str);
			timer.Stop();
			tests += Test16;
			return $"Поиск несуществуюшего ключа в коллекции 2(string,TValue): {timer.ElapsedTicks}";
		}
		public string Test17()
		{
			Library org = sdict_orgs.First().Value;
			timer.Reset();
			timer.Start();
			sdict_orgs.ContainsValue(org);
			timer.Stop();
			tests += Test17;
			return $"Поиск первого значения в коллекции 2(TKey,TValue): {timer.ElapsedTicks}";
		}
		public string Test18()
		{
			Library org = sdict_orgs.Last().Value;
			timer.Reset();
			timer.Start();
			sdict_orgs.ContainsValue(org);
			timer.Stop();
			tests += Test18;
			return $"Поиск последнего значения в коллекции 2(TKey,TValue): {timer.ElapsedTicks}";
		}
		public string Test19()
		{
			Library org = sdict_orgs.ElementAt(queue_orgs.Count / 2).Value;
			timer.Reset();
			timer.Start();
			sdict_orgs.ContainsValue(org);
			timer.Stop();
			tests += Test19;
			return $"Поиск центрального значения в коллекции 2(TKey,TValue): {timer.ElapsedTicks}";
		}
		public string Test20()
		{
			Library org = new Library("", 0, 0, 0);
			timer.Reset();
			timer.Start();
			sdict_orgs.ContainsValue(org);
			timer.Stop();
			tests += Test20;
			return $"Поиск несуществуюшего значения в коллекции 2(TKey,TValue): {timer.ElapsedTicks}";
		}
	}
}
