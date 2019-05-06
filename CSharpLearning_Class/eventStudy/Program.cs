using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eventStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.OnOilFull += new EventHandler(Car_OnOilFull);
            for (int i = 0; i < 20; i++) {
                car.JiaYou();
            }
            Console.ReadLine();
        }

        private static void Car_OnOilFull(object sender, EventArgs e)
        {
            Console.WriteLine("油满了。。。");
        }
    }
}
