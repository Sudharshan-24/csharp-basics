using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class ItalianChef : Chef
    {
        public void MakePizzaMargherita()
        {
            Console.WriteLine("The Italian Chef makes Pizza Margherita");
        }

        public override void MakeSpecialDish()
        {
            Console.WriteLine("The Chef makes Summer Zucchini Pasta");
        }
    }
}
