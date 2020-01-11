using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Курсовая
{
    public class Textbook : Book
    {
       
        public string Subject { get; set; }
        
        public Textbook(object holder) : base(holder)
        {
            derivedType = "Учебник";
            Subject = SetRndSubject();
            Name = SetRndName();
        }

        public Textbook(string name,
            int rating,
            DateTime publication,
            string editor,
            string author,
            object holder,
            string isbn,
            string subject)
           : base(name, rating, publication, editor, author, holder,isbn)
        {
            derivedType = "Учебник";
            Subject = subject;
        }

        protected override string SetRndName()
        {
            return $"Учебник \"{Subject}\"";
        }
        protected string SetRndSubject()
        {
            return RndResource.GetRandomString("Subjects");
        }

        public override string ToString()
        {
            return base.ToString() + $"{Subject};";
        }
    }
}