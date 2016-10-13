using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolsDemo
{
    class TestSchool
    {
        static void Main(string[] args)
        {
            School school1 = new School(824, "Summerhill");
            School school2 = new School(711, "Ursuline");
            School school3 = new School(811, "Mercy Convent");
            School school4 = new School(450, "Grammar");
            School school5 = new School(320, "Ballisodare");

            School[] schools = new School[5];
            schools[0] = school1;
            schools[1] = school2;
            schools[2] = school3;
            schools[3] = school4;
            schools[4] = school5;

            PrintSchoolList(schools);
            
            Array.Sort(schools);
            Array.Reverse(schools);

            PrintSchoolList(schools);

            Console.Write("Enter a minimum enrollment to be displayed ");
            int minimumLimit = Convert.ToInt32(Console.ReadLine());


            //IEnumerable<School> query = from sch in schools
            //            where sch.Enrollment >= minimumLimit
            //            select sch;

            IEnumerable<School> query = schools.Where(sch => sch.Enrollment > minimumLimit);

            PrintSchoolList(query);

        }

        static void PrintSchoolList(School[] schools)
        {
            foreach (School school in schools)
            {
                Console.WriteLine(school);
            }
            Console.WriteLine("\n\n");
        }

        static void PrintSchoolList(IEnumerable<School> schools)
        {
            foreach (School school in schools)
            {
                Console.WriteLine(school);
            }
            Console.WriteLine("\n\n");
        }
    }
}
