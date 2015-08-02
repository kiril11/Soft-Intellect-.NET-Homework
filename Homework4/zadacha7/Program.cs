using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha7  // Copied, trying to understand it
{
    class Program
    {
        static readonly int n = int.Parse(Console.ReadLine());


        static int[] a = new int[50];
        static void Print()
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + 1 + " ");

            }
            Console.WriteLine();
        }
        static void permute(int k)
        {
            int i, dif;
            if (k == 0)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(a[j] + 1 + " ");

                }
                Console.WriteLine();
            }
            else
            {

                for (i = 0; i < k; i++)
                {
                    dif = a[i];
                    a[i] = a[k - 1];
                    a[k - 1] = dif;
                    permute(k - 1);

                    dif = a[i];
                    a[i] = a[k - 1];
                    a[k - 1] = dif;

                }
            }
        }
        static void Main()
        {
            Console.WriteLine("Enter a number N");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {

                a[i] = i;

            }
            Console.WriteLine();
            permute(n);
        }
    }
}

