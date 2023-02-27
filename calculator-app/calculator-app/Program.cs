using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator_app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter another number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter number 1 to 5");
            Console.Write("1.Addition\n2.Subtraction\n3.Multiplication\n4.Division\n5.Modulus");
            
            Console.Write("Input your choice: ");
            double result = Convert.ToDouble(Console.ReadLine());

            switch(result)
            {
                case 1:
                    Console.WriteLine(num1 + num2);
                    break;
                case 2:
                    Console.WriteLine(num1 - num2);
                    break;
                case 3:
                    Console.WriteLine(num1 * num2);
                    break;
                case 4:
                    Console.WriteLine(num1 / num2);
                    break;
                case 5:
                    Console.WriteLine(num1 % num2);
                    break;
                default:
                    Console.WriteLine("Invalid input!");
                    break;
            }

            Console.ReadLine();
        }
    }
}
