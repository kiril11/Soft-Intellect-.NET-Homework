using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha2
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Enter the size of the array");
            int s = int.Parse(Console.ReadLine());
            s--;
            int[] arr = new int[s + 1];

            arr[0] = 0;
            arr[1] = 1;

            for (int i = 2; i <= s; i++)
            {
                arr[i] = arr[i - 2] + arr[i - 1];
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine();
            Console.WriteLine(arr[s]);

        }
    }
}
