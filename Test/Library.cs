using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Test
{
	delegate void LibraryEventHandler(object sender, LibraryEventArgs e);
	class LibraryEventArgs : EventArgs
	{
		public LibraryEventArgs(object obj, string desc)
		{
			EventObject = obj.ToString();
			EventDesc = desc;
		}

		public string EventDesc { get; set; }
		public string EventObject { get; set; }
		public override string ToString()
		{
			return $"{EventDesc};{EventObject};";
		}
	}
	class Library : IEnumerable<PrintEdition>
	{

		public event LibraryEventHandler OnChanged;

		public readonly Journal journal = new Journal();
		public List<Reader> readers = new List<Reader>();
		List<PrintEdition> libHolder = new List<PrintEdition>();
		public IEnumerable<PrintEdition> CurrentSelection { get; set; }
		public string LibName { get; set; }

		public Library(string name)
		{
			readers.Add(Reader.CreateReader());
			readers.Add(Reader.CreateReader());
			readers.Add(Reader.CreateReader());
			LibName = name;
			journal.SubOnLibraryEvents(this);
		}

		public void SelectCategory(Type cat_type)
		{
			var query = (from item in libHolder
						 where (item.GetType() == cat_type)                    // Если тип объекта равен выбранному в коробке типу
						 || (item.GetType()).BaseType == cat_type              // Или базовый класс объекта равен выбранному типу
						 || (item.GetType()).BaseType.BaseType == cat_type     // или базовый базового...
						 select item);

			
			CurrentSelection = (IEnumerable<PrintEdition>)RuntimeTools.CastToList(query, cat_type);

		}

		public void FilterSelected(string filter, string by_prop )
		{

		}

		public bool Discard(params PrintEdition[] printEditions)
		{
			if (!CheckAllShared(printEditions)) return false;

			foreach (var item in printEditions)
			{
				if (OnChanged != null) OnChanged(this, new LibraryEventArgs(item, "списана книга"));
				libHolder.Remove(item);
			}
			return true;
			
		}

		private bool CheckAllShared(params PrintEdition[] printEditions)
		{
			foreach (var item in printEditions)
			{
				if (item.Holder as string != LibName) return false;
			}
			return true;
		}

		private bool CheckAllInLibrary(params PrintEdition[] printEditions)
		{
			foreach (var item in printEditions)
			{
				if (!(item.Holder is Reader)) return false;
			}
			return true;
		}

		public bool Share(Reader reader, params PrintEdition[] printEditions)
		{
			if (!CheckAllShared(printEditions)) return false;

			reader.Take(printEditions);
			foreach (var item in printEditions)
			{
				if (OnChanged != null)
					OnChanged(this, new LibraryEventArgs(item, $"читателю ({reader}) выдана книга"));
				item.Holder = reader;
			}
			return true;
			
		}

		public bool TakeBack(params PrintEdition[] printEditions)
		{
			if (!CheckAllInLibrary(printEditions)) return false;
			foreach (var item in printEditions)
			{
				(item.Holder as Reader).TakeBack(item);
				if (OnChanged != null)
					OnChanged(this, new LibraryEventArgs(item, $"читатель ({item.Holder}) вернул книгу"));
				item.Holder = LibName;
			}
			return true;
			
		}

		public void Buy(Type print_edition, int num)
		{
			if (RuntimeTools.GetUpperBaseType(print_edition)!= typeof(PrintEdition)) throw new Exception("Передан неверный тип");

			var constructor = print_edition.GetConstructor(new Type[1] { typeof(object) });
			for (int i = 0; i < num; ++i)
			{
				var new_print_ed = (PrintEdition)constructor.Invoke(new object[1] { LibName });
				libHolder.Add(new_print_ed);

				OnChanged(this, new LibraryEventArgs(new_print_ed, "закуплена новая книга"));
				journal.SubOnPropChanged(new_print_ed);
			}
		}

		public IEnumerator<PrintEdition> GetEnumerator()
		{
			return ((IEnumerable<PrintEdition>)libHolder).GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<PrintEdition>)libHolder).GetEnumerator();
		}
	}
}
