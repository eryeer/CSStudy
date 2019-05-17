using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace SetGetTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //Man man = new Man();
            //man.Age = 10;
            //Console.WriteLine(man.Age);
            //Console.ReadLine();
            string str = "1";
            B b = new B();
            //b.Hello();

            //string a = "hhh";
            //string ajson = a.ToJson();
            //Console.WriteLine(ajson);
            Type t = typeof(B);
            Console.WriteLine("Methods:");
            MethodInfo[] methodInfo = t.GetMethods();
            foreach (MethodInfo mInfo in methodInfo)
                Console.WriteLine(mInfo.ToString());
            Console.WriteLine("Members:");
            MemberInfo[] memberInfo = t.GetMembers();
            foreach (MemberInfo mInfo in memberInfo)
                Console.WriteLine(mInfo.ToString());

            Console.WriteLine(t.GetType());
            Console.WriteLine(t.ToString());
            Console.WriteLine(typeof(string).ToString());
            Console.ReadLine();

        }
    }

    class Man {

        public int Age { set; get; }
    }

    public class A {
        public virtual void Hello() {
            Console.WriteLine("hello");
        }
    }

    public class B : A {
        public override void Hello()
        {
            base.Hello();
             Console.WriteLine("world");
        }
    }

    public static class Extends {
        public static string ToJson(this string Json)
        {
            return Json == null ? null : "{" + Json + "}";
        }
    }
}
