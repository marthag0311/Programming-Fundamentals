using System;
using System.Globalization;

namespace _02_Radius
{
    /*
        Read in the area of a circle, and calculate the 
        radius using this formula  r = √(A / π). Round 
        the radius to 2 digits. (tip: use Math-library)

        input:
        10

        output:
        1.78

        input:
        12.566

        output:
        2.00
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            double area = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            double radius = Math.Sqrt(area / Math.PI);

            Console.WriteLine($"{radius:0.00}");
            //Console.WriteLine($"{radius:f2}");
        }
    }
}
