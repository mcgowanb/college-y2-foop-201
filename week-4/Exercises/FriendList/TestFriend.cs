using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendList
{
    class TestFriend
    {
        static void Main(string[] args)
        {
            Friend[] friends = new Friend[8];

            for (int i = 0; i < friends.Length; i++)
            {
                friends[i] = getFriendInput();
            }

            Array.Sort(friends);

            printFriends(friends);
        }

        private static void printFriends(Friend[] friends)
        {
            foreach (Friend f in friends)
            {
                Console.WriteLine(f);
            }
        }

        public static Friend getFriendInput()
        {
            Friend f = new Friend();
            Console.Write("Enter Friend Name: ");
            f.FriendName = Console.ReadLine();
            Console.Write("Enter Friend Phone Number: ");
            f.PhoneNumber = Convert.ToInt32(Console.ReadLine());
            return f;
        }
    }

   
}
