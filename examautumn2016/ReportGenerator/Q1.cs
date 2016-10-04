using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportGenerator
{
    class Q1
    {
        static string[] lines;
        static int[] cats = new int[4];
        static int minHour = 5;
        static decimal totalCost;
        const decimal MIN_FEE = 10M;
        const decimal HOURLY_RATE = .10M;

        static void Main(string[] args)
        {
            //Q2 i)
            //Console.WriteLine(Q2.ProductCost('A'));

            //Q2 ii)
            //Console.WriteLine(Q2.CanBuy(16));

            //Q2 iii)
            //Console.WriteLine(Q2.FutureValue(3, 100, .05));

            //Q2 iv)
            //int a = 4;
            //int b = 5;
            //Q2.DoubleValues(ref a, ref b);
            //Console.WriteLine(a + " " + b);

            //Q2 v)
            Console.WriteLine(Q2.Search("c# if fun fun fun", "fun"));
            //Console.WriteLine(Q2.FutureValue(3, 100, .05)) ;

            ReadFromFile();
            ParseData();
            PrintReport();
        }

        public static void ParseData()
        {
            //iterate through the lines
            foreach (string line in lines)
            {
                string[] elements = line.Split(',');
                //only interested in hours, not the user id
                int hours = Convert.ToInt32(elements[1]);

                totalCost += MIN_FEE;
                decimal additionaCost = AddAdditionaCharge(hours);
                AnalyseCategories(additionaCost);
                totalCost += additionaCost;

            }
        }

        private static void AnalyseCategories(decimal charge)
        {
            charge += MIN_FEE;
            if (charge < 20) cats[0]++;
            else if (charge < 40) cats[1]++;
            else if (charge < 60) cats[2]++;
            else cats[3]++;
        }


        // add extra hourly charge
        public static decimal AddAdditionaCharge(int hours)
        {
            decimal rate = 0;
            if(hours > minHour)
            {
                hours -= minHour;
                rate = hours * HOURLY_RATE;
            }
            return rate;
        }

        //reads data from file
        public static void ReadFromFile()
        {
            String pathName = "users.txt";
            lines = File.ReadAllLines(pathName);
        }

        //prints output
        public static void PrintReport()
        {
            Console.WriteLine("{0,-30} {1,-30}", "Spending Range", "Number of Users");
            Console.WriteLine("{0,-30} {1,-30}", "0 - 19.99", cats[0]);
            Console.WriteLine("{0,-30} {1,-30}", "20 - 39.99", cats[1]);
            Console.WriteLine("{0,-30} {1,-30}", "40 - 69.99", cats[2]);
            Console.WriteLine("{0,-30} {1,-30}", "70+", cats[3]);
            Console.WriteLine("Total Spend by all users: {0}", totalCost.ToString("C"));
        }
    }
}