using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes_and_objects
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.title = "Head First C#";
            book1.author = "Andrew Stellman & Jennifer Greene";
            book1.pages = 800;

            Console.WriteLine(book1.title);
            Console.WriteLine(book1.author);

            Book book2 = new Book();
            book2.title = "Pragmatic Programmer";
            book2.author = "David Thomas & Andrew Hunt";
            book2.pages = 321;

            Console.WriteLine(book2.title);
            Console.WriteLine(book2.author);

            Console.ReadLine();
        }
    }
}
