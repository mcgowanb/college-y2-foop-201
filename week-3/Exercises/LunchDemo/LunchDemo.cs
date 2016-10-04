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

        static void displayLunch(Lunch l1, Lunch l2, Lunch l3)
        {
            Console.WriteLine("{0,-20}{1,-20}{2,-20}", "Dish", "Side", "Drink");
            Console.WriteLine("{0,-20}{1,-20}{2,-20}", l1.Dish, l1.Side, l1.Drink);
            Console.WriteLine("{0,-20}{1,-20}{2,-20}", l2.Dish, l2.Side, l2.Drink);
            Console.WriteLine("{0,-20}{1,-20}{2,-20}", l3.Dish, l3.Side, l3.Drink);
        }

        static void displayLunch(Lunch l1, Lunch l2, Lunch l3, Lunch l4)
        {
            Console.WriteLine("{0,-20}{1,-20}{2,-20}", "Dish", "Side", "Drink");
            Console.WriteLine("{0,-20}{1,-20}{2,-20}", l1.Dish, l1.Side, l1.Drink);
            Console.WriteLine("{0,-20}{1,-20}{2,-20}", l2.Dish, l2.Side, l2.Drink);
            Console.WriteLine("{0,-20}{1,-20}{2,-20}", l3.Dish, l3.Side, l3.Drink);
            Console.WriteLine("{0,-20}{1,-20}{2,-20}", l4.Dish, l4.Side, l4.Drink);
        }

        static void displayLunch(Lunch l1, Lunch l2, Lunch l3, Lunch l4, Lunch l5)
        {
            Console.WriteLine("{0,-20}{1,-20}{2,-20}", "Dish", "Side", "Drink");
            Console.WriteLine("{0,-20}{1,-20}{2,-20}", l1.Dish, l1.Side, l1.Drink);
            Console.WriteLine("{0,-20}{1,-20}{2,-20}", l2.Dish, l2.Side, l2.Drink);
            Console.WriteLine("{0,-20}{1,-20}{2,-20}", l3.Dish, l3.Side, l3.Drink);
            Console.WriteLine("{0,-20}{1,-20}{2,-20}", l4.Dish, l4.Side, l4.Drink);
            Console.WriteLine("{0,-20}{1,-20}{2,-20}", l5.Dish, l5.Side, l5.Drink);
        }

    }
}
