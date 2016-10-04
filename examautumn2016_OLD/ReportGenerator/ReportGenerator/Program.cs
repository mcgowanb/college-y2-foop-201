using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportGenerator
{
    class Program
    {
        static string[] lines;
        static int[] cats = new int[4];
        static int minHour = 5;
        static decimal totalCost;
        const decimal HOURLY_RATE = .10M;
        static void Main(string[] args)
        {
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
                int hours = Convert.ToInt32(elements[1]);
                if (hours < minHour)
                {
                    totalCost += 10;
                    cats[0]++;
                }
                else
                {
                    totalCost += AddAdditionaCharge(hours);
                }

            }
        }

        // add extra hourly charge
        public static decimal AddAdditionaCharge(int hours)
        {
            hours -= 10;
            return hours * HOURLY_RATE;
        }

        public static void ReadFromFile()
        {
            String pathName = "users.txt";
            lines = File.ReadAllLines(pathName);
        }

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
