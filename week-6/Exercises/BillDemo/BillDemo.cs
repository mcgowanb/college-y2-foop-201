using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillDemo
{
    class BillDemo
    {
        static void Main(string[] args)
        {
            Bill bill = new Bill();
            bill.AmountDue = 21.45;
            bill.BillOwner = "Brian McGowan";

            Console.WriteLine(bill);
            Console.WriteLine();

            OverdueBill odBill = new OverdueBill();
            odBill.AmountDue = 99.45;
            odBill.BillOwner = "Frank Kelly";
            odBill.DaysOverdue = 45;

            Console.WriteLine(odBill);
        }
    }
}
