using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    class Product
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public decimal Price { get; set; }
        public decimal Tax { get; set; }
        public Variation Type { get; set; }
        public const decimal TAX_RATE = .23m;
        


        public Product() { }
        public Product(string id, string name, decimal price)
        {
            this.ID = id;
            this.Name = name;
            this.Price = price;
            AddTax();
        }

        public Product(string id, string name, decimal price, Variation v)
        {
            this.ID = id;
            this.Name = name;
            this.Price = price;
            this.Type = v;
            AddTax();
        }



        public override string ToString()
        {
            return String.Format("{0}  {1,-20}\t{2}\t{3}\t{4}",
             ID,
             Name,
             Price.ToString("C", CultureInfo.CurrentCulture),
             Tax.ToString("C", CultureInfo.CurrentCulture),
             Type
         );
        }

        public void AddTax()
        {
            Tax = (Price * TAX_RATE);
        }

        public decimal getTotalCost()
        {
            return Price + Tax;
        }
    }
}
