using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Test
{
    public class Magazine : Periodical
    {
        private string theme;

        static Magazine() => HierarhyDictionary.Add(typeof(Magazine), "Журнал");

        [DisplayName("Тема")]
        public string Theme
        {
            get => theme; 
            set
            {
                NotifyPropertyChanged(value.ToString());
                theme = value;
            }
        }


        public Magazine(object holder) : base(holder)
        {
            theme = SetRndTheme();
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
            this.theme = theme;
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