using System;

namespace _04_May_the_Odds
{
    /*
        Read in two integers, and multiply all odd numbers 
        between those two (including bounds).

        input:
        1
        10

        output:
        945

        input:
        10
        1

        output:
        945
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string answer = Console.ReadLine();

            if (Int32.TryParse(input, out int number1) &&
                Int32.TryParse(answer, out int number2))
            {
                if (number1 <= number2)
                {
                    int multiply = 1;

                    for (int i = number1; i <= number2; i++)
                    {
                        if (i % 2 != 0)
                        {
                            multiply *= i;
                        }
                    }
                    Console.WriteLine(multiply);
                }
                else
                {
                    int multiply = 1;

                    for (int i = number1; i >= number2; i--)
                    {
                        if (i % 2 != 0)
                        {
                            multiply *= i;
                        }
                    }
                    Console.WriteLine(multiply);
                }                     
            }
            else
            {
                Console.WriteLine("crazy input");
            }
        }
    }
}
