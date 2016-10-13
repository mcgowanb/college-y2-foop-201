using System;
using System.Collections.Generic;
using System.Linq;

namespace FriendBirthday
{
    class TestFriendBirthday
    {
        static void Main(string[] args)
        {
            Friend[] friends = CreateFriendList();
            printFriends(friends);

            Console.Write("Enter name of friend to find: ");
            String friend = Console.ReadLine();

            try
            {
                Friend result = friends.Single(f => f.FriendName == friend);
                printResult(result);

                IEnumerable<Friend> matches = friends.Where(f => f.BirthdayMonth == result.BirthdayMonth);
                printFriends(matches);


            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Sorry, not friend found matching that name");
            }
        }

        private static void printResult(Friend result)
        {

            Console.WriteLine("Friend details found, Phone number {0}, DOB: {1}/{2}/{3}",
                result.PhoneNumber,
                result.BirthdayDay,
                result.BirthdayMonth,
                result.BirthdayYear
                );

        }

        private static Friend[] CreateFriendList()
        {
            Friend[] friends = new Friend[8];
            friends[0] = new Friend("Brian", 12345, 14, 04, 1982);
            friends[1] = new Friend("Paul", 535345, 14, 05, 1982);
            friends[2] = new Friend("Kirean", 867668, 14, 04, 1982);
            friends[3] = new Friend("Seamus", 3453, 14, 07, 1982);
            friends[4] = new Friend("Allen", 8765, 14, 08, 1982);
            friends[5] = new Friend("Sinead", 23456, 14, 04, 1982);
            friends[6] = new Friend("Geraldine", 36373737, 14, 10, 1982);
            friends[7] = new Friend("Kevin", 352434, 14, 11, 1982);
            return friends;

        }

        private static void printFriends(Friend[] friends)
        {
            Console.WriteLine("Friends list to search is currently as follows:");
            foreach (Friend f in friends)
            {
                Console.WriteLine(f);
            }
            Console.WriteLine();
        }

        private static void printFriends(IEnumerable<Friend> friends)
        {
            Console.WriteLine("The following friends have the same birthdays: ");
            foreach (Friend f in friends)
            {
                Console.WriteLine(f);
            }
            Console.WriteLine();
        }
    }
}
