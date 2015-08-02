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
            int[] arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter a number {0}", i + 1);
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] *= 10;
                Console.Write(" " + arr[i] + " ");
            }
        }
    }
}

