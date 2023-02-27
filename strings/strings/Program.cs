using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strings
{
    class Program
    {
        static void Main(string[] args)
        {
            // new line '\n'
            Console.WriteLine("Hello,\nworld!");

            // escape sequence \"\"
            Console.WriteLine("Hello, \"world!\"");

            string myNameIs = "Sudharshan";
            Console.WriteLine(myNameIs);

            // string concatenation '+' operator
            string designation = "Software Developer";
            Console.WriteLine(myNameIs + " " + designation);

            string aboutMe = myNameIs + " " + designation;
            Console.WriteLine(aboutMe);

            // string.Concat()
            Console.WriteLine(string.Concat(aboutMe));

            // string.Join()
            Console.WriteLine(string.Join(" ", aboutMe));

            string about = string.Concat(myNameIs, " ", designation);
            Console.WriteLine(about);

            // string interpolation $"{}"
            Console.WriteLine($"My name is {myNameIs} a {designation} :)");

            // string length '.Length'
            Console.WriteLine(myNameIs.Length);

            // lowercase '.ToLower()'
            Console.WriteLine(myNameIs.ToLower());

            // uppercase '.ToUpper()'
            Console.WriteLine(myNameIs.ToUpper());

            // true / false 'Contains('')'
            Console.WriteLine(myNameIs.Contains('S')); // for single letter use 'single' or "double quotes"
            Console.WriteLine(myNameIs.Contains("Sudhar")); // for too many characters use "double quotes" not 'single quotes', it will throws an error!

            // GetType() - whether it is int/string/char/bool/decimal/double/float
            Console.WriteLine(myNameIs.GetType());

            // access the index of string
            Console.WriteLine(myNameIs[0]);

            // IndexOf()
            Console.WriteLine(myNameIs.IndexOf('s'));
            Console.WriteLine(myNameIs.IndexOf("sudhar")); // prints -1 b'coz of 's', it does'nt exist
            Console.WriteLine(myNameIs.IndexOf("Sudhar")); // 'S' index is '0'
            Console.WriteLine(myNameIs.IndexOf("shan")); // prints '6'

            // Substring()
            Console.WriteLine(myNameIs.Substring(4, 3));

            Console.ReadLine();
        }
    }
}
