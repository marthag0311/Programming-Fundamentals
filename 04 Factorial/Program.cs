using System;

namespace _04_Factorial
{
    /*
        Read in a nonnegative integer n (if not, print out 'crazy input') 
        and calculate its factorial n!. The factorial formula is given by 
        n! = 1 * 2 * 3 * ... *n

        Some examples:
        0! = 1
        1! = 1
        2! = 1 * 2 = 2
        3! = 1 * 2 * 3 = 6 ...

        input: 7
        output: 5040

        input: 1
        output: 1
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            string answer = Console.ReadLine();

            if (Int32.TryParse(answer, out int number))
            {
                int factorial = 1;

                if (number < 0)
                {
                    Console.WriteLine("crazy input");
                }
                else if (number == 0)
                {
                    Console.WriteLine(1);
                }
                else
                {
                    for (int i = 1; i <= number; i++)
                    {
                        factorial *= i;
                    }
                    Console.WriteLine(factorial);
                }
            }
            else
            {
                Console.WriteLine("crazy input");
            }
        }
    }
}
