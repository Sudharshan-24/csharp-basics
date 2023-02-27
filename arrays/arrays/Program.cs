using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] favNums = { 5, 24, 97 };
            Console.WriteLine(favNums[1]);
            favNums[2] = 4;
            // Console.WriteLine(favNums);
            Console.WriteLine(string.Join(" ", favNums));

            string[] names = new string[3];
            names[0] = "Sudharshan";
            names[1] = "Sathya";
            names[2] = "Lakshmi";
            Console.WriteLine(string.Join(", ", names));

            int[] arrNum = new int[] { 1, 2, 3, 4, 5};

            foreach (int arr in arrNum)
            {
                Console.WriteLine(arr);
            }

            Console.ReadLine();
        }
    }
}
