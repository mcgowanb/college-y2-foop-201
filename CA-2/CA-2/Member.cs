using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_2
{
    class Member
    {
        public String Name { get; set; }
        public String  Phone { get; set; }
        public String Address { get; set; }
        public MembershipType MemberShipType { get; set; }
        public int YearJoined { get; set; }

        //constructor
        public Member(String name, String phone, String address, MembershipType type, int year)
        {
            Name = name;
            Phone = phone;
            Address = address;
            MemberShipType = type;
            YearJoined = year;
        }

        //default no args constructor
        public Member()
        {

        }

        // overriding tostring to return name of member
        public override string ToString()
        {
            return Name;
        }

        //method to display the member details in the text block
        public String DisplayMemberDetails()
        {
            return String.Format("{0}\t\t{1}\n{2}\t\t{3}\n{4}\t\t{5}\n{6}\t{7}\n{8}\t{9}",
                "Name:",
                Name,
                "Phone:",
                Phone,
                "Address:",
                Address,
                "Member Type:",
                MemberShipType,
                "Year Joined:",
                YearJoined
                );
        }
    }
}
