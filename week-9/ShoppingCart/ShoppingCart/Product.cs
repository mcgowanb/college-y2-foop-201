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
        public const decimal TAX_RATE = .23m;

        public Product(string id, string name, decimal price)
        {
            this.ID = id;
            this.Name = name;
            this.Price = price;
        }

        public override string ToString()
        {
            return String.Format("{0}\t{1}\t{2}\t{3}",
                ID,
                Name,
                Price.ToString("C"),
                Tax.ToString("C")
            );
        }

        public void AddTax()
        {
            Tax += (Price * TAX_RATE);
        }
    }
}
