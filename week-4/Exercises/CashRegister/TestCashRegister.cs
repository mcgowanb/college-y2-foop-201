using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCashRegister
{
    class TestCashRegister
    {
        static void Main(string[] args)
        {
            CashRegister cr1 = new CashRegister("Cash Register 1");
            cr1.addItem(2.70);
            cr1.addItem(3.45);
            cr1.addItem(5.97);

            CashRegister cr2 = new CashRegister("Cash Regster 2");
            cr2.addItem(12.52);
            cr2.addItem(1.43);
            cr2.addItem(15.57);
            cr2.addItem(5.15);

            Console.WriteLine("\n{0} Total: {1}\nCash Register CR1 Total Number of Items: {2}", cr1.Name, cr1.Total, cr1.NumberOfItems);
            Console.WriteLine("{0} Total: {1}\nCash Register CR2 Total Number of Items: {2}", cr2.Name, cr2.Total, cr2.NumberOfItems);

            Console.WriteLine("\nTotal money from all cash registers: {0}", CashRegister.totalCash);
            Console.WriteLine("Total items from all cash registers: {0}", CashRegister.totalItems);
        }
    }
}
