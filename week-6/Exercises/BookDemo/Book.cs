using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookDemo
{
    class Book
    {
        public String Isbn { get; set; }
        public String Author { get; set; }
        public String Title { get; set; }
        public virtual double Price { get; set; }

        public override string ToString()
        {
            return String.Format("ISBN {0}\nAuthor {1}\nTitle {2}\nPrice EUR {3:0.00}\n{4}\n", Isbn, Author, Title, Price, GetType());
        }
    }
}
