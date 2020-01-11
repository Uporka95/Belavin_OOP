using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Курсовая
{
   
    public class Fiction : Book
    {
        public string Genre { get; set; }

        public Fiction(object holder) : base(holder)
        {
            derivedType = "Худ. литература";
            Genre = SetRndGenre();
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
            derivedType = "Худ. литература";
            Genre = genre;
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