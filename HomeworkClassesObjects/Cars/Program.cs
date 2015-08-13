using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[] road = new bool[10];
            float[] gas = new float[10];
            float[] price = new float[10];
            string[] model = new string[10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter model of the car and SUV,5 of each. Now it is number {0}",i+1);
                model[i] = Console.ReadLine();
            }
            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter gas consumption Now it is number {0}",i+1);
                gas[i] = float.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter the price Now it is number {0}",i+1);
                price[i] = float.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter if it is high road compatible Now it is number {0}", i + 1);
                road[i] = bool.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 5; i++)
            {
                SUV suv = new SUV(road[i], price[i]);
                Console.WriteLine();
                suv.PrintSUV();
            }
            Console.WriteLine();
            for (int i = 0; i < 5; i++)
            {
                Automobile car = new Automobile(gas[i], price[i]);
                Console.WriteLine();
                car.PrintCar();
            }
        }
    }
}

