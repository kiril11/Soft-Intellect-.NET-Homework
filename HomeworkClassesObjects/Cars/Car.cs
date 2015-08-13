using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    class Car
    {
        public float price;
        public float Price
        {
            get { return price; }
            set { price = value; }
        }
        public Car(float price)
        {
            this.price = price;
        }
    }
}

