
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (StreamReader text = new StreamReader("read.txt"))
                {
                    int lineNumber = 0;
                    bool symbol = false;
                    string line = text.ReadLine();

                    while (line != null)
                    {
                        lineNumber++;

                        if (line.LastIndexOf('.') == line.Length - 1)
                        {
                            symbol = true;
                            line = text.ReadLine();
                            continue;
                        }
                        else if (line.LastIndexOf('?') == line.Length - 1)
                        {
                            symbol = true;
                            line = text.ReadLine();
                            continue;
                        }
                        else if (line.LastIndexOf('!') == line.Length - 1)
                        {
                            symbol = true;
                            line = text.ReadLine();
                            continue;
                        }
                        else
                        {
                            symbol = false;
                            break;
                        }
                    }

                    if (symbol == true)
                    {
                        Console.WriteLine("Correct");
                    }
                    else
                    {
                        throw new sentence();
                    }
                }
            }
            catch (sentence)
            {
                Console.WriteLine("Wrong message");
            }
            finally
            {
                Console.WriteLine("Checked");
            }
        }
    }
}
