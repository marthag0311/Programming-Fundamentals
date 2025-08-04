using System;

namespace _01_Nice_To_Meet_You
{
    /*
        Read a person's name, trim all spaces and print 'Nice to meet you <name>' on two lines.

        Input/Output
        input:
             Elke     
        output:
        Nice to meet you
        Elke

        input:
            Tristan   
        output:
        Nice to meet you
        Tristan
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine().TrimStart().TrimEnd();

            Console.WriteLine($"Nice to meet you \n{name}");


        }
    }
}
