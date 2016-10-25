using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookDemo
{
    class TextBook : Book
    {
        public String GradeLevel { get; set; }

        public override double Price
        {
            get
            {
                return base.Price;
            }

            set
            {
                if (value >= 20 && value <= 80)
                    base.Price = value;
                //else throw new IOException("Book price must be between 20 and 80");
            }
        }
    }
}
