using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Курсовая
{
    public class Newspaper : Periodical
    {
        public string Destination { get; set; }

        public Newspaper(object holder) : base(holder)
        {
            derivedType = "Газета";
            Destination = SetRndDest();
            var r = this.GetType().BaseType;
            var rs = this.GetType();
        }

        public Newspaper(string name, 
            int rating, 
            DateTime publication, 
            string editor, 
            string author,
            object holder, 
            int edition,
            string dest)
            :base(name, rating, publication, editor, author, holder, edition)
        {
            derivedType = "Газета";
            Destination = dest;
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