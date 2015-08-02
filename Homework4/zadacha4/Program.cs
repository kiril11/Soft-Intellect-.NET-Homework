using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha4
{
    class Program
    {
        private static object number;
        static void Main(string[] args)
        {
            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine("Enter a number");
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine();
                evenOdd(number);
            }
            Console.WriteLine();
        }

        private static void evenOdd(int number)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine("Even");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Odd");
                Console.WriteLine();
            }
        }

    }
}
