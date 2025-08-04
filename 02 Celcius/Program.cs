using System;
using System.Globalization;

namespace _02_Celcius
{
    /*
        Read in a number as degrees Celsius and convert 
        it to degrees Kelvin and degrees Fahrenheit with 
        these formulas: 
        Kelvin = C + 273 and Fahrenheit = C x 18 / 10 + 32. 
        Round degrees to 3 digits.

        input:
        -17.8

        output:
        255.200°K
        -0.040°F

        input:
        50

        output:
        323.000°K
        122.000°F
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            double celsius = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            double kelvin = celsius + 273;

            double fahrenheit = celsius * 18 / 10 + 32;

            Console.WriteLine($"{kelvin:f3}°K");
            Console.WriteLine($"{fahrenheit:f3}°F");
        }
    }
}
