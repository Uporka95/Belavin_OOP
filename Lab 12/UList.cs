using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12
{
	

	class UList : IEnumerable
	{
		protected class Node
		{
			public object data = null;
			public Node next = null;

			public Node(object data)
			{
				this.data = data;
			}
		}

		private Node beg = null;
		private Node end = null;

		private int count = 0;

		public int Count
		{
			get { return count; }
			private set { count = value; }
		}


		public UList()
		{

		}

		public IEnumerator GetEnumerator()
		{
			Node pointer = beg;
			while (pointer != null)
			{
				yield return pointer.data;
				pointer = pointer.next;
			}

		}

		public void Add(object data)
		{
			Node new_node = new Node(data);
			if (beg == null)
			{
				beg = new Node(data);
				end = beg;
				count++;
				return;
			}
			end.next = new_node;
			end = end.next;
			count++;
		}

		public bool Remove(object data)
		{
			if (data == null) return false;

			Node p = beg;
			while (p.next != null)
			{
				if (data.Equals(p.next.data))
				{
					p.next = p.next.next;
					count--;
					return true;
				}
				p = p.next;
			}
			return false;
		}

		public void Clear()
		{
			beg = null;
			end = beg;
			count = 0;
		}

		public bool Contains(object data)
		{
			foreach (object item in this)
			{
				if (item.Equals(data)) return true;
			}
			return false;
		}

		public bool Empty() => (beg == null) ? true : false;


		public bool DelLastOdd()
		{
			if (Empty() || count == 1) return false;
			if (count == 2)
			{
				beg.next = null;
				end = beg;
				count--;
				return false;
			}
			int ind = 0;
			Node p = beg;
			while (p.next.next != end)
			{
				ind++;
				p = p.next;
			}

			if (ind % 2 > 0)
				p.next = end;
			else
			{
				end = p.next;
				p.next.next = null;
			}

			count--;
			return true;
			
		}

	}
}
