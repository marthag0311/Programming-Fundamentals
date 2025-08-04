using System;

namespace _02_Odd
{
    /*
        Read in an integer. Print true if the number is odd, otherwise print false.

        input:
        9

        output:
        True

        input:
        -4

        output:
        False
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            string answer = Console.ReadLine();

            if (Int32.TryParse(answer, out int integer))
            {
                if (integer % 2 == 0)
                {
                    Console.WriteLine(false);
                }
                else
                {
                    Console.WriteLine(true);
                }
            }
        }
    }
}
