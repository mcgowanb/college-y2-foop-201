using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    class Holiday
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        private String status;

        public String Status
        {
            get { return status; }
        }

        public enum HolidayStatus
        {
            Declined, Approved
        }

        public Holiday(String startDate, String endDate)
        {
            StartDate = Convert.ToDateTime(startDate);
            EndDate = Convert.ToDateTime(endDate);
        }


       public int GetHolidayLength()
        {
            return (EndDate - StartDate).Days;
        }

        public void SetStatus(HolidayStatus status)
        {
            if (status == HolidayStatus.Approved) this.status = "Approved";
            else this.status = "Declined";
        }

        public override string ToString()
        {
            return String.Format("Holiday Start Date {0:dd/M/yyyy}, End Date: {1:dd/M/yyyy}, No Of Days: {2} Status {3}", StartDate, EndDate, GetHolidayLength(), Status);
        }
    }
}
