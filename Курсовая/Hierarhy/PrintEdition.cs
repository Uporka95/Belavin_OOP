using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Курсовая
{
    [Serializable]
    public abstract class PrintEdition
    {
        
        public PrintEdition()
        {
           
        }

        
        public string Name { get; set; }
        public int Rating { get; set; }

        public DateTime Publication { get; set; }

        public string Editor { get; set; }

        public string Author { get; set; }

        public string Holder { get; set; }

        public override string ToString()
        {
            return $"{Name};{Author}{Editor};{Rating};{Publication};{Holder};{ISBN}";
        }
    }
}