using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Test
{
    public class Newspaper : Periodical
    {
        private string destination;

        static Newspaper()
        {
            HierarhyDictionary.Add(typeof(Newspaper), "Газета");
        }
        [DisplayName("Назначение")]
        public string Destination
        {
            get => destination; 
            set
            {
                NotifyPropertyChanged(value.ToString());
                destination = value;
            }
        }

        public Newspaper(object holder) : base(holder)
        {
            destination = SetRndDest();
        }

        public Newspaper(string name,
            int rating,
            DateTime publication,
            string editor,
            string author,
            object holder,
            int edition,
            string dest)
            : base(name, rating, publication, editor, author, holder, edition)
        {
            destination = dest;
        }

        protected override string SetRndName()
        {
            return RndResource.GetRandomString("NewsNames");
        }
        protected string SetRndDest()
        {
            return RndResource.GetRandomString("NewsDests");
        }

        public override string ToString()
        {
            return base.ToString() + $"{Destination};";
        }
    }
}