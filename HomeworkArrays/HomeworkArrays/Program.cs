using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            Console.WriteLine("Enter size of your array");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter a number");
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    x = x + arr[i];
                }
            }
            Console.WriteLine();
            Console.WriteLine("The sum is " + x);

        }
    }
}

