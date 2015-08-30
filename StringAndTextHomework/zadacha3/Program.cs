using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace zadacha3
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

            int count = new Regex(word, RegexOptions.Compiled | RegexOptions.IgnoreCase).Matches(text).Count;

            Console.WriteLine("The word '{0}' occures {1} times in the sentence", word, count);
        }
    }
}
