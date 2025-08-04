using System;
using System.Globalization;

namespace _02_SUM
{
    /*
        Read in three decimal numbers, and calculate the sum. 
        Output the sum as an integer.

        Problems with . as the decimal separator? Add this line 
        of code in your Main-method before you start reading input 
        from the console:
        System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

        input:
        23
        78
        10.6

        output:
        111

        input:
        13.6
        -10
        7

        output:
        10
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1 = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            double num2 = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            double num3 = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            int sum = (int)(num1 + num2 + num3);

            Console.WriteLine(sum);
        }
    }
}
