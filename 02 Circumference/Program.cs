using System;
using System.Globalization;

namespace _02_Circumference
{
    /*
        Read in length and width of a rectangle and calculate its circumference by the formula 2*(l + w).

        input:
        10
        4

        output:
        28

        input:
        10
        5

        output:
        30
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            double length = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            double width = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circum = 2 * (length + width);

            Console.WriteLine(circum);
        }
    }
}
