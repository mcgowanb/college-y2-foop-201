using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class BankAccount
    {
        public String AccountNumber { get; set; }
        public decimal Balance { get; set; }
        public decimal OverdraftLimit { get; set; }

        public BankAccount(String accountNumber, decimal overdraftLimit)
        {
            AccountNumber = accountNumber;
            OverdraftLimit = overdraftLimit;
            Balance = 0;
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public String Withdraw(decimal amount)
        {
            String message;
            decimal totalAvailable = Balance + OverdraftLimit;
            if (amount <= totalAvailable)
            {
                Balance -= amount;
                message = String.Format("EUR{0:0.00} withdrawn from account {1}. Balance now is {2:0.00}", amount, AccountNumber, Balance);
            }
            else
            {
                message = String.Format("Sorry, insufficent funds, unable to withdraw EUR{0:0.00} from account {1}", amount, AccountNumber);
            }
            return message;
        }

        public override string ToString()
        {
            String output = String.Format("{0} : {1,-15}\n", "Account Number", AccountNumber);
            output += String.Format("{0} : EUR{1,-15:0.00}\n", "Balance", Balance);
            output += String.Format("{0} : EUR{1,-15:0.00}\n", "Overdraft Limit", OverdraftLimit);
            return output;
        }
    }
}
