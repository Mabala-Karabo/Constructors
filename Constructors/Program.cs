using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("\"The Power of Positive Thinking\"", "Norman Vincent Pale", 107);
            Book book2 = new Book("\"Forgive YourSelf\"", "Jared Singer", 100);
            Book book3 = new Book("\"Finding Me\"", "Viola Davis", 304);
            Book book4 = new Book("\"LORD Of The Flies\"", "William Golding", 318);
            Console.WriteLine("The first book title " + book1.Title);
            Console.WriteLine("The 2nd book title " + book2.Title);
            Console.WriteLine("The 3rd book title " + book3.Title);
            Console.WriteLine("The 4th book title " + book4.Title);

            Console.ReadLine();
        }
    }
}
