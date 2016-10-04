using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    class Program
    {
        private const int FEET_IN_MILE = 5280;
        static double distance;
        static double distanceInFeet;
        static void Main(string[] args)
        {
            MilesToFeet.OldMain();
            Console.WriteLine();

            Console.Write("Please enter the distance in miles to uncle's house: ");
            distance = Convert.ToDouble(Console.ReadLine());
            distanceInFeet = distance * FEET_IN_MILE;
            Console.WriteLine("My uncles house is {0} miles, or {1} feet", distance, distanceInFeet);

        }
    }
}
