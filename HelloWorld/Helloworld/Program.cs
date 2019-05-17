using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            MyInteger a = new MyInteger(1);
            MyInteger b = new MyInteger(2);
            Console.WriteLine((a + b).Num);
            Console.ReadLine();
           
        }

        static int test(int a, out int b) {
            b = 3 - a;
            return a + b;
        }

        static Dog getDog() {

            return new Dog();
        }

        static T testT<T>(T arg) {
            T temp = default(T);
            if (temp == null)
            {
                Console.WriteLine("this is null");
            }
            else
            {
                Console.WriteLine(temp);
            }
            return arg;
        }
    }

    class Dog {
        public void shout() {
            Console.WriteLine("shout");
        }
    }

    class MyInteger {
        public int Num { set; get; }
        public MyInteger(int num) {
            Num = num;
      
        }

        public static MyInteger operator + (MyInteger a, MyInteger b) {
            return new MyInteger(a.Num * b.Num + b.Num * a.Num);
        }
    }
}
