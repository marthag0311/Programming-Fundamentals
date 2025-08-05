using System;

namespace _04_Floyd_s_Triangle
{
    /*
        Read in a number a lines and print out the triangle of Floyd! 
        https://en.wikipedia.org/wiki/Floyd%27s_triangle Links to an external site.

        input:
        5

        output:
        1 
        2 3 
        4 5 6 
        7 8 9 10 
        11 12 13 14 15 

        input:
        2

        output:
        1 
        2 3 
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            string answer = Console.ReadLine();

            int count = 1;

            if (Int32.TryParse(answer, out int number))
            {
                for (int i = 0; i < number; i++)
                {
                    for (int j = 0; j <= i; j++)
                    {
                        Console.Write(count++ + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
