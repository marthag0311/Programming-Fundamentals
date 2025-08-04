using System;

namespace _01_Uppercase
{
    /*
        Read the name of a person and print the name in uppercase characters.

        Input/Output
        input:
        Elke
        output:
        HELLO ELKE

        input:
        Tristan
        output:
        HELLO TRISTAN
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            string answer = Console.ReadLine().ToUpper();

            Console.WriteLine($"HELLO {answer}");
        }
    }
}
