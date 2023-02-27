using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            while (i <= 5)
            {
                Console.WriteLine(i);
                i++;
            }

            int evenNum = 0;

            while (evenNum < 10)
            {
                evenNum += 2;
                Console.WriteLine(evenNum);
            }

            int oddNum = 0;

            while (oddNum < 10)
            {
                if (oddNum % 2 != 0)
                {
                    Console.WriteLine(oddNum);
                }
                oddNum++;
            }

            Console.ReadLine();
        }
    }
}
