using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Bird: Animal
    {
        public override void walk()
        {
            Console.WriteLine("Wallking with 2 legs");
        }
    }
}
