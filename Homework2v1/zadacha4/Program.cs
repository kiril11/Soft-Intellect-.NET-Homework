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
            Console.WriteLine("Enter your first number");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your second number");
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = 0;
            int nod = 1;
            if (secondNumber == 0 || firstNumber == 0)
            {
                Console.WriteLine("Wrong logic");
            }
            else
            {
                if (firstNumber == secondNumber)
                {
                    thirdNumber = firstNumber;
                }
                else if (firstNumber < secondNumber)
                {
                    thirdNumber = firstNumber;
                }
                else if (firstNumber > secondNumber)
                {
                    thirdNumber = secondNumber;
                }
                for (int i = 1; i <= thirdNumber; i++)
                {
                    if (firstNumber % i == 0 && secondNumber % i == 0)
                    {
                        nod = i;

                    }
                }
            }
            Console.WriteLine(nod);
        }
    }
}
