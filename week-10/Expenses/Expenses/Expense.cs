using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expenses
{
    class Expense
    {

        public String Type { get; set; }
        public String Date { get; set; }
        public decimal Cost { get; set; }

        private String[] types = { "Travel", "Entertainment", "Office" };

        private static Random randomFactory = new Random();

        public Expense()
        {
        }

        public override string ToString()
        {
            return String.Format("{0,-40} {1:C} \ton {2}", Type, Cost, Date);
        }
    }
}
