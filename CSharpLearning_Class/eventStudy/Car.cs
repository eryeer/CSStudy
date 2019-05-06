using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eventStudy
{
    class Car
    {
        public event System.EventHandler OnOilFull;
        private int youliang = 0;
        private int max_youliang = 100;
        public Car() { }
        public void JiaYou() {
            if (youliang < max_youliang)
            {
                youliang += 10;
                Console.WriteLine("加油中");
            }
            else {
                if (OnOilFull != null) {
                    OnOilFull(this, EventArgs.Empty);
                }
            }
        }

    }
}
