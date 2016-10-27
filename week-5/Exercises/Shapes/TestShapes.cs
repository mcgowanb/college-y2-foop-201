using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class TestShapes
    {
        static void Main(string[] args)
        {
            do
            {
                string input = DisplayMenu();
                EvaluateSelection(input);
                Console.WriteLine("Press any key to see the next test" );
                Console.ReadKey();
                Console.Clear();
            } while (true);
            
        }

        private static void EvaluateSelection(String s)
        {
            switch (s.ToUpper())
            {
                case "C":
                    Circle c = new Circle(45);
                    Console.WriteLine(c);
                    break;
                case "R":
                    Rectangle r = new Rectangle(5, 4);
                    Console.WriteLine(r);
                    break;
                case "Y":
                    Cylinder cyl = new Cylinder(7, 11);
                    Console.WriteLine(cyl);
                    break;
                default:
                    Console.WriteLine("Incorrect Input detected, please try again");
                    String input = GetUserSelection();
                    EvaluateSelection(input);
                    break;
            }
        }

        static String DisplayMenu()
        {
            Console.WriteLine("You will be asked to select a figure and then the area of that figure will be displayed\n");
            Console.WriteLine("Please enter the shape you wish to calculate the area of:");

            Console.WriteLine("{0,30}", "CIRCLE........ Enter C");
            Console.WriteLine("{0,30}", "RECTANGLE..... Enter R");
            Console.WriteLine("{0,30}", "CYLNDER....... Enter Y");

            return GetUserSelection();
        }

        private static string GetUserSelection()
        {
            Console.Write("Please enter your selction: ");
            String s = Console.ReadLine();
            return s;
        }
    }
}
