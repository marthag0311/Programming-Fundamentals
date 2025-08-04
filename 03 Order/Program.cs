using System;
using System.Globalization;

namespace _03_Order
{
    /*
        Read in three numbers and print them out in descending order

        input:
        23
        78
        10.6

        output:
        78 23 10.6 

        input:
        13.6
        -10
        7

        output:
        13.6 7 -10 
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            double number1 = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            double number2 = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            double number3 = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (number1 >= number2 && number1 >= number3)
            {
                if (number2 >= number3)
                {
                    Console.WriteLine($"{number1} {number2} {number3}");
                }
                else
                {
                    Console.WriteLine($"{number1} {number3} {number2}");
                }
            }
            else if (number2 >= number1 && number2 >= number3)
            {
                if (number1 >= number3)
                {
                    Console.WriteLine($"{number2} {number1} {number3}");
                }
                else
                {
                    Console.WriteLine($"{number2} {number3} {number1}");
                }
            }
            else if (number3 >= number1 && number1 >= number2)
            {
                if (number1 >= number2)
                {
                    Console.WriteLine($"{number3} {number1} {number2}");
                }
                else
                {
                    Console.WriteLine($"{number3} {number2} {number1}");
                }
            }
        }
    }
}
