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
            Console.WriteLine("Enter your points");
            int points = int.Parse(Console.ReadLine());
            Console.WriteLine("Your points are:{0}",points);
            if(points>=3 && points<=5)
            {
                Console.WriteLine("Your new pointsa are");
                Console.WriteLine(points + 5);
            }
            else if(points>=4 && points<=6)
            {
                Console.WriteLine("Your new pointsa are");

                Console.WriteLine(points*12);
            }
            else if(points>=7 && points<=9)
            {
                Console.WriteLine("Your new pointsa are");
                Console.WriteLine((points*50)/3);
            }
        }
    }
}
