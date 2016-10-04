using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class TestFlight
    {
        static void Main(string[] args)
        {
            Flight flight1 = new Flight("Aer Lingus", 232, 'K', 19);

            Flight flight2 = new Flight();
            flight2.AirlineName = "Ryanair";
            flight2.FlightNumber = 2414;
            flight2.Seat = 'C';
            flight2.Row = 7;


            Console.WriteLine(flight1);
            Console.WriteLine();
            Console.WriteLine(flight2);
        }
    }
}
