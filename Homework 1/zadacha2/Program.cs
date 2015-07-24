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
            Console.WriteLine("Въведете число:" );
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Въведете число:");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Сумата на двете числа е: " );
            Console.WriteLine(x+y);
            Console.WriteLine();
        }
    }
}
