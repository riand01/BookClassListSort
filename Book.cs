using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BookClassListSort
{
    public class Book
    {
        public string? Title { get; set; }
        public int Year { get; set; }
        public int Pages { get; set; }
        public override string ToString()
        {
            return string.Format("[{0}] {1} {2}", this.Title, this.Pages, this.Year);

        }
    }

    
}
