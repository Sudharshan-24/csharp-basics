using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace user_input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name below");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your age");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Welcome {name}, you are {age}");

            Console.ReadLine();
        }
    }
}
