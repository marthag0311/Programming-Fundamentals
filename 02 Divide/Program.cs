using System;

namespace _02_Divide
{
    /*
        Read in two integers, a and b, print true if a can be divided evenly by b. print false otherwise.

        input:
        10
        4

        output:
        False

        input:
        10
        5

        output:
        True
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            string answerA = Console.ReadLine();
            string answerB = Console.ReadLine();

            if (Int32.TryParse(answerA, out int integerA) &&
                Int32.TryParse(answerB, out int integerB))
            {
                if (integerA % integerB == 0)
                {
                    Console.WriteLine(true);
                }
                else
                {
                    Console.WriteLine(false);
                }
            }
        }
    }
}
