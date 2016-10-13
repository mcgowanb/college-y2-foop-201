using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendBirthday
{
    class Friend : IComparable
    {
        public String FriendName { get; set; }
        public int PhoneNumber { get; set; }
        public int BirthdayDay { get; set; }
        public int BirthdayMonth { get; set; }
        public int BirthdayYear { get; set; }

        public Friend(String friendName, int phoneNumber, int birthday, int month, int year)
        {
            FriendName = friendName;
            PhoneNumber = phoneNumber;
            BirthdayDay = birthday;
            BirthdayMonth = month;
            BirthdayYear = year;
        }

        public override string ToString()
        {
            return String.Format("Friend Name: {0} Phone Number: {1} DOB: {2}/{3}/{4}",
            FriendName,
            PhoneNumber,
            BirthdayDay,
            BirthdayMonth,
            BirthdayYear
            );
        }

        public int CompareTo(object obj)
        {
            Friend tmp = (Friend)obj;
            return String.Compare(this.FriendName, tmp.FriendName);
        }
    }
}
