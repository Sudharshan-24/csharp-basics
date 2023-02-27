using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exception_handling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter a number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter a number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());
                int divide = num1 / num2;
                Console.WriteLine(divide);
            }
            //catch
            //{
            //    Console.WriteLine("Error occurs!");
            //}
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}
