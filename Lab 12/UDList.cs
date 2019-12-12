using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12
{
	class UDList : IEnumerable
	{
		protected class Node
		{
			public object data = null;
			public Node next = null;
			public Node prev = null;

			public Node(object data)
			{
				this.data = data;
			}
		}
		protected class DListEnumerator : IEnumerator
		{
			bool began = false;
			Node cur,beg;
			public DListEnumerator(Node begin)
			{
				beg = begin;
				cur = begin;
			}
			object IEnumerator.Current => cur.data;

			bool IEnumerator.MoveNext()
			{
				if (began) cur = cur.next;
				else began = true;
				return (cur != null);
			}

			void IEnumerator.Reset()
			{
				began = false;
				cur = beg;
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

		public IEnumerator GetEnumerator()
		{
			return (IEnumerator)new DListEnumerator(beg);
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
			new_node.prev = end;
			end = end.next;
			count++;
		}

		public bool Remove(object data)
		{
			if (data == null) return false;

			Node p = beg;
			while (p != null)
			{
				if (data.Equals(p.data))
				{
					if (p == beg)
					{
						if (beg.next != null)
						{
							beg = beg.next;
							beg.prev = null;
						}
						else
						{
							beg = null;
						}
					}
					else if (p == end)
					{
						if (end.prev != null)
						{
							end = end.prev;
							end.next = null;
						}
						else
						{
							end = null;
						}

					}
					else
					{
						p.prev.next = p.next;
						p.next.prev = p.prev;
						p = null;
					}
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


		public bool Insert(object obj, int index = 0)
		{
			if (index > count || index < 0)
				return false;
			if (index == count)
			{
				Add(obj);
				return true;
			}

			Node new_node = new Node(obj);
			Node p = beg;
			int i = 0;
			while (p != null)
			{
				if (i == index)
				{
					if(p == beg)
					{
						beg.prev = new_node;
						new_node.next = beg;
						beg = new_node;
					}
					else {
						p.prev.next = new_node;
						new_node.prev = p.prev;
						p.prev = new_node;
						new_node.next = p;
					}
					count++;
					return true;
				}
				p = p.next;
				i++;
			}
			return false;

		}

	}
}
