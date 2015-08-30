using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace zadacha7
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader("read.txt"))
            {
                using (StreamWriter writer = new StreamWriter("write.txt"))
                {
                    using (StreamWriter writer2 = new StreamWriter("write2.txt"))
                    {
                        int lineNumber = 0;
                        string line = reader.ReadLine();
                        while (line != null)
                        {
                            Console.WriteLine("Line {0}: {1}", lineNumber + 1, line);
                            line = reader.ReadLine();
                            lineNumber++;
                            if (lineNumber % 2 == 1)
                            {
                                writer.WriteLine(line);
                            }
                            else
                            {
                                writer2.WriteLine(line);
                            }
                        }
                    }
                }
            }
        }
    }
}
