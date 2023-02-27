using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getters_setters
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie fastandfurious = new Movie("Fast and Furious", "Justin Lin", "test");
            Console.WriteLine(fastandfurious.director);
            Console.WriteLine(fastandfurious.Rating);

            Console.ReadLine();
        }
    }
}
