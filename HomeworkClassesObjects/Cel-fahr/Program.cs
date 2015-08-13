using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cel_fahr
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Enter celsius to convert");
           double  f = Converter.CelsiusToFahrenheit(Console.ReadLine());
             Console.WriteLine("Temperature in Fahrenheit: {0:F2}", f);
        }
    }
}
