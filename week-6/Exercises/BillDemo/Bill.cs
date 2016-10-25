using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillDemo
{
    class Bill
    {
        public Double AmountDue { get; set; }
        public String BillOwner { get; set; }

        public override string ToString()
        {
            return String.Format("The bill owner is {0} and the amount due is EUR{1:0.00}.\nThe Class name is {2}", BillOwner, AmountDue, GetType());
        }
    }
}
