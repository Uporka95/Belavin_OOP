using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
namespace Test
{
    class Textbook : Book
    {
        private string subject;

        static Textbook() => HierarhyDictionary.Add(typeof(Textbook), "Учебник");
        [DisplayName("Предмет")]
        public string Subject
        {
            get => subject; 
            set
            {
                NotifyPropertyChanged(value.ToString());
                subject = value;
            }
        }

        public Textbook(object holder) : base(holder)
        {
            subject = SetRndSubject();
            name = SetRndName();
        }

        public Textbook(string name,
            int rating,
            DateTime publication,
            string editor,
            string author,
            object holder,
            string isbn,
            string subject)
           : base(name, rating, publication, editor, author, holder, isbn)
        {
            this.subject = subject;
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