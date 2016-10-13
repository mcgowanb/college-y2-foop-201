using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchDemo
{
    class LunchDemo
    {
        static void Main(string[] args)
        {
            Lunch lunch1 = new Lunch("hamburger", "fries", "cola");
            Lunch lunch2 = new Lunch("Hot dog", "chips", "lemonade");
            Lunch lunch3 = new Lunch("Pizza", "Salad", "Iced Tea");
            Lunch lunch4 = new Lunch("Tuna Sandwich", "Fruit Cup", "Water");
            Lunch lunch5 = new Lunch("Peanut Butter SW", "Cookie", "Milk");

            displayLunch(lunch1, lunch2, lunch3);
            Console.WriteLine();

            displayLunch(lunch1, lunch2, lunch3, lunch4);
            Console.WriteLine();

            displayLunch(lunch1, lunch2, lunch3, lunch4, lunch5);
        }

        static void displayLunch(params Lunch[] lunches)
        {
            Console.WriteLine("{0,-20}{1,-20}{2,-20}", "Dish", "Side", "Drink");
            foreach (Lunch lunch in lunches)
            {
                Console.WriteLine("{0,-20}{1,-20}{2,-20}", lunch.Dish, lunch.Side, lunch.Drink);
            }
        }
    }
}
