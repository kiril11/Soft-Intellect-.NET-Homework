using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cel_fahr
{
    public static class Converter
    {
        public static double CelsiusToFahrenheit(string cel)
        {
            double celsius = Double.Parse(cel);

            double fahrenheit = (celsius * 9 / 5) + 32;

            return fahrenheit;
        }
    }
}
