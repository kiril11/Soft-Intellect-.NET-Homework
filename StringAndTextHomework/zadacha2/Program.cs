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
            Console.WriteLine();
            Console.WriteLine("Enter a word");
            string word = Console.ReadLine();
            Console.WriteLine();
            if (text.Contains(word))
            {
                string s = word.ToUpper();
                text = text.Replace(word, s);
                Console.WriteLine(text);
            }
        }
    }
}
