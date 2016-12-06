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
            Type = getRandomType();
            Date = getRandomDate();
            Cost = getRandomCost();
        }

        private decimal getRandomCost()
        {
            decimal cost = (randomFactory.Next(10001) / 100);
            return cost;
        }

        private String getRandomType()
        {
            int rnd = randomFactory.Next(0, 2);
            return types[rnd];
        }

        private String getRandomDate()
        {
            DateTime d = DateTime.Today.AddDays(randomFactory.Next(0, 31));
            return d.ToShortDateString();
        }

        public override string ToString()
        {
            return String.Format("{0} {1:C} on {2}", Type, Cost, Date);
        }
    }
}
