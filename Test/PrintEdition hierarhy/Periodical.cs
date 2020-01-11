using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
namespace Test
{
    public abstract class Periodical : PrintEdition
    {
        private int edition;

        static Periodical() => HierarhyDictionary.Add(typeof(Periodical), "Периодическое издание");
        [DisplayName("Издание")]
        public int Edition
        {
            get => edition; 
            set
            {
                NotifyPropertyChanged(value.ToString());
                edition = value;
            }
        }

        public Periodical(object holder) : base(holder)
        {
            edition = rnd.Next(0, 1000);
        }

        public Periodical(string name,
            int rating,
            DateTime publication,
            string editor,
            string author,
            object holder,
            int edition)
            : base(name, rating, publication, editor, author, holder)
        {
            this.edition = edition;


        }

        public override string ToString()
        {
            return base.ToString() + $"{Edition};";
        }
    }
}