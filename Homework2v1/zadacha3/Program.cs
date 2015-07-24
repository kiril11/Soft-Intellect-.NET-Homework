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
            Console.WriteLine("Enter your card");
            string x = Console.ReadLine();
            switch(x)
            {
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                case "10":
                    {
                        Console.WriteLine("Valid card"); break;
                    }
                case "J":
                case "K":
                case "Q":
                case "A":
                    {
                        Console.WriteLine("Valid card"); break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid card"); break;
                    }


            }
        }
    }
}
