using System;
using System.Globalization;

namespace _02_Average
{
    /*
        Read in four numbers and calculate the average. 
        Print average as an integer.

        input:
        23
        78
        10
        10.6

        output:
        30

        input:
        13.6
        8
        -10
        7

        output:
        4
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1 = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            double num2 = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            double num3 = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            double num4 = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            int avg = (int)((num1 + num2 + num3 + num4) / 4);
            Console.WriteLine(avg);
        }
    }
}
