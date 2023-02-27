using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_statements
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isMale = true;
            bool isTall = true;

            if (isMale == true && isTall)
            {
                Console.WriteLine("You're Male and Tall");
            }
            else
            {
                Console.WriteLine("You're not a Male and Tall!");
            }

            Console.Write("Enter a number ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a number ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int getMax = GetMax(num1, num2);
            Console.WriteLine(getMax);

            int getMin = GetMin(1, 2, 3);
            Console.WriteLine(getMin);

            Console.ReadLine();
        }
        static int GetMax(int num1, int num2)
        {
            int result;

            if (num1 > num2)
            {
                result = num1;
                //Console.WriteLine($"Number 1 {num1} is greater than Number 2 {num2}");
            }
            else
            {
                result = num2;
                //Console.WriteLine($"Number 2 {num2} is greater than Number 1 {num1}");
            } 
            //else
            //{
            //    Console.WriteLine($"Both Number 1 {num1} and Number 2 {num2} are same");
            //}

            return result;
        }
        static int GetMin(int a, int b, int c)
        {
            int result;

            if (a >= b && a>= c)
            {
                result = a;
            } else if (b >= a && b >= c)
            {
                result = b;
            } else if (c >= a && c >= b)
            {
                result = c;
            }
            else
            {
                result = 0;
            }

            return result;
        }
    }
}
