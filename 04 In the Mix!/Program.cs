using System;
using System.Linq;

namespace _04_In_the_Mix_
{
    /*
        Read in two strings and create a new word by mixing both 
        strings. Start with the longest word and alternately take 
        a character of both words until all characters are used in 
        the mix. (tip: work with the length of a word and ElementAt())

        input:
        weave
        123
        output:
        w1e2a3ve

        input:
        OTHER
        DELIVERY
        output:
        DOETLHIEVRERY
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string term = Console.ReadLine();

            string phrase = "";

            if (word.Length >= term.Length)
            {               
                for (int i = 0; i < word.Length; i++)
                {
                    phrase += word.ElementAt(i);

                    for (int j = i; j < term.Length; j++)
                    {
                        phrase += term.ElementAt(j);
                        break;

                    }
                }
                Console.Write(phrase);
            }
            else
            {
                for (int i = 0; i < term.Length; i++)
                {
                    phrase += term.ElementAt(i);

                    for (int j = i; j < word.Length; j++)
                    {
                        phrase += word.ElementAt(j);
                        break;

                    }
                }
                Console.Write(phrase);
            }
        }
    }
}
