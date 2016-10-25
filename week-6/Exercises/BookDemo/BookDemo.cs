using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookDemo
{
    class BookDemo
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            book.Author = "Mr Men";
            book.Title = "BOok Title";
            book.Isbn = "1234";
            book.Price = 12.50;

            Console.WriteLine(book);

            TextBook tBook = new TextBook();
            tBook.Author = "Mr Men";
            tBook.Title = "Invalid Price";
            tBook.Isbn = "1234";
            tBook.Price = 12.50;

            Console.WriteLine(tBook);

            TextBook tBook2 = new TextBook();
            tBook2.Author = "Mr Men";
            tBook2.Title = "Valid Price";
            tBook2.Isbn = "1234";
            try
            {
                tBook2.Price = 22.50;
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
            

            Console.WriteLine(tBook2);

            CoffeTableBook ctBook = new CoffeTableBook();
            ctBook.Author = "Mr Men";
            ctBook.Title = "Invalid Price";
            ctBook.Isbn = "1234";
            ctBook.Price = 34.99;

            Console.WriteLine(ctBook);

            CoffeTableBook ctBook2 = new CoffeTableBook();
            ctBook2.Author = "Mr Men";
            ctBook2.Title = "Invalid Price";
            ctBook2.Isbn = "1234";
            ctBook2.Price = 100;

            Console.WriteLine(ctBook2);
        }
    }
}
