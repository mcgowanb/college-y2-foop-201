using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolsDemo
{
    class School : IComparable
    {
        private int enrollment;
        private String name;

        public School(int enrollment, String name)
        {
            this.enrollment = enrollment;
            this.name = name;
        }

        //public int CompareTo(object obj)
        //{
        //    School tempSchool = (School)obj;
        //    return this.enrollment.CompareTo(tempSchool.enrollment);
        //}

        public int CompareTo(object obj)
        {
            School tempSchool = (School)obj;
            int val = 0;
            if (this.enrollment < tempSchool.enrollment)
                val = 1;
            else if (this.enrollment > tempSchool.enrollment)
                val = -1;

            return val;
        }

        public int Enrollment {
            get
            {
                return this.enrollment; 
            }
        }

        public override string ToString()
        {
            return String.Format("{0} school has {1} students", name, enrollment);
        }
    }
}
