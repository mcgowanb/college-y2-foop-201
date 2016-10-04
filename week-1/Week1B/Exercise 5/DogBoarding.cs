using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5
{
    class DogBoarding
    {
        public const double RATE_PER_DAY = .5;

        static void Main(string[] args)
        {
            int animalWeight;
            int numberOfDays;
            decimal totalCost;
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Please enter the dog's weight in pounds: ");
            animalWeight = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter the length of stay for the dog: ");
            numberOfDays = Convert.ToInt32(Console.ReadLine());

            totalCost = (decimal)(animalWeight * numberOfDays * RATE_PER_DAY);
            Console.WriteLine("Total cost of the stay for this dog is: {0:c2}", totalCost);

        }
    }
}
