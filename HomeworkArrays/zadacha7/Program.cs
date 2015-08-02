using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of the dimensions: ");
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.WriteLine("Enter a number");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("   " + matrix[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                for (int i = 0; i < matrix.GetLength(1); i++)
                {
                    Console.Write("   " + matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}

