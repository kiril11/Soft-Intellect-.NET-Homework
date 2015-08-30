using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your text");
            string text = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Enter a word");
            string word = Console.ReadLine();
            Console.WriteLine();
            string[] sentence = text.Split(new[] { '.', '?', '!', ';' });
            foreach (var item in sentence)
            {
                if (item.Contains(word))
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}