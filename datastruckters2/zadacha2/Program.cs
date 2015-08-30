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
            Console.WriteLine("Enter your text");
            string text = Console.ReadLine();

            var split = text.Split(' ','!','.',',','?');
            var distinctWords = new List<string>(split.Distinct());
            foreach (var item in split.Distinct())
            {
                Console.WriteLine(item);
            }
        }
    }
}