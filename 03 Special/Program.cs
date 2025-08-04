using System;
using System.Text.RegularExpressions;

namespace _03_Special
{
    /*
        Read in a character and check whether a character is a vowel, a consonant, a digit or a special character.

        input:
        #
        output:
        special character

        input:
        Y
        output:
        consonant
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            string answer = Console.ReadLine();
            char character = Convert.ToChar(answer);

            if (Char.IsLetter(character))
            {
                if (character == 'a' || character == 'e' || 
                    character == 'i' || character == 'o' || 
                    character == 'u' || character == 'A' ||
                    character == 'E' || character == 'I' ||
                    character == 'O' || character == 'U')
                {
                    Console.WriteLine("vowel");
                }
                else
                {
                    Console.WriteLine("consonant");
                }
            }
            else if (Char.IsDigit(character)) // (Regex.IsMatch(answer, @"^[0-9]+$"))
            {
                Console.WriteLine("digit");
            }
            else
            {
                Console.WriteLine("special character");
            } 
                
        }
    }
}
