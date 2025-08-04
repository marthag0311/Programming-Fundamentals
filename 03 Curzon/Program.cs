using System;

namespace _03_Curzon
{
    /*
        Read in a non-negative integer (print out 'crazy input' if the input is not given correctly) and check if it is a Curzon Number. A Curzon number is a number N where 2^N + 1 is divisible by 2*N + 1. 

        input:
        5

        output:
        True

        input:
        14.0

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
                if ((Math.Pow(2, number) + 1) % (2 * number + 1) == 0)
                {
                    Console.WriteLine(true);
                }
                else
                {
                    Console.WriteLine(false);
                } 
                    
            }
            else
            {
                Console.WriteLine("crazy input");
            }
        }
    }
}
