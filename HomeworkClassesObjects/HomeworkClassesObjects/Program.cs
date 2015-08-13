using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkClassesObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] age = new int[10];
            string[] name = new string[10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter name of your cat. Cat number {0}",i+1);
                name[i] = Console.ReadLine();
            }
            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter age of your cat. Cat number {0}", i + 1);
                age[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {
                Cat cat = new Cat(name[i], age[i]);
                cat.Say();
            }
        }
    }
}
