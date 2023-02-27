using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variables
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Sudharshan";
            int age = 25;
            string work = "Software Developer";

            Console.WriteLine("My name is " + name + ":)");
            Console.WriteLine($"He was {age} years old.");
            Console.WriteLine($"My profession is {work}.");

            Console.ReadLine();
        }
    }
}
