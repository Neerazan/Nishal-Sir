using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Human: Animal, Danceable, Singable
    {
        public int count;
        public override void walk()
        {
            Console.WriteLine("Walking with 2 legs");
        }

        void Danceable.dance()
        {
            Console.WriteLine("Dancing in dohori");
        }

        void Singable.sing()
        {
            Console.WriteLine("Singing dohori song");
        }

        public void enterRoom()
        {
            this.count++;
        }
    }
}
