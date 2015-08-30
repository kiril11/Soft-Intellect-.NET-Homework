using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datastruckters1HOMEWORK
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            Console.WriteLine("Enter the amouth of numbers you want to input");
            int x = int.Parse(Console.ReadLine());
            List<int> numbers = new List<int>();

            for (int i = 0; i < x; i++)
            {
                Console.Write("You will enter your {0} number: ", i + 1);
                int y = int.Parse(Console.ReadLine());
                numbers.Add(y);
            }
            foreach (var item in numbers)
            {
                count++;
            }
            int sum = numbers.OrderByDescending(y => y).Take(count).Sum();
            int average = sum/count;
            Console.WriteLine();
            Console.WriteLine("The sum is {0} and the average is {1} ", sum, average);
        }
    }
}
