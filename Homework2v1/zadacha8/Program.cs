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
            Console.WriteLine("Enter values in the order 1<K<N");
            Console.WriteLine("Enter value for N");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value for K");
            int k = int.Parse(Console.ReadLine());
            if (k > n || 1 > n || k < 1)
            {
                Console.WriteLine("Wrong values");
            }
            long x = 0;
            long y = 0;
            long z = 0;                   
                long factorial = 1;
                for (int i = 1; i <= n; i++)
                {
                    x = (factorial *= i);
                }
                long factorial2 = 1;
                for (int i = 1; i <= k; i++)
                {
                    y = (factorial2 *= i);
                }
                //Console.WriteLine(x * y);
                Console.WriteLine();
                long factorial3 = (n - k);
                for (int i = 1; i <= factorial3; i++)
                {
                    z = (factorial3 *= i);
                    Console.WriteLine((x * y) / z);
                    break;
                }
            }
        }
    }

