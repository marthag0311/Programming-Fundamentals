using System;
using System.Globalization;

namespace _02_Decimal_Part
{
    /*
        Read in a number and print out the decimal part of 
        the number (round to 6 digits).

        Problems with . as the decimal separator? Add this 
        line of code in your Main-method before you start 
        reading input from the console:
        System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

        input:
        10.78001

        output:
        Decimal part = 0.780010

        input:
        12.566

        output:
        Decimal part = 0.566000
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            double number = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            double decpart = number - (int)(number);

            //Console.WriteLine($"Decimal part = {decpart:0.000000}");
            //String.Format("{0:0.00}", 123.4567);      // "123.46"

            Console.WriteLine($"Decimal part = {decpart:f6}");
            //Console.WriteLine("{0:f2}", 111.2); //111.20

        }
    }
}
