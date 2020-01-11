using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Курсовая
{

    public abstract class Book : PrintEdition
    {
        public string ISBN { get; set; }

        public Book(object holder) : base(holder)
        {
            ISBN = rnd.Next(100, 999) + "-" + rnd.Next(100000, 999999) + "-" + rnd.Next(0, 10) + "-" + rnd.Next(0, 10);
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
            ISBN = isbn;
        }
        
        public override string ToString()
        {
            return base.ToString() + $"{ISBN};";
        }
    }
}