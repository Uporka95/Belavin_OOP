using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Курсовая
{


    [Serializable]
   
    public abstract class PrintEdition
    {
        protected static Random rnd = new Random();

        public PrintEdition(object holder)
        {
            
            Name = SetRndName();
            Author = SetRndAuthor();
            Editor = SetRndEditor();
            Rating = rnd.Next(0, 6);
            Publication = new DateTime(rnd.Next(1950, 2021), rnd.Next(1, 13), rnd.Next(1, 28));
            Holder = holder;
        }

        public PrintEdition(string name, int rating, DateTime publication, string editor, string author, object holder)
        {
            Name = name;
            Rating = rating;
            Publication = publication;
            Editor = editor;
            Author = author;
            Holder = holder;
        }

        [DisplayName("Тип печатного издания")]
        public string derivedType {get;set;} 
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
        public string Name { get; set; }
        [DisplayName("Рейтинг")]
        public int Rating { get; set; }
        [DisplayName("Дата издания")]
        public DateTime Publication { get; set; }
        [DisplayName("Издатель")]
        public string Editor { get; set; }
        [DisplayName("Автор")]
        public string Author { get; set; }
        [DisplayName("Текущий держатель")]
        public object Holder { get; set; }

        public override string ToString()
        {
            return $"{derivedType};{Name};{Author};{Editor};{Rating};{Publication};{Holder};";
        }
    }
}