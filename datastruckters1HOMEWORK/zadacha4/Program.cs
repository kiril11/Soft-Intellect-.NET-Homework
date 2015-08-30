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
            Console.WriteLine("Enter the amouth of numbers you wish to work with: ");
            int y = int.Parse(Console.ReadLine());
            int[] arr = new int[y];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter your number ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            List<int> red = new List<int>(arr);

            var group = red.GroupBy(i => i);

            foreach (var item in group)
            {               
                Console.WriteLine("The number {0} occurs {1} times", item.Key, item.Count());
                if(y/2<item.Count())
                {
                    Console.WriteLine("The majorant is {0} ", item.Key); 
                }
                else
                {
                    Console.WriteLine("There is no majorant"); 
                }
            }        
        }
    }
}
