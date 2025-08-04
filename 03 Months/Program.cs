using System;

namespace _03_Months
{
    /*
        Read in a number and prints its corresponding month name as a string. If the number is not between 1 and 12, print 'crazy input'

        input:
        6

        output:
        June

        input:
        -1

        output:
        crazy input
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            string answer = Console.ReadLine();

            if (Int32.TryParse(answer, out int number))
            {
                if (number >= 1 && number <= 12)
                {
                    if (number == 1)
                    {
                        Console.WriteLine("January");
                    }
                    else if (number == 2)
                    {
                        Console.WriteLine("February");
                    }
                    else if (number == 3)
                    {
                        Console.WriteLine("March");
                    }
                    else if (number == 4)
                    {
                        Console.WriteLine("April");
                    }
                    else if (number == 5)
                    {
                        Console.WriteLine("May");
                    }
                    else if (number == 6)
                    {
                        Console.WriteLine("June");
                    }
                    else if (number == 7)
                    {
                        Console.WriteLine("July");
                    }
                    else if (number == 8)
                    {
                        Console.WriteLine("August");
                    }
                    else if (number == 9)
                    {
                        Console.WriteLine("September");
                    }
                    else if (number == 10)
                    {
                        Console.WriteLine("October");
                    }
                    else if (number == 11)
                    {
                        Console.WriteLine("November");
                    }
                    else
                    {
                        Console.WriteLine("December");
                    }
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
