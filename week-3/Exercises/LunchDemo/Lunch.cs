using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchDemo
{
    public class Lunch
    {
        public String Dish { get; set; }
        public String Side { get; set; }
        public String Drink { get; set; }

        public Lunch(String dish, String side, String drink)
        {
            Dish = dish;
            Side = side;
            Drink = drink;
        }
    }
}
