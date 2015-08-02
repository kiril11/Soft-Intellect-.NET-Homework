using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of the array");
            int size = int.Parse(Console.ReadLine());

            int[] arr = new int[size];
            Console.WriteLine();

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter a number");
                int y = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("Enter the number you want to find");
            int z = int.Parse(Console.ReadLine());


            for (int i = 1; i <= arr.Length - 1; i++)
            {
                if (arr[i] == z)
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }
    }
}

