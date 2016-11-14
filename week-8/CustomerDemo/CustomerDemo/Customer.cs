using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerDemo
{
    class Customer
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public double BalanceOutstanding { get; set; }

        public override string ToString()
        {
            return String.Format("Customer ID {0}, Customer Name: {1}, Balance Oustanding: {2:0.00}", ID, Name, BalanceOutstanding);
        }
    }
}
