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
                Console.WriteLine("Enter a number");
                arr[i] = int.Parse(Console.ReadLine());
            }


             List<int> red = new List<int> (arr);
            var group = red.GroupBy(i => i);

            foreach (var item in group)
            {
                Console.WriteLine("The number {0} occurs {1} times", item.Key, item.Count());
            }
        }
    }
}
