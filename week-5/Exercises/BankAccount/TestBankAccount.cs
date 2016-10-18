using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class TestBankAccount
    {
        static void Main(string[] args)
        {
            BankAccount b1 = new BankAccount("A1234", 250);
            Console.WriteLine(b1);

            BankAccount b2 = new BankAccount("B45646", 7500);
            Console.WriteLine(b2);
            Console.WriteLine();

            b1.Deposit(500);
            Console.WriteLine("Depositing 500 into account - {0}, new balance now is: {1:0.00}", b1.AccountNumber, b1.Balance);

            b2.Deposit(975);
            Console.WriteLine("Depositing 975 into account - {0}, new balance now is: {1:0.00}", b2.AccountNumber, b2.Balance);
            Console.WriteLine();

            Console.WriteLine(b1.Withdraw(200));

            Console.WriteLine(b2.Withdraw(9500));
        }
    }
}
