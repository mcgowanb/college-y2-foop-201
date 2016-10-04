using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    class MilesToFeet
    {
        private const int FEET_IN_MILE = 5280;
        static double distance = 8.5;
        public static void OldMain()
        {
            double distance_in_feet = distance * FEET_IN_MILE;
            Console.WriteLine("My uncles house is {0} miles, or {1} feet", distance, distance_in_feet);

        }
    }
}
