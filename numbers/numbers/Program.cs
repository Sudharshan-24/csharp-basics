using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(22 + 2);

            int a = 5;
            int b = 10;
            Console.WriteLine((a * b) + 2);

            Console.WriteLine(5.4 - 2.1);
            Console.WriteLine(2 % 7);

            int c = 14;
            c++;
            Console.WriteLine(c);

            int d = 8;
            int e = 2;
            e += d;
            Console.WriteLine(d);
            Console.WriteLine(e);

            // Math.Abs() gives us absolute value, eg: negative number -5 returns 5
            Console.WriteLine(Math.Abs(-5));

            // Math.Pow(num, num)
            Console.WriteLine(Math.Pow(4, 5));

            // Math.Floor()
            Console.WriteLine(Math.Floor(24.27));

            // Math.Round()
            Console.WriteLine(Math.Round(5.4)); // 5
            Console.WriteLine(Math.Round(5.6)); // 6

            // Math.Sqrt()
            Console.WriteLine(Math.Sqrt(4));

            // Math.Max() find max value
            Console.WriteLine(Math.Max(4, 5));

            // Math.Min() find min value
            Console.WriteLine(Math.Min(50, 15));

            Console.ReadLine();
        }
    }
}
