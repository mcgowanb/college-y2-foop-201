using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerDemo
{
    class Program
    {
        public static List<Customer> customers;
        static void Main(string[] args)
        {
            customers = new List<Customer>();

            CreditCustomer c1 = new CreditCustomer() { Name = "Brian", BalanceOutstanding = 20, ID = "1", InterestRate = 1.2 };
            CreditCustomer.TotalOwed += c1.BalanceOutstanding;
            customers.Add(c1);

            CreditCustomer c2 = new CreditCustomer() { Name = "Paul", BalanceOutstanding = 40, ID = "3" ,InterestRate = 1.4 };
            CreditCustomer.TotalOwed += c2.BalanceOutstanding;
            customers.Add(c2);

            CreditCustomer c3 = new CreditCustomer() { Name = "Stephen", BalanceOutstanding = 80, ID = "2", InterestRate = 2.5 };
            CreditCustomer.TotalOwed += c3.BalanceOutstanding;
            customers.Add(c3);

            CreditCustomer c4 = new CreditCustomer() { Name = "Kevin", BalanceOutstanding = 140, ID = "5", InterestRate = 3 };
            CreditCustomer.TotalOwed += c4.BalanceOutstanding;
            customers.Add(c4);

            CreditCustomer c5 = new CreditCustomer() { Name = "Shane", BalanceOutstanding = 16, ID = "4", InterestRate = 8.5 };
            CreditCustomer.TotalOwed += c5.BalanceOutstanding;
            customers.Add(c5);

            customers.Sort();
            print();
            Console.WriteLine("Total Owed: {0:0.00}", CreditCustomer.TotalOwed);
        }

        public static void print()
        {
            foreach (var c in customers)
            {
                Console.WriteLine(c);
            }
        }
    }
}
