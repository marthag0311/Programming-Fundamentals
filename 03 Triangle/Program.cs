using System;
using System.Globalization;

namespace _03_Triangle
{
    /*
        Read in three sides of a triangle and print out whether the triangle is equilateral (all equal sides), isosceles (equal legs, so only 2 equal sides) or scalene (no equal sides). Sides can only be positive... otherwise, it's just 'crazy input'

        input:
        20
        20
        40.5

        output:
        isosceles

        input:
        10
        -10
        10

        output:
        crazy input
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            double side1 = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            double side2 = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            double side3 = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (side1 > 0 && side2 > 0 && side3 > 0)
            {
                if (side1 == side2 && side1 == side3 && side2 == side3)
                {
                    Console.WriteLine("equilateral");
                }
                else if ((side1 == side2 && side1 != side3 && side2 != side3) ||
                         (side1 == side3 && side1 != side2 && side2 != side3) ||
                         (side2 == side3 && side1 != side2 && side1 != side3))
                {
                    Console.WriteLine("isosceles");
                }
                else if (side1 != side2 && side1 != side3 && side2 != side3)
                {
                    Console.WriteLine("scalene");
                } 
                else
                {
                    Console.WriteLine("crazy input");
                }
            }
            else
            {
                Console.WriteLine("crazy input");
            }
        }
    }
}
