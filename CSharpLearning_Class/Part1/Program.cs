using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 class1 = new Class1();
            // class1.method1();
            class1.Aaa = "res";
            Console.WriteLine("the aaa is :" + class1.Aaa);
            Console.ReadLine();

        }
    }

    abstract class Class2 { }
    sealed class Car { } //密封类，不能被继承
}
