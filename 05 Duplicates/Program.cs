using System;

namespace _05_Duplicates
{
    /*
        Read in a string and remove all duplicate characters 
        from that string.

        Important: use of Linq-library is forbidden!

        input:
        aaaaaaabbbbbbbaaaaaaaAAcccccc

        output:
        abAc

        input:
        this is incredible

        output:
        this ncredbl
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            string phrase = "";

            foreach (char character in word)
            {
                if (!phrase.Contains(character))
                {
                    phrase += character;
                }
            }

            Console.WriteLine(phrase);
        }
    }
}
