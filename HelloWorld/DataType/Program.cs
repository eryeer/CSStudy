using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataType
{
    class Program
    {
        static void Main(string[] args)
        { 
            int a = 3;
            Console.WriteLine("{0}",a.ToString());
           

            string hello = "hello";

            string c = Console.ReadLine();
            Console.WriteLine("{0} world is {1}", hello, int.Parse(c) + a);
            Console.ReadLine();

        }
    }
}
