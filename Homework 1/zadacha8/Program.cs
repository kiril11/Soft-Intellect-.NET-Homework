using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете string");
            string x = Console.ReadLine();
            Console.WriteLine("Въведете string");
            string y = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine(x.Contains(y));
        }
    }
}
