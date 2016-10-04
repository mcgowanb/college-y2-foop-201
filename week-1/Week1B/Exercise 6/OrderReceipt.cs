using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_6
{
    class OrderReceipt
    {
        const decimal BLENDER_RATE = (decimal)39.95;
        const decimal TAX_RATE = (decimal).09;
        static int noOfUnits;
       
        static decimal totalCost, taxCost, netCost;
        static string name, street, city, county, eircode;
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            GetInputs();

            totalCost = noOfUnits * BLENDER_RATE;
            taxCost = totalCost * TAX_RATE;
            netCost = totalCost + taxCost;

            WriteOutputs();


        }

        public static void WriteOutputs()
        {
            Console.Clear();
            Console.WriteLine("Magic Blender Ordering System");
            Console.WriteLine("{0,-30}{1,-10}\n", "==============================", "===========");
            Console.WriteLine("{0,-30} {1, -30}", "Name", name);
            Console.WriteLine("{0,-30} {1, -30}", "Street", street);
            Console.WriteLine("{0,-30} {1, -30}", "City", city);
            Console.WriteLine("{0,-30} {1, -30}", "County", county);
            Console.WriteLine("{0,-30} {1, -30}", "Eircode", eircode);
            Console.WriteLine("{0,-30} {1, -30}", "Qty Ordered", noOfUnits);
            Console.WriteLine("{0,-30}{1,-10}\n", "==============================", "===========");

            Console.WriteLine("{0, -30} {1, 10:c2}", "Amount due before tax:", totalCost);
            Console.WriteLine("{0, -30} {1, 10:c2}", "Sales tax:", taxCost);
            Console.WriteLine("{0, -30} {1, 10:c2}", "Net Due:", netCost);
            Console.WriteLine("{0, -30} {1, 10:c2}", " ", "==========");
        }


        public static void GetInputs()
        {
            Console.Write("{0,-30}", "Please enter your name:");
            name = Console.ReadLine();

            Console.Write("{0,-30}", "Please enter street address:");
            street = Console.ReadLine();

            Console.Write("{0,-30}", "Please enter city:");
            city = Console.ReadLine();

            Console.Write("{0,-30}", "Please enter county:");
            county = Console.ReadLine();

            Console.Write("{0,-30}", "Please enter your eircode:");
            eircode = Console.ReadLine();

            Console.Write("{0,-30}", "Please enter quantity:");
            noOfUnits = Convert.ToInt32(Console.ReadLine());
        }
    }
}
