using System;
using System.Threading;

namespace _05_Isogram
{
    /*
        An isogram is a word in which no letter is repeated. 
        Examples of isograms are complainers, danger, and of 
        course the word 'isogram' ;)

        Read in a string and check if it is an isogram.

        Important: use of Linq-library is forbidden!

        input:
        complainers

        output:
        True

        input:
        incredible

        output:
        False
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine().ToLower();

            int count = 0;
            bool isIsogram = true;

            for (int i = 0; i< word.Length; i++)
            {
                for (int j = 0; j < word.Length; j++)
                {
                    if (word[i] == word[j])
                    {
                        count++;
                    }
                }

                if (count >= 2)
                {
                    Console.WriteLine(false);
                    isIsogram = false;
                    break;
                }
                count = 0;
            }

            if (isIsogram)
            {
                Console.WriteLine(true);
            }
        }
    }
}
