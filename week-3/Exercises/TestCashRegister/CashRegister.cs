using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCashRegister
{
    class CashRegister
    {
        private double total;
        private int numberOfItems;
        public double Total { get { return total; } }
        public int NumberOfItems { get { return numberOfItems; } }
        public String Name { get; set; }

        public CashRegister(String name)
        {
            Name = name;
        }

        public void addItem(double price)
        {
            total += price;
            numberOfItems++;
            Console.WriteLine("Adding item worth {0} to {1}",
                price,
                Name
                );
        }


       


    }
}
