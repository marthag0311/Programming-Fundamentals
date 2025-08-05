using System;

namespace _04_Harmonic_Series
{
    /*
        Read in a nonnegative integer n and print out 
        the n terms of the harmonic series and their sum 
        (round to four digits).
        
        The harmonic series is a series starting at 1 
        and going to infinity of 1/n: 1 + 1/2 + 1/3 ...

        input:
        5
        output:
        1 + 1/2 + 1/3 + 1/4 + 1/5
        sum = 2.2833

        input:
        2
        output:
        1 + 1/2
        sum = 1.5000
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            string answer = Console.ReadLine();

            if (Int32.TryParse(answer, out int number))
            {
                double sum = 1;

                if (number <= 0)
                {
                    Console.WriteLine("crazy input");
                }
                else
                {
                    Console.Write(1);
                    for (int i = 2; i <= number; i++)
                    {
                        Console.Write(" + ");

                        double series = (double) 1 / i;

                        sum += series;

                        Console.Write($"1/{i}");
                    }
                    Console.WriteLine();
                    Console.WriteLine($"sum = {sum:f4}");
                }
            }
            else
            {
                Console.WriteLine("crazy input");
            }
        }
    }
}
