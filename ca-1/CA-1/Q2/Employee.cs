using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    class Employee : IComparable
    {
        public static int NoOfEmployees;
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String EmployeeID { get; set; }
        private List<Holiday> holidays;
        private int NoOfHolidayDays;

        private Double salary;
        public Double Salary
        {
            get { return salary; }
        }

        public String Department { get; set; }

        //Constructor, setting employee id, salary and holidays
        public Employee(String employeeID, double salary, int hols)
        {
            this.salary = salary;
            this.NoOfHolidayDays = hols;
            EmployeeID = employeeID;
            NoOfEmployees++;
            holidays = new List<Holiday>();
        }


        public void PayRise(double rate)
        {
            salary += salary * (rate / 100);
        }

        public void BookHolidays(String startDate, String endDate)
        {
            Holiday h = new Holiday(startDate, endDate);
            //adding each booked holiday to the list
            holidays.Add(h);
            if (NoOfHolidayDays >= h.GetHolidayLength()) {
                NoOfHolidayDays -= h.GetHolidayLength();
                h.SetStatus(Holiday.HolidayStatus.Approved);
                Console.WriteLine("{2}, You have successfully booked {0} days holidays\nYou have {1} days remaining", h.GetHolidayLength(), NoOfHolidayDays, FirstName);
            }
            else
            {
                Console.WriteLine("Sorry, not enough holidays left {2}, you have {0} days and you are requesting {1}", NoOfHolidayDays, h.GetHolidayLength(), FirstName);
                h.SetStatus(Holiday.HolidayStatus.Declined);
            }
        }

        public override string ToString()
        {
            return String.Format("Employee {0} {1} {2} Works in the {3} department on a basic salary of EUR {4:0,000}", EmployeeID, FirstName, LastName, Department, Salary);
        }

        public void DisplayHolidays()
        {
            Console.WriteLine("===================== HOLIDAY REPORT ===========================");
            foreach (var h in holidays)
            {
                Console.WriteLine(h);
            }
            Console.WriteLine("================= END HOLIDAY REPORT ===========================");
        }

        public int CompareTo(object obj)
        {
            Employee tmp = (Employee)obj;
            return this.LastName.CompareTo(tmp.LastName);
        }
    }
}
