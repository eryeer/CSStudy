using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // WriteTest(f);
            // ReadTest(f);

            // BiWrite();
            FileInfo f = new FileInfo(@"D:\bb.txt");
            using (BinaryReader br = new BinaryReader(f.OpenRead()))
            {
                Console.WriteLine(br.ReadDouble());
                Console.WriteLine(br.ReadInt32());
                Console.WriteLine(br.ReadString());
            }
            Console.ReadLine();
        }

        private static void BiWrite()
        {
            FileInfo f = new FileInfo(@"D:\bb.txt");
            using (BinaryWriter bw = new BinaryWriter(f.OpenWrite()))
            {
                Console.WriteLine(bw.BaseStream);
                double a = 1234.67;
                int i = 3452;
                string str = "Hello";
                bw.Write(a);
                bw.Write(i);
                bw.Write(str);
            }
            Console.WriteLine("DONE!");
        }

        private static void ReadTest()
        {
            FileInfo f = new FileInfo(@"D:\aa.txt");
            using (StreamReader sr = f.OpenText())
            {
                string input = null;
                while ((input = sr.ReadLine()) != null)
                {
                    Console.WriteLine(input);
                }
            }

            Console.ReadLine();
        }

        private static void WriteTest()
        {
            FileInfo f = new FileInfo(@"D:\aa.txt");
            using (StreamWriter sw = f.CreateText())
            {
                sw.WriteLine("鱼是做给大家伙儿吃的，乔初熏发觉这些人都挺爱吃甜口吃食，便打算做个糖醋鲤");
                sw.WriteLine("鱼是做给大家伙儿吃的，乔初熏发觉这些人都挺爱吃甜口吃食，便打算做个糖醋鲤");
                sw.WriteLine("鱼是做给大家伙儿吃的，乔初熏发觉这些人都挺爱吃甜口吃食，便打算做个糖醋鲤");

                for (int i = 0; i < 10; i++)
                {
                    sw.Write(i + " ");
                }
            }
            Console.WriteLine("created file");
        }
    }
}
