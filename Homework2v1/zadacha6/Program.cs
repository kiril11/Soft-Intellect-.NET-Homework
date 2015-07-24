using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha6 
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter 5 numbers:");

            int x = 0;
            int y = 0;
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Number {0}: ", i);
                int number = int.Parse(Console.ReadLine());
                if (i == 1)
                {
                    x = number;
                    y = number;
                }
                else
                {
                    if (number > x)
                    {
                        x = number;
                    }
                    else if (number < y)
                    {
                        y = number;
                    }
                }
            }

            Console.WriteLine("Biggest: {0}\nSmallest: {1}", x, y);
        }
    }
}
