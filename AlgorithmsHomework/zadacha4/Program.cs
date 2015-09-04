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
            List<int> list = new List<int>();
            List<int> list2 = new List<int>();
            Console.WriteLine("Enter the amounth of numbers you wish to enter");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("The number you are entering is {0} in line", i + 1);
                arr[i] = int.Parse(Console.ReadLine());
            }
             int start = Environment.TickCount;
            Array.Sort(arr);
            Console.WriteLine("Whole array sort time in miliseconds: " + (Environment.TickCount - start));

            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }
            foreach (int j in arr)
            {
                if (j % 2 == 0)
                {
                    
                    list.Add(j);
                }
                else
                {
                    list2.Add(j);
                    
                }
            }
            int start2 = Environment.TickCount;
            list.Sort();
            Console.WriteLine("Even list sort time in miliseconds: " + (Environment.TickCount - start2));

            foreach (int x in list)
            {
                Console.WriteLine(x);
            }
            int start3 = Environment.TickCount;
            list2.Sort();
            Console.WriteLine("Even list sort time in miliseconds: " + (Environment.TickCount - start3));
            list2.Reverse();

            foreach (int y in list2)
            {
                Console.WriteLine(y);
            }
        }
    }
}