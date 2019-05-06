using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inherit
{
    public abstract class Animal
    {
        private String color;

        public string Color { get => color; set => color = value; }

        abstract public void shout();
    }
    public class Dog : Animal
    {
        public Dog() {
            this.Color = "brown";
        }
        public override void shout()
        {
            Console.WriteLine("wangwang");
        }
    }
    public class Cat : Animal,CatInter
    {
        public Cat()
        {
            this.Color = "yellow";
        }

        public void catchRat()
        {
            Console.WriteLine("catchRat");

        }

        public override void shout()
        {
            Console.WriteLine("miaomiao");
        }
    }

    public interface CatInter {
        void catchRat();
    }

}
