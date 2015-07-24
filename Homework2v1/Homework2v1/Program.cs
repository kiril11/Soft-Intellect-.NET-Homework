using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2v1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter type of variable I for int, S for string and D for double");
            char str = char.Parse(Console.ReadLine());
            if ((str == 'I') || (str == 'D'))
            {
                Console.WriteLine("Enter your number");
                double x = double.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Your new number is:");
                Console.WriteLine(x + 1);
            }
            else if (str == 'S')
            {
                Console.WriteLine("Enter your string");
                string y = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Your new string is");
                Console.WriteLine(y+'*');
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Wrong choice");
            }

        }
    }
}
