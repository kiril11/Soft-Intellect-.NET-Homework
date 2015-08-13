using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    class SUV : Car
    {
        private bool road;
        public bool Road
        {
            get { return road; }
            set { road = value; }
        }
        public SUV(bool road, float price)
            : base(price)
        {
            this.road = road;
        }
        public void PrintSUV()
        {
            Console.WriteLine("SUV:The price is:{0} It is:{1}", price, road);
        }
    }
}
