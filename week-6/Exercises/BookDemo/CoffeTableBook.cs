using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookDemo
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
                if(value >= 35 && value <= 100)
                    base.Price = value;
            }
        }
    }
}
