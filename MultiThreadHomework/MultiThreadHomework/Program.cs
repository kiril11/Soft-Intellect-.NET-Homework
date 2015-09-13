using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace MultiThreadHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            Thread first = new Thread(new Thread("ONE", rand).PrintInfo);
            Thread second = new Thread(new Thread("TWO", rand).PrintInfo);
            Thread third = new Thread(new Thread("THREE", rand).PrintInfo);
            Thread fourth = new Thread(new Thread("FOUR", rand).PrintInfo);
            Thread fifth = new Thread(new Thread("FIVE", rand).PrintInfo);

            first.Start();
            second.Start();
            third.Start();
            fourth.Start();
            fifth.Start();
        }
    }
}
