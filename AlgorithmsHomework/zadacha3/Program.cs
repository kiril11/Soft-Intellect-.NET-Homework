using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your sentence");
            string sent = Console.ReadLine();
            string[] words = sent.Split(' ');
            Array.Sort(words);
            foreach (var item in words)
            {
                Console.Write(item+' ');
            }
        }
    }
}
