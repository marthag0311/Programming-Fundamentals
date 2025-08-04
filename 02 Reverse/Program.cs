using System;

namespace _02_REVERSE
{
    /*
        Read in three characters and display them in reverse order.

        input:
        t
        a
        c

        output:
        cat

        input:
        m
        a
        j

        output:
        jam
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            char character1 = Convert.ToChar(Console.ReadLine());
            char character2 = Convert.ToChar(Console.ReadLine());
            char character3 = Convert.ToChar(Console.ReadLine());

            string word = "";

            word += character3;
            word += character2;
            word += character1;

            Console.WriteLine(word);
        }
    }
}
