using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your number");
            int x = int.Parse(Console.ReadLine());
            for (int i = 1 ; i <=x; i++)
            {
                if(i%3!=0 && i%7!=0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
