using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Test
{


	class JournalEntry
	{
		public JournalEntry(PrintEdition sender, PrintEditionEventArgs args) 
		{
			string propertyDispName = RuntimeTools.GetPropertyDispName(sender.GetType(), args.PropertyName);
			EventDesc = $"данные изменены в поле \"{propertyDispName}\"";
			EventObject = args.ChangedValue;
			ChangedObject = sender.Name;
			EventTime = DateTime.Now;
		}

		public JournalEntry(Library sender, LibraryEventArgs args)
		{
			ChangedObject = sender.LibName;
			EventDesc = args.EventDesc;
			EventObject = args.EventObject;
			EventTime = DateTime.Now;
		}

		public string ChangedObject { get; set; }
		public string EventDesc { get; set; }
		public string EventObject { get; set; }

		public DateTime EventTime { get; set; }

		public override string ToString()
		{
			return $"{ChangedObject};{EventDesc};{EventObject}";
		}

	}
	class Journal : IEnumerable<JournalEntry>
	{
		private ObservableCollection<JournalEntry> journal_list = new ObservableCollection<JournalEntry>();
		public IEnumerator<JournalEntry> GetEnumerator() => GetEnumerator();
		IEnumerator IEnumerable.GetEnumerator() => journal_list.GetEnumerator();
		

		public void SubOnPropChanged(PrintEdition print_edition) => print_edition.PropertyChanged += Print_edition_PropertyChanged;
		

		public void SubOnLibraryEvents(Library library) => library.OnChanged += Library_OnChanged;
		
		
		private void Print_edition_PropertyChanged(object sender, PropertyChangedEventArgs e)
		{
			journal_list.Add(new JournalEntry(sender as PrintEdition, (PrintEditionEventArgs)e));
		}


		private void Library_OnChanged(object sender, LibraryEventArgs e)
		{
			journal_list.Add(new JournalEntry(sender as Library, e));
		}

		public void OverwriteTo(string path = "Journal.txt")
		{
			using (StreamWriter streamWriter = new StreamWriter(path))
			{
				foreach (var entry in journal_list)
					streamWriter.WriteLine(entry.ToString());

				streamWriter.Close();
			}
		}
		
		public void Clear() => journal_list.Clear();
	}
}
