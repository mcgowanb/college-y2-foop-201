using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    class Player
        //simple player class
    {
        public String Name { get; set; }
        public DateTime Age { get; set; }
        public int Value { get; set; }

        public override string ToString()
        {
            return String.Format("{0} ({1}) - {2:c0}m", Name, CalculateAge(), Value);
        }

        //default no args constructor
        public Player()
        {

        }

        public Player(String name, DateTime age, int value)
        {
            Name = name;
            Age = age;
            Value = value;
        }

        //calculates age based on players age against todays date and returns an integer for display
        public int CalculateAge()
        {
            DateTime today = DateTime.Today;
            int age = today.Year - Age.Year;
            return age;
        }
    }
}
