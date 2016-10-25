using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillDemo
{
    class OverdueBill : Bill
    {
        public int DaysOverdue { get; set; }

        public override string ToString()
        {
            String baseString = base.ToString();
            return String.Format("{0}\nThe number of days overdue is {1}", baseString, DaysOverdue);
        }

    }
}
