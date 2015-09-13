using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreadHomework
{
    class Thread
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int sleep;
        public int Sleep
        {
            get { return sleep; }
            set { sleep = value; }
        }

        public Thread(string name, Random rand)
        {
            this.name = name;
            this.sleep = rand.Next(1000, 10000);
        }

        public void PrintInfo()
        {
            Console.WriteLine("Thread start");
            Console.WriteLine("My name is  {0}!", name);
            Thread.Sleep(sleep);
            Console.WriteLine("Thread {0} stopped", name);
        }
    }
}
