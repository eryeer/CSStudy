using System;

namespace passParam

{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            plus(ref a);
            Console.WriteLine("main "+a);
            Console.ReadLine();
        }

        static void plus(ref int m) {
            m += 2;
            Console.WriteLine(m);
        }
    }
}
