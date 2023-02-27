using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class Chef
    {
        public void MakePizza()
        {
            Console.WriteLine("The Chef makes Pizza");
        }

        public void MakeBurger()
        {
            Console.WriteLine("The Chef makes Burger");
        }

        public virtual void MakeSpecialDish()
        {
            Console.WriteLine("The Chef makes Dal Makhani");
        }
    }
}
