using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator_new
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter these operators only (+, -, *, /, %)");
            Console.Write("Enter a operator: ");
            string operators = Console.ReadLine();

            Console.Write("Enter a number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            //if (operators == "+")
            //{
            //    Console.WriteLine(num1 + num2);
            //}
            //else if (operators == "-")
            //{
            //    Console.WriteLine(num1 - num2);
            //}
            //else if (operators == "*")
            //{
            //    Console.WriteLine(num1 * num2);
            //}
            //else if (operators == "/")
            //{
            //    Console.WriteLine(num1 / num2);
            //}
            //else if (operators == "%")
            //{
            //    Console.WriteLine(num1 % num2);
            //}
            //else
            //{
            //    Console.WriteLine("Invalid operator");
            //}

            switch (operators)
            {
                case "+":
                    Console.WriteLine(num1 + num2);
                    break;
                case "-":
                    Console.WriteLine(num1 - num2);
                    break;
                case "*":
                    Console.WriteLine(num1 * num2);
                    break;
                case "/":
                    Console.WriteLine(num1 / num2);
                    break;
                case "%":
                    Console.WriteLine(num1 % num2);
                    break;
                default:
                    Console.WriteLine("Invalid operator");
                    break;
            }

            Console.Write("Enter day 1 to 7: ");
            int getDayNum = Convert.ToInt32(Console.ReadLine());
            string getDay = GetDay(getDayNum);
            Console.WriteLine(getDay);

            Console.ReadLine();
        }
        static string GetDay(int dayNum)
        {
            string dayName;

            switch (dayNum)
            {
                case 1:
                    dayName = "Sunday";
                    break;
                case 2:
                    dayName = "Monday";
                    break;
                case 3:
                    dayName = "Tuesday";
                    break;
                case 4:
                    dayName = "Wednesday";
                    break;
                case 5:
                    dayName = "Thursday";
                    break;
                case 6:
                    dayName = "Friday";
                    break;
                case 7:
                    dayName = "Saturday";
                    break;
                default:
                    dayName = "Invalid day";
                    break;
            }

            return dayName;
        }
    }
}
