using System;
using System.Globalization;

namespace _03_Negative
{
    /*
        Read in a number and return the negative number when a number is already negative, nothing changes, when the number is 0, print 'error converting'.

        input:
        -66

        output:
        -66

        input:
        93

        output:
        -93
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            double number = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (number < 0)
            {
                Console.WriteLine(number);
            }
            else if (number > 0)
            {
                Console.WriteLine($"-{number}");
            }
            else
            {
                Console.WriteLine("error converting");
            } 
                
        }
    }
}
