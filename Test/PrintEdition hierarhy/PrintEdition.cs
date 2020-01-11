using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Test
{

    public class PrintEditionEventArgs : PropertyChangedEventArgs
    {
        public PrintEditionEventArgs(string propname, string changed_value):base(propname)
        {
            ChangedValue = changed_value;
        }
        public string ChangedValue { get; set; }

    }

    [Serializable]

    public abstract class PrintEdition : INotifyPropertyChanged
    {
        [NonSerialized]
        public static readonly Dictionary<Type, string> HierarhyDictionary = new Dictionary<Type, string>();
        static PrintEdition()
        {
            HierarhyDictionary.Add(typeof(PrintEdition), "Печатное издание");
            System.Runtime.CompilerServices.RuntimeHelpers.RunClassConstructor(typeof(Newspaper).TypeHandle);
            System.Runtime.CompilerServices.RuntimeHelpers.RunClassConstructor(typeof(Periodical).TypeHandle);
            System.Runtime.CompilerServices.RuntimeHelpers.RunClassConstructor(typeof(Textbook).TypeHandle);
            System.Runtime.CompilerServices.RuntimeHelpers.RunClassConstructor(typeof(Magazine).TypeHandle);
            System.Runtime.CompilerServices.RuntimeHelpers.RunClassConstructor(typeof(Fiction).TypeHandle);
            System.Runtime.CompilerServices.RuntimeHelpers.RunClassConstructor(typeof(Book).TypeHandle);
        }

        protected static Random rnd = new Random();
        protected string name;
        private DateTime publication;
        private string editor;
        private string author;
        private int rating;
        protected object holder;
       // private int count;

        public event PropertyChangedEventHandler PropertyChanged;

        public static Type GetTypename(string dispname)
        {
            return HierarhyDictionary.FirstOrDefault(x => x.Value == dispname).Key;
        }
        protected void NotifyPropertyChanged(string new_value, [CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PrintEditionEventArgs(propertyName,new_value));
            }
        }

        public PrintEdition(object holder)
        {

            name = SetRndName();
            author = SetRndAuthor();
            editor = SetRndEditor();
            rating = rnd.Next(0, 6);
            publication = new DateTime(rnd.Next(1950, 2021), rnd.Next(1, 13), rnd.Next(1, 28));
            this.holder = holder;
        }

        public PrintEdition(string name, int rating, DateTime publication, string editor, string author, object holder)
        {
            this.name = name;
            this.rating = rating;
            this.publication = publication;
            this.editor = editor;
            this.author = author;
            this.holder = holder;
        }

        protected string SetRndAuthor()
        {
            return RndResource.GetRandomString("Authors");
        }
        protected string SetRndEditor()
        {
            return RndResource.GetRandomString("Editors");
        }
        protected abstract string SetRndName();

        [DisplayName("Имя")]
        public string Name
        {
            get => name;
            set
            {
                NotifyPropertyChanged(value.ToString());
                name = value;
            }
        }

        [DisplayName("Дата издания")]
        public DateTime Publication
        {
            get => publication;
            set
            {
                NotifyPropertyChanged(value.ToString());
                publication = value;
            }
        }
        [DisplayName("Издатель")]
        public string Editor
        {
            get => editor;
            set
            {
                NotifyPropertyChanged(value.ToString());
                editor = value;
            }
        }
        [DisplayName("Автор")]
        public string Author
        {
            get => author;
            set
            {
                NotifyPropertyChanged(value.ToString());
                author = value;
            }
        }
        [DisplayName("Рейтинг")]
        public int Rating
        {
            get => rating;
            set
            {
                NotifyPropertyChanged(value.ToString());
                rating = value;
            }
        }

        //[DisplayName("В наличии")]
        //public int Count
        //{
        //    get => count; 
        //    set
        //    {
        //        NotifyPropertyChanged(value.ToString());
        //        count = value;
        //    }
        //}

        [DisplayName("Текущий держатель")]
        public object Holder
        {
            get => holder;
            set
            {
                NotifyPropertyChanged(value.ToString());
                holder = value;
            }
        }

        public override string ToString()
        {
            return $"{Name};{Author};{Editor};{Rating};{Publication};{Holder};";
        }


    }
}