using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace zadacha2
{
    class Program
    {
       
            public static void ThreadsInfo(object name)
        {
            Random seconds = new Random();

            Console.WriteLine("Thread started");
            Console.WriteLine("Thread {0}", Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(seconds.Next(1000, 10000));
            Console.WriteLine("Thread {0} done", Thread.CurrentThread.ManagedThreadId);
        }

        static void Main()
        {
            Console.WriteLine("Press [Enter] to exit!");
            Console.WriteLine("Program is using  " + Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine();

            for (int i = 1; i <= 5; i++)
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(ThreadsInfo));
            } Console.ReadLine();
        }
    }
}
