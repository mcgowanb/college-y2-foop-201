using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4
{
    public class ProjectedSales
    {
        public const decimal PROJECTED_INCREASE = (decimal).1;
        public static decimal totalSalesNorth, totalSalesSouth;

        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            totalSalesNorth = 4000;
            totalSalesSouth = 5500;

            totalSalesNorth += totalSalesNorth * PROJECTED_INCREASE;
            totalSalesSouth += totalSalesSouth * PROJECTED_INCREASE;

            Console.WriteLine("Next years projected sales for North Division is: {0:c2} and for the Southern division is: {1:c2}", totalSalesNorth, totalSalesSouth);
        }
    }
}
