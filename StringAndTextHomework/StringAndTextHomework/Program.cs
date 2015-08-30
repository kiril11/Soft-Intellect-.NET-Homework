using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAndTextHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word");
            string word = Console.ReadLine();
            Console.WriteLine();
            string word2 = new string(word.ToCharArray().Reverse().ToArray());
            Console.WriteLine(word2);
        }
    }
}
