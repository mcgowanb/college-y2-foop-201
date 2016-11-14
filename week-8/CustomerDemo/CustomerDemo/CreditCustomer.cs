using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerDemo
{
    class CreditCustomer : Customer, IComparable
    {
        public double InterestRate { get; set; }
        public static double TotalOwed;

        public int CompareTo(object obj)
        {
            CreditCustomer c = (CreditCustomer)obj;
            return this.ID.CompareTo(c.ID);
        }

        public override string ToString()
        {
            return String.Format("Customer ID {0}, Customer Name: {1}, Balance Oustanding: {2:0.00}, Interest Rate: {3:0.00}", ID, Name, BalanceOutstanding, InterestRate);
        }
    }
}
