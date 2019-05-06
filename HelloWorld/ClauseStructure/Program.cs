using System;

namespace ClauseStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 1;
            try
            {
                int c = b / a;
                Console.WriteLine("Hello World!");
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                Console.ReadLine();
            }
        }

        
    }
}
