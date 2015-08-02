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
            Console.WriteLine("Enter your name");
            string x = Console.ReadLine();
            correctName(x);
        }

        private static void correctName(string x)
        {
            foreach (char c in x)
            {
                if (!Char.IsLetter(c))
                    Console.WriteLine("Wrong input");
                else
                {
                    Console.WriteLine("Greetings <{0}>!", x); break;

                }
            }
        }
    }
}
