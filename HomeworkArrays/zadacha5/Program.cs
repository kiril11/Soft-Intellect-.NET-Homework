using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size for your first array");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine();
            Console.WriteLine("Enter size for your second array");
            int m = int.Parse(Console.ReadLine());
            int[] arr2 = new int[m];
            if (n != m)
            {
                Console.WriteLine("They are different");
            }
            else
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine("Enter numbers for the first array {0}", i + 1);
                    arr[i] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine();
                    Console.WriteLine("Enter numbers for the second array {0}", i + 1);
                    arr2[i] = int.Parse(Console.ReadLine());
                }
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = 0; j < arr2.Length; j++)
                    {
                        if (arr[i] == arr2[j])
                        {
                             Console.WriteLine("Yes"); break;
                        }
                        else
                        {
                            Console.WriteLine("No"); break;
                        }                        
                    }
                    break;
                }
            }
        }
    }
}
