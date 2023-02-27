using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace object_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Sudharshan", "MCA", 4);
            Console.WriteLine(student1.name);
            Console.WriteLine(student1.HasHonors());
            Console.WriteLine(student1.Country("India"));

            Student student2 = new Student("xxx", "MCA", 3);
            Console.WriteLine(student2.HasHonors());

            Console.ReadLine();
        }
    }
}
