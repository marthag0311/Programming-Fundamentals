using System;

namespace _02_ASCII
{
    /*
        Read in a number and convert that number, according to 
        the ASCII table, to the corresponding character. Print 
        out the lower- and uppercase version of that character.
 
        Tips:

        =ASCII table (Download ASCII table)
        =we can easily convert between char and int (as we seen 
        in class)
        =check out String-library!

        input:
        66

        output:
        b
        B

        input:
        107

        output:
        k
        K
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            string answer = Console.ReadLine();

            if (Int32.TryParse(answer, out int number))
            {
                char character = (char)(number);

                Console.WriteLine(character.ToString().ToLower());
                Console.WriteLine(character.ToString().ToUpper());
            }
        }
    }
}
