using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Right_triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter sides of the triangle");

            Console.WriteLine("Enter first side");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second side");
            int z = int.Parse(Console.ReadLine());

            triangle x = new triangle(y, z);
            x.PrintHyp();
            x.PrintAngles();
        }
    }
}
