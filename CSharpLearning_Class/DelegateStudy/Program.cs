﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 class1 = new Class1();
            class1.myDelegate("dogy");
            Console.ReadLine();
        }
    }
}
