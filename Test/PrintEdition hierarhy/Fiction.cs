using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Test
{

    public class Fiction : Book
    {
        private string genre;

        static Fiction() => HierarhyDictionary.Add(typeof(Fiction), "Худ. литература");

        [DisplayName("Жанр")]
        public string Genre
        {
            get => genre; 
            set
            {
                NotifyPropertyChanged(value.ToString());
                genre = value;
            }
        }

        public Fiction(object holder) : base(holder)
        {
            genre = SetRndGenre();
        }

        public Fiction(string name,
           int rating,
           DateTime publication,
           string editor,
           string author,
           object holder,
           string isbn,
           string genre)
          : base(name, rating, publication, editor, author, holder, isbn)
        {
            this.genre = genre;
        }

        protected override string SetRndName()
        {
            return RndResource.GetRandomString("FictionNames");
        }
        protected string SetRndGenre()
        {
            return RndResource.GetRandomString("Genres");
        }

        public override string ToString()
        {
            return base.ToString() + $"{Genre};";
        }
    }
}