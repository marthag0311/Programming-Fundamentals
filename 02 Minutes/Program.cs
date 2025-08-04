using System;
using System.Globalization;

namespace _02_Minutes
{
    /*
        Read in minutes and convert it to seconds and hours.

        input:
        23

        output:
        1380 seconds
        0 hour(s)

        input:
        67

        output:
        4020 seconds
        1 hour(s)
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            double minutes = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            double seconds = minutes * 60;
            double hours = minutes / 60;

            Console.WriteLine($"{seconds} seconds");
            Console.WriteLine($"{Math.Round(hours, 0)} hour(s)");
        }
    }
}
