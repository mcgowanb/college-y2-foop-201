using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Test();
        }


        public void Test() {
            int[] nums = {2,3,4,5};
            for (int x = 3; x >= 0; --x)
            {
                Console.WriteLine((nums[x]));
            }
        }
    } 
}
