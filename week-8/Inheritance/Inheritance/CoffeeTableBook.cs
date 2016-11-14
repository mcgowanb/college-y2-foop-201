using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class CoffeTableBook : Book
    {

        public override double Price
        {
            get
            {
                return base.Price;
            }

            set
            {
                if (value >= 35 && value <= 100)
                    base.Price = value;
                else throw new IOException(String.Format("Book price for this book as not been set as you have selected {0:0.00}\nIt must be between 35 and 100", value));
            }
        }
    }
}
