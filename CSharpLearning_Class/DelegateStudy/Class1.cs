using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateStudy
{
    public delegate void Mydelegate(string s);

    class Class1
    {
        public Mydelegate myDelegate;
        public Class1() {
            myDelegate = new Mydelegate(SayHello);
        }

        public void SayHello(string name) {
            Console.WriteLine("hello,{0}", name);
        }

    }
}
