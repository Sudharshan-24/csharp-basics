using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Harry Potter", "JK Rowling", 400);
            Console.WriteLine(book1.title);

            // modifying title
            book1.title = "Chamber of Secrets";
            Console.WriteLine(book1.title);

            Book book2 = new Book("The Lord of the Rings", "JRR Tolkein", 1216);

            Console.ReadLine();
        }
    }
}
