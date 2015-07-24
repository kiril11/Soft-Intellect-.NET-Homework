using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha7v1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter values in the order 1<K<N");
            Console.WriteLine("Enter value for N");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value for K");
            int k = int.Parse(Console.ReadLine());
            if (k > n || 1 > n || k < 1)
            {
                Console.WriteLine("Wrong values");
            }
            long factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            long factorial2 = 1;
            for (int i = 1; i <= k; i++)
            {
                factorial2 *= i;
            }
            Console.WriteLine(factorial / factorial2);
        }
    }
}
