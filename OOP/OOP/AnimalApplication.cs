using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class AnimalApplication
    {
        public void Main(String[] args)
        {
            Human anil = new Human();
            anil.eat();

            Animal parrot = new Bird();
            parrot.eat();

            Animal khaire = new GermanShephard();
            khaire.eat();
            khaire.walk();

            Human rohit = new Human();
            rohit.enterRoom();
            anil.enterRoom();

            Console.WriteLine(rohit.count);

            Console.WriteLine(anil.count);
        }
    }
}
