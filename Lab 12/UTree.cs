using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12
{
	enum Direction
	{
		Left,Right
	}

	class USTree
	{
		int level;
		USTree left = null;
		USTree right = null;
		USTree parent = null;
		object data = null;


		public USTree(Func<object> constructor)
		{
		}
		public USTree(object obj, USTree parent)
		{
			data = obj;
			this.parent = parent;
			if (parent == null) level = 0;
			else level = parent.level + 1;
		}



		public void Add(object obj) 
		{
			IComparable obj1 = data as IComparable;
			IComparable obj2 = obj as IComparable;

			if (obj1.CompareTo(obj2) < 1)
			{
				if (right == null)
					right = new USTree(obj, this);
				else
				{
					right.Add(obj);
				}
			}
			else
			{
				if (left == null)
					left = new USTree(obj, this);
				else left.Add(obj);
			}
		}

		public void Print(int l)
		{
			if (left != null) left.Print(l + 3);

			Console.Write(new string(' ', l));
			Console.WriteLine(data);

			if (right != null) right.Print(l + 3);
		}
	}
}
