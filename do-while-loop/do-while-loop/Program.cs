using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_while_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int index = 1;

            do
            {
                Console.WriteLine("Hello");
                index++;
            } while (index <= 5);

            int evenNum = 2;

            do
            {
                Console.WriteLine(evenNum);
                evenNum += 2;
            } while (evenNum <= 10);

            int oddNum = 1;

            do
            {
                Console.WriteLine(oddNum);
                oddNum += 2;
            } while (oddNum <= 10);

            Console.ReadLine();
        }
    }
}
