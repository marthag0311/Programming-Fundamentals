using System;

namespace _00_Pendulem
{
    /*
        A pendulum word is a word that begins and 
        ends with the same number of letters in the 
        same order, for a certain number greater 
        than zero but less than the length of the 
        word. The maximum number of the same letters 
        is called the degree of the pendulum word. 
        It’s up to you to determine the degree of an 
        entered word.
        
        alfalfa --> alfa & alfa  4 letters = degree 4

        Input:
        Alfalfa

        Output:
        Alfalfa is a pendulum word: degree 4

        **************************************************

        Input: 
        pneumonoultramicroscopicsilicovolcanoconiosis

        Output: 
        Pneumonoultramicroscopicsilicovolcanoconiosis account is not a pendulum word.

        Note: Take crazy input into account!

    */
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            if (word.Length % 2 == 0)
            {
                string halfOne = "";

                for (int i = 0; i < word.Length / 2; i++)
                {
                    halfOne += word[i];
                }

                string halfSecond = "";
                int halfLength = word.Length / 2;

                for (int i = halfLength; i < word.Length; i++)
                {
                    halfSecond += word[i];
                }

                if (halfOne == halfSecond)
                {
                    Console.WriteLine($"{word} is a pendulum word: degree {halfLength}");
                }
                else
                {
                    Console.WriteLine($"{word} is not a pendulum word");
                }    
            }
            else
            {
                string halfOne = "";

                for (int i = 0; i < word.Length / 2; i++)
                {
                    halfOne += word[i];
                }

                string halfSecond = "";
                int halfLength = word.Length / 2;

                for (int i = halfLength; i < word.Length; i++)
                {
                    if (i == halfLength)
                    {
                        halfOne += word[i];
                    }
                    halfSecond += word[i];
                }

                if (halfOne == halfSecond)
                {
                    Console.WriteLine($"{word} is a pendulum word: degree {halfLength + 1}");
                }
                else
                {
                    Console.WriteLine($"{word} is not a pendulum word");
                }
            }
        }
    }
}