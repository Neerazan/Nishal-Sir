using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal abstract class Dog: Animal
    {
        public void eat()
        {
            Console.WriteLine("Barking.....");
            Console.WriteLine("eating.....");
        }
    }
}
