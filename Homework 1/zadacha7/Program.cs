using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете реално число" );
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Въведете цяло число");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine(x/y);
        }
    }
}
