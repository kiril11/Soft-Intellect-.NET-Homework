using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first number");
            int first = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your second number");
            int second = int.Parse(Console.ReadLine());
            MaxNumber(first, second);
            Console.WriteLine("Enter your third number");
            int third = int.Parse(Console.ReadLine());
        }

        private static void MaxNumber(int x, int y)
        {
            int larger;
            if(x>y)
            {
                larger = x;
            }
            else
            {
                larger = y;
            }
            Console.WriteLine();
            Console.WriteLine(larger);
        }
    }
}
