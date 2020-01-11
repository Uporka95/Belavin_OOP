using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Курсовая
{
    public class Magazine : Periodical
    {
        public string Theme { get; set; }

        public Magazine(object holder) : base(holder)
        {
            derivedType = "Журнал";
            Theme = SetRndTheme();
        }
        public Magazine(string name,
           int rating,
           DateTime publication,
           string editor,
           string author,
           object holder,
           int edition,
           string theme)
           : base(name, rating, publication, editor, author, holder, edition)
        {
            derivedType = "Журнал";
            Theme = theme;
        }

        protected override string SetRndName()
        {
            return RndResource.GetRandomString("MagazineNames");
        }
        protected string SetRndTheme()
        {
            return RndResource.GetRandomString("Themes");
        }
        public override string ToString()
        {
            return base.ToString() + $"{Theme};";
        }
    }
}