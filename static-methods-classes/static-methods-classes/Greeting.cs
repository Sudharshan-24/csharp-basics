using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_methods_classes
{
    class Greeting
    {
        public static void Greet(string name)
        {
            Console.WriteLine($"Welcome {name}");
        }
    }
}
