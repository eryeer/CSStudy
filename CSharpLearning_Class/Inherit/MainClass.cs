using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inherit
{
    class MainClass
    {

        static void Main(string[] args) {
            Cat cat = new Cat();
            Animal dog = new Dog();
            Console.WriteLine(cat.Color);
            cat.shout();
            cat.catchRat();
            Console.WriteLine("---------");
            Console.WriteLine(dog.Color);
            dog.shout();
            Console.ReadLine();

        }
    }
}
