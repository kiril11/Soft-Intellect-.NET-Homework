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
            Console.WriteLine("Enter a number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a number");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a number");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine(a * b * c);
            Console.WriteLine();
            for (int i = 0; i <= 10; i++)
            {
                randomMultiplier(a, b, c);

            }
        }

        private static void randomMultiplier(int a, int b, int c)
        {
            Random rand = new Random();
            List<int> list = new List<int>();

            for (int i = 0; i < 3; i++)
            {
                int current = rand.Next(1, 15);
                if (list.Contains(current))
                {
                    i--;
                }
                else
                {
                    list.Add(current);
                }
                foreach (var item in list)
                {
                    Console.WriteLine();
                    int z = item;
                    Console.WriteLine(item);
                    Console.WriteLine(z * z * z);
                }
            }
        }
    }
}
