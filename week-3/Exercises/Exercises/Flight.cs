using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class Flight
    {
        public Flight() { }

        public Flight(string name, int flightNumber, char seat, int row)
        {
            AirlineName = name;
            FlightNumber = flightNumber;
            Seat = seat;
            Row = row;
        }

        public String AirlineName { get; set; }
        public int FlightNumber { get; set; }
        public char Seat { get; set; }
        public int Row { get; set; }



        public override string ToString()
        {
            return String.Format("The flight is #{0} on {1}.\nRow {2} Seat {3}.", 
                FlightNumber, 
                AirlineName, 
                Row, 
                Seat
                );
        }
    }
}
