using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Курсовая
{
    public abstract class Periodical : PrintEdition
    {
        public int Edition { get; set; }

        public Periodical(object holder):base(holder)
        {
            Edition = rnd.Next(0, 1000);
        }

        public Periodical(string name, 
            int rating, 
            DateTime publication, 
            string editor, 
            string author, 
            object holder, 
            int edition) 
            : base(name,rating,publication, editor,author,holder)
        {
            Edition = edition;
           
        }

        public override string ToString()
        {
            return base.ToString() + $"{Edition};";
        }
    }
}