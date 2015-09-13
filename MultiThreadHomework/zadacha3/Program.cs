using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace zadacha3
{
    class Program
    {
        private static Thread first, second;

        static void Main(string[] args)
        {

            first = new Thread(new ThreadStart(Task));
            second = new Thread(new ThreadStart(Task2));

            first.Start();
            second.Start();
        }

        private static void Task()
        {
            for (int i = 0; i <= 50000; i++)
            {
                Console.WriteLine(i);

                if (i == 25000)
                {
                    first.Suspend();
                }
            }
        }
    

        private static void Task2()
        {
            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine("Running...");
                Thread.Sleep(500);
            } first.Resume();
        }
    }
}



