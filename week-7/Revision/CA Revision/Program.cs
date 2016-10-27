using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Revision
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] linesInFile = File.ReadAllLines("data.txt");
            Friend[] friends = new Friend[linesInFile.Length];
            string[] newThings = new string[linesInFile.Length];

            for (int i = 0; i < linesInFile.Length; i++)
            {
                string[] lData = linesInFile[i].Split(',');
                string n = lData[0];
                string p = lData[1];
                int d = Convert.ToInt32(lData[2]);
                int m = Convert.ToInt32(lData[3]);
                int y = Convert.ToInt32(lData[4]);

                Friend f = new Friend(n, p, d, m, y);
                friends[i] = f;
            }

            foreach (Friend f in friends)
            {
                Console.WriteLine(f);
            }
            Console.WriteLine();
            Array.Sort(friends);

            for (int i = 0; i < linesInFile.Length; i++)
            {
                Console.WriteLine(friends[i]);
                newThings[i] = friends[i].FileFormat();
            }

            File.WriteAllLines("notFunny.txt", newThings);

        }
    }
}
