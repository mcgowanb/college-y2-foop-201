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
            Console.WriteLine(new Program().CalculateCheckSum("1235567TW"));
        }


        public bool CalculateCheckSum(string value)
        {
            String regex = @"^[0-9]{7}[A-Z]{1,2}$";
            Regex r = new Regex(regex, RegexOptions.IgnoreCase);
            Match m = r.Match(value);
            if (m.Success)
            {
                return CheckMOD23(value);
            }
            else return false;
        }

        public bool CheckMOD23(String value)
        {
            int length = value.Length;
            int total = 0;
            for (int i = 0; i < 7; ++i)
            {
                total += (int)value[i] * (8 - i);
            }

            byte[] asciiBytes = Encoding.ASCII.GetBytes(value.ToUpper());
            if (length == 9)
            {
                total += ((int)asciiBytes[8] - 64) * 9;
            }

            int mod = total % 23;
            if (mod == 0) mod = 23;

            int nV = 63 + mod;
            int cV = asciiBytes[7];
            return nV == cV;
        }
    }
}
