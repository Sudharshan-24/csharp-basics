using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datatypes
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Sudharshan";
            int age = 25;
            char grade = 'A';
            double salary = 10000000d;
            decimal tax = 2.25m;
            bool isDev = true;
            float interest = 10.25f;

            Console.WriteLine($"Hello, world! I'm a {name} age {age}. His grade was {grade}. My package is {salary} and I pay tax amount {tax} and I am a Software Developer {isDev}. And I get interest {interest} per month.");

            Console.ReadLine();
        }
    }
}
