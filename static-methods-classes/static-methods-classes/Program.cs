using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_methods_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Math.Sqrt(24));

            Greeting.Greet("Sudharshan");

            Console.ReadLine();
        }
    }
}
