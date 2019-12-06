using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			TestCollections test = new TestCollections(6);
			string res = test.TestAll();
		}
	}
}
