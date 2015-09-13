using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ExceptionHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name of file");
            string file = Console.ReadLine();
            ReadFile(file);

            Console.WriteLine("Enter name of file");
            string file2 = Console.ReadLine();
            Console.WriteLine("Enter your text");
            string text = Console.ReadLine();
            WriteFile(file2,text);

        }
        static void ReadFile(string file)
        {
            try
            {
                StreamReader reader = new StreamReader(file);
                string line = reader.ReadLine();
                Console.WriteLine(line);
                reader.Close();
            }
            catch (FileNotFoundException )
            {
                Console.WriteLine("The file '{0}' was not found.", file);
                
            }
            catch (IOException ioe)
            {
                Console.WriteLine(ioe.StackTrace);
            }
            finally
            {
                Console.WriteLine();
                Console.WriteLine("Exception handling passed!");
            }
        }
        static void WriteFile(string file2,string text)
        {
            try
            {
                 using (StreamWriter writer = new StreamWriter(file2))
                 {
                     writer.WriteLine(text);
                 }
            }            
            catch (IOException ioe)
            {
                Console.WriteLine(ioe.StackTrace);
            }
            finally
            {
                Console.WriteLine();
                Console.WriteLine("Exception handling passed!");
            }
        }
    }
}