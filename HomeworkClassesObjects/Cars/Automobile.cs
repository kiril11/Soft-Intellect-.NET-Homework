using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    class Automobile : Car
    {
        private float gasConsumption;
        public float GasConsumption
        {
            get { return gasConsumption; }
            set { gasConsumption = value; }
        }
        public Automobile(float gasConsumption, float price)
            : base(price)
        {
            this.gasConsumption = gasConsumption;
        }
        public void PrintCar()
        {
            Console.WriteLine("Automobile:The gas consumption is:{0} The price is:{1}", gasConsumption, price);
        }
    }
}


