using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете Hello World");
            string x = Console.ReadLine();
            string y = "Hello world";
            bool z =(x.Contains(y));
            Console.WriteLine(z);
        }
    }
}
