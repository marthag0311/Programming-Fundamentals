using System;
using System.Globalization;

namespace _03_Largest
{
    /*
        Read in three numbers and print the largest one

        input:
        23
        78
        10.6

        output:
        78

        input:
        13.6
        -10
        7

        output:
        13.6
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            double number1 = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            double number2 = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            double number3 = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(Math.Max(number3, Math.Max(number2, number1)));
        }
    }
}
