using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Revision
{
    class Friend : IComparable
    {
        private const String lineBreak = "=============================================";
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }


        public Friend(String name, String phone, int day, int month, int year)
        {
            Name = name;
            PhoneNumber = phone;
            Day = day;
            Month = month;
            Year = year;
        }
        public override string ToString()
        {
            return String.Format("Name: {0}\nPhone: {1}\nDOB: {2}/{3}/{4}\n{5}", Name, PhoneNumber, Day, Month, Year, lineBreak);

        }

        internal string FileFormat()
        {
            return String.Format("{0},{1},{2}/{3}/{4}", Name, PhoneNumber, Day, Month, Year);
        }

        public int CompareTo(object obj)
        {
            Friend tmp = (Friend)obj;
            return this.Name.CompareTo(tmp.Name);
        }
    }
}
