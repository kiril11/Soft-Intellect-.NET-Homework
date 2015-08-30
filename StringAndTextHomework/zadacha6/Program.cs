using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
namespace zadacha6
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader("../Test/test23.txt"))
            {
                string line = reader.ReadLine();
                int lineNumber = 0;
                while (line != null)
                {
                    lineNumber++;
                    String result = Regex.Replace(line, @"\p{P}", "");
                    Console.WriteLine("Line {0}: {1}", lineNumber, result);
                    result = reader.ReadLine();
                }
            }
        }
    }
}
