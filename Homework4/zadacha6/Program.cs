using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace zadacha6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int n = int.Parse(Console.ReadLine());
            int r = Factorial(n);
            Console.WriteLine(r);
        }
        static int Factorial(int n)
        {
            if (n <= 1)
                return 1;
            int result = 1;
            for (int i = 2; i <= n; i++)
            {
                result = result * i;
            }
            return result;
        }
    }
}

