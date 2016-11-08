using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiFare
{
    class TaxiFare
    {
        const double PRICE_PER_KM = 1.25;
        const double PRICE_PER_MINUTE = .25;
        const int EXTRA_PASSENGER = 1;
        const double LUGGAGE_ITEM = .5;
        const double TAX_RATE = .135;
        static int distance;
        static int time;
        static int passengers;
        static int luggage;
        static double fare;
        static double tax;
        static List<String> taxiFares;


        static void Main(string[] args)
        {
            string rpt = "";
            taxiFares = new List<String>();
            while (rpt != "-999")
            {
                GenerateInput();
                fare = CalculateFare();
                tax = fare * TAX_RATE;
                PrintReport();
                //generate string for file saving
                taxiFares.Add(String.Format("Taxi Fare: EUR {0:0.00}, Tax EUR {1:0.00}, Total Cost EUR {2:0.00}", fare, tax, tax + fare));
                Console.Write("Press Enter to continue, -999 to quit ");
                rpt = Console.ReadLine();
                Console.WriteLine();
            }
            //write list to file
            Console.WriteLine();
            Console.WriteLine("Program Ending, Printing data to file");
            WriteListToFile();
            
        }

        private static void WriteListToFile()
        {
            File.WriteAllLines("fares", taxiFares);
        }

        private static void PrintReport()
        {
            Console.WriteLine("{0,-20} EUR {1:0.00}", "Cost Of Taxi:", fare);
            Console.WriteLine("{0,-20} EUR {1:0.00}", "Tax", tax);
            Console.WriteLine("{0,-20} EUR {1:0.00}", "Total Cost", tax + fare);
        }

        private static double CalculateFare()
        {
            double tempFare = 0;
            tempFare += distance * PRICE_PER_KM;
            tempFare += time * PRICE_PER_MINUTE;

            //adding cost for standard passenger here
            tempFare += EXTRA_PASSENGER;
            // plus any additional passengers
            tempFare += passengers * EXTRA_PASSENGER;
           
            return tempFare;
        }

        public static void GenerateInput()
        {
            Console.Write("{0}", "Enter KM Travelled >> ");
            distance = Convert.ToInt32(Console.ReadLine());

            Console.Write("{0}", "Enter minutes taken >> ");
            time = Convert.ToInt32(Console.ReadLine());

            Console.Write("{0}", "Enter number of extra passengers >> ");
            passengers = Convert.ToInt32(Console.ReadLine());

            Console.Write("{0}", "Enter pieces of luggage, 0 for none >> ");
            luggage = Convert.ToInt32(Console.ReadLine());
        }
    }
}
