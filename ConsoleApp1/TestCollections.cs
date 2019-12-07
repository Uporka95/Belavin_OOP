using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleApp1
{

	class TestCollections
	{
		public delegate string Tests();
		public Tests tests;
		public event Tests OnTest;
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

			for (int i = 0; i < num; i++)
			{
				Library lib = new Library(
					rand_names[rnd.Next(0, rand_names.Length - 1)],
					rnd.Next(0, 100),
					rnd.Next(50, 5000),
					rnd.Next(1000, 10000));

				queue_orgs.Enqueue(lib.BaseOrganization);
				queue_str.Enqueue(lib.BaseOrganization.ToString());
				sdict_orgs.Add(lib.BaseOrganization, lib);
				sdict_str.Add(lib.ToString(), lib);
			}

			tests += Test1;
			tests += Test2;
			tests += Test3;
			tests += Test4;
			tests += Test5;
			tests += Test6;
			tests += Test7;
			tests += Test8;
			tests += Test9;
			tests += Test10;
			tests += Test11;
			tests += Test12;
			tests += Test13;
			tests += Test14;
			tests += Test15;
			tests += Test16;
			tests += Test17;
			tests += Test18;
			tests += Test19;
			tests += Test20;

		}

		public string TestAll()
		{
			return Test1() + Test2() + Test3() + Test4() + Test5() + Test6() + Test7() + Test8() + Test9() + Test10()
				+ Test11() + Test12() + Test13() + Test14() + Test15() + Test16() + Test17() + Test18() + Test19() + Test20();
		}

		public string Test1()
		{
			Organization org = queue_orgs.First();
			timer.Reset();
			timer.Start();
			queue_orgs.Contains(org);
			timer.Stop();
			return $"Поиск первого в коллекции 1(TKey): {timer.ElapsedTicks}\n";
		}
		public string Test2()
		{
			Organization org = queue_orgs.Last();
			timer.Reset();
			timer.Start();
			queue_orgs.Contains(org);
			timer.Stop();
			return $"Поиск последнего в коллекции 1(TKey): {timer.ElapsedTicks}\n";
		}
		public string Test3()
		{
			Organization org = queue_orgs.ElementAt(queue_orgs.Count / 2);
			timer.Reset();
			timer.Start();
			queue_orgs.Contains(org);
			timer.Stop();
			return $"Поиск центрального коллекции 1(TKey): {timer.ElapsedTicks}\n";
		}
		public string Test4()
		{
			Organization org = new Organization("", 0);
			timer.Reset();
			timer.Start();
			queue_orgs.Contains(org);
			timer.Stop();
			return $"Поиск несуществуюшего в коллекции 1(TKey): {timer.ElapsedTicks}\n";
		}
		public string Test5()
		{
			string str = queue_orgs.First().ToString();
			timer.Reset();
			timer.Start();
			queue_str.Contains(str);
			timer.Stop();
			return $"Поиск первого в коллекции 1(string): {timer.ElapsedTicks}\n";
		}
		public string Test6()
		{
			string str = queue_orgs.Last().ToString();
			timer.Reset();
			timer.Start();
			queue_str.Contains(str);
			timer.Stop();
			return $"Поиск последнего в коллекции 1(string): {timer.ElapsedTicks}\n";
		}
		public string Test7()
		{
			string str = queue_orgs.ElementAt(queue_orgs.Count / 2).ToString();
			timer.Reset();
			timer.Start();
			queue_str.Contains(str);
			timer.Stop();
			return $"Поиск центрального коллекции 1(string): {timer.ElapsedTicks}\n";
		}
		public string Test8()
		{
			string str = new Organization("", 0).ToString();
			timer.Reset();
			timer.Start();
			queue_str.Contains(str);
			timer.Stop();
			return $"Поиск несуществуюшего в коллекции 1(string): {timer.ElapsedTicks}\n";
		}
		public string Test9()
		{
			Organization org = queue_orgs.First();
			timer.Reset();
			timer.Start();
			sdict_orgs.ContainsKey(org);
			timer.Stop();
			return $"Поиск первого в коллекции 2(TKey,TValue): {timer.ElapsedTicks}\n";
		}
		public string Test10()
		{
			Organization org = queue_orgs.Last();
			timer.Reset();
			timer.Start();
			sdict_orgs.ContainsKey(org);
			timer.Stop();
			return $"Поиск последнего в коллекции 1(string): {timer.ElapsedTicks}\n";
		}
		public string Test11()
		{
			Organization org = queue_orgs.ElementAt(queue_orgs.Count / 2);
			timer.Reset();
			timer.Start();
			sdict_orgs.ContainsKey(org);
			timer.Stop();
			return $"Поиск центрального ключа коллекции 2(TKey,TValue): {timer.ElapsedTicks}\n";
		}
		public string Test12()
		{
			Organization org = new Organization("", 0);
			timer.Reset();
			timer.Start();
			sdict_orgs.ContainsKey(org);
			timer.Stop();
			return $"Поиск несуществуюшего ключа в коллекции 2(TKey,TValue): {timer.ElapsedTicks}\n";

		}
		public string Test13()
		{
			string str = queue_orgs.First().ToString();
			timer.Reset();
			timer.Start();
			sdict_str.ContainsKey(str);
			timer.Stop();
			return $"Поиск первого ключа в коллекции 2(string,TValue): {timer.ElapsedTicks}\n";
		}
		public string Test14()
		{
			string str = queue_orgs.Last().ToString();
			timer.Reset();
			timer.Start();
			sdict_str.ContainsKey(str);
			timer.Stop();
			return $"Поиск последнего ключа в коллекции 2(string,TValue): {timer.ElapsedTicks}\n";
		}
		public string Test15()
		{
			string str = queue_orgs.ElementAt(queue_orgs.Count / 2).ToString();
			timer.Reset();
			timer.Start();
			sdict_str.ContainsKey(str);
			timer.Stop();
			return $"Поиск центрального ключа коллекции 2(string,TValue): {timer.ElapsedTicks}\n";
		}
		public string Test16()
		{
			string str = new Organization("", 0).ToString();
			timer.Reset();
			timer.Start();
			sdict_str.ContainsKey(str);
			timer.Stop();
			return $"Поиск несуществуюшего ключа в коллекции 2(string,TValue): {timer.ElapsedTicks}\n";
		}
		public string Test17()
		{
			Library org = sdict_orgs.First().Value;
			timer.Reset();
			timer.Start();
			sdict_orgs.ContainsValue(org);
			timer.Stop();
			return $"Поиск первого значения в коллекции 2(TKey,TValue): {timer.ElapsedTicks}\n";
		}
		public string Test18()
		{
			Library org = sdict_orgs.Last().Value;
			timer.Reset();
			timer.Start();
			sdict_orgs.ContainsValue(org);
			timer.Stop();
			return $"Поиск последнего значения в коллекции 2(TKey,TValue): {timer.ElapsedTicks}\n";
		}
		public string Test19()
		{
			Library org = sdict_orgs.ElementAt(queue_orgs.Count / 2).Value;
			timer.Reset();
			timer.Start();
			sdict_orgs.ContainsValue(org);
			timer.Stop();
			return $"Поиск центрального значения в коллекции 2(TKey,TValue): {timer.ElapsedTicks}\n";
		}
		public string Test20()
		{
			Library org = new Library("", 0, 0, 0);
			timer.Reset();
			timer.Start();
			sdict_orgs.ContainsValue(org);
			timer.Stop();
			return $"Поиск несуществуюшего значения в коллекции 2(TKey,TValue): {timer.ElapsedTicks}\n";
		}
	}
}
