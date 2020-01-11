using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсовая
{
	delegate void ColChangesEventHandler(object collection, EventArgs args);
	class CollectionEventArgs : EventArgs
	{
		public CollectionEventArgs(string col_name, object obj, string desc)
		{
			ColName = col_name;
			ChangedObject = obj.ToString();
			ChangesDesc = desc;
		}
		public string ColName { get; set; }
		public string ChangesDesc { get; set; }
		public string ChangedObject { get; set; }

		public override string ToString()
		{
			return $"{ColName};{ChangesDesc};{ChangedObject}";
		}
	}

	class JournalEntry
	{
		public JournalEntry(CollectionEventArgs args)
		{
			ColName = args.ColName;
			ChangesDesc = args.ColName;
			ChangedObject = args.ChangedObject;
		}

		public string ColName { get; set; }
		public string ChangesDesc { get; set; }
		public string ChangedObject { get; set; }

		public override string ToString()
		{
			return $"Библиотека {ColName}: {ChangesDesc} {ChangedObject}";
		}
	}
	class Journal : IEnumerable<JournalEntry>
	{

		public void Subscribe()
		{

		}

		private List<JournalEntry> list;
		public IEnumerator<JournalEntry> GetEnumerator()
		{
			return GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return list.GetEnumerator();
		}
	}
}
