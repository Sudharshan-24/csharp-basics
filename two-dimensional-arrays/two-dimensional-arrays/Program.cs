using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace two_dimensional_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = { { 1, 2 }, { 3, 4 }, { 5, 6 } };

            Console.WriteLine(arr[2, 1]);

            Console.ReadLine();
        }
    }
}
