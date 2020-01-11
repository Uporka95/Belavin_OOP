using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Test
{

    public abstract class Book : PrintEdition
    {
        private string iSBN;

        static Book() => HierarhyDictionary.Add(typeof(Book), "Книжное издание");

        [DisplayName("ISBN")]
        public string ISBN
        {
            get => iSBN; 
            set
            {
                NotifyPropertyChanged(value.ToString());
                iSBN = value;
            }
        }

        public Book(object holder) : base(holder)
        {
            iSBN = rnd.Next(100, 999) + "-" + rnd.Next(100000, 999999) + "-" + rnd.Next(0, 10) + "-" + rnd.Next(0, 10);
        }
        public Book(string name,
            int rating,
            DateTime publication,
            string editor,
            string author,
            object holder,
            string isbn)
           : base(name, rating, publication, editor, author, holder)
        {
            iSBN = isbn;
        }

        public override string ToString()
        {
            return base.ToString() + $"{ISBN};";
        }
    }
}