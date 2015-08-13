using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Right_triangle
{
    class triangle
    {
   
        private int katet1;
        private int katet2;
        public int Katet1
        {
            get { return katet1; }
            set { katet1 = value; }
        }
        public int Katet2
        {
            get { return katet2; }
            set { katet2 = value; }
        }
        public triangle(int katet1, int katet2)
        {
            this. katet1=katet1;
            this. katet2=katet2;
        }
        public void PrintHyp()
        {
            double hypotenuse = Math.Sqrt(Math.Pow(katet1 , 2) + Math.Pow(katet2, 2));
            Console.WriteLine("The  hypotenuse is: {0}", hypotenuse);
        }
     
       public void PrintAngles()
        {
            double hypotenuse = Math.Sqrt(Math.Pow(katet1 , 2) + Math.Pow(katet2, 2));
            Console.WriteLine("The angles are: {0}", Math.Sin(katet1 * 2.0 * Math.PI / 360.0) * hypotenuse);
            Console.WriteLine("The angles are: {0}", Math.Sin(katet2 * 2.0 * Math.PI / 360.0) * hypotenuse);
        }

    }
}

    
