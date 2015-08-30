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
            int[] arr = new int[5];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter a number");
                arr[i] = int.Parse(Console.ReadLine());
            }
            List<int> red = new List<int>(arr);

            var group = red.GroupBy(i => i);

            foreach (var item in group)
            {
                List<int> red2 = new List<int>();
                Console.WriteLine("The number {0} occurs {1} times", item.Key, item.Count());
                if(item.Count()%2!=0)
                {
                                    
                        red2.Add(red[item.Count()]);
                }
                    foreach (var gs in red2)
                    {
                        Console.WriteLine(gs);
                    }

                }
            }
        }

    }
}