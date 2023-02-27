using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
            print("Sudharshan");
            print("Sathya");

            int sum = add(2, 5);
            Console.WriteLine(sum);

            Console.ReadLine();
        }

        static void print(string name)
        {
            Console.WriteLine("Hello, " + name + "!");
        }

        static int add(int a, int b)
        {
            return a + b;
        }
    }
}
