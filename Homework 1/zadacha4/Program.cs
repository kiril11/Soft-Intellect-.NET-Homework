using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете страната а: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Въведете страната б: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Лицето на правоъгълникае: ");
            Console.WriteLine(a*b);
        }
    }
}
