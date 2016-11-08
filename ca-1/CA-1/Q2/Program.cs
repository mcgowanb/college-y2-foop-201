using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    class Program
    {
        static List<Employee> employees;
        static void Main(string[] args)
        {
            employees = new List<Employee>();
            Employee e1 = new Employee("emp215", 30000, 10);
            e1.FirstName = "Tom";
            e1.LastName = "Jones";
            e1.Department = "Sales";
            employees.Add(e1);

            Employee e2 = new Employee("emp145", 45000, 12);
            e2.FirstName = "Mary";
            e2.LastName = "Smith";
            e2.Department = "Finance";
            employees.Add(e2);

            Employee e3 = new Employee("emp220", 22500, 4);
            e3.FirstName = "Francis";
            e3.LastName = "Kelly";
            e3.Department = "Dev Ops";
            employees.Add(e3);

            Employee e4 = new Employee("emp914", 35000, 20);
            e4.FirstName = "Brian";
            e4.LastName = "McGowan";
            e4.Department = "Development";
            employees.Add(e4);

            PrintEmployees();
            GivePayRises();
            PrintEmployees();

            Console.WriteLine("-------------------------------- SORTING EMPLOYEES ------------------------");
            employees.Sort();
            PrintEmployees();

            Console.WriteLine();
            //testing employee holidays method
            BookEmployeeHolidays();

        }

        private static void BookEmployeeHolidays()
        {
            Console.WriteLine("-------------------------------- HOLIDAY BOOKING ------------------------");
            //booking holidays, deducting from total and unable to go over available days
            employees[0].BookHolidays("01/12/2015", "30/12/2015");
            employees[0].BookHolidays("01/12/2015", "08/12/2015");
            employees[0].BookHolidays("10/12/2015", "14/12/2015");
            employees[0].DisplayHolidays();

            Console.WriteLine();
            employees[1].BookHolidays("12/12/2015", "15/12/2015");
            employees[1].DisplayHolidays();
            Console.WriteLine();

        }

        private static void GivePayRises()
        {
            Console.WriteLine("-------------------------------- GIVING PAY RISES ------------------------");
            employees[0].PayRise(12.5);
            employees[1].PayRise(10);
            employees[2].PayRise(15);
            employees[3].PayRise(6.5);
        }

        static void PrintEmployees()
        {
            foreach (Employee emp in employees)
            {
                Console.WriteLine(emp);
            }
        }
    }
}
