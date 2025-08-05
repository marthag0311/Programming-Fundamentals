using System;

namespace _06_Anagram
{
    /*
        Read in two strings and find out if they are anagrams of each other. 
        An anagram is a word or phrase formed by rearranging the letters of 
        a different word or phrase, for example, the word binary can be 
        rearranged into brainy.

        Note: use of Linq-library or Array-library is forbidden!

        input:
        evil
        vile

        output:
        True

        input:
        forty five
        fifty four

        output:
        False
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            string read = Console.ReadLine().ToLower().Replace(" ", "");
            string input = Console.ReadLine().ToLower().Replace(" ", "");

            char[] phrase = read.ToCharArray();
            char[] sentence = input.ToCharArray();

            //Sorting
            for (int i = 0; i < phrase.Length; i++)
            {
                for (int j = i; j < phrase.Length; j++)
                {
                    if (phrase[j] < phrase[i])
                    {
                        char temporary = phrase[i];
                        phrase[i] = phrase[j];
                        phrase[j] = temporary;
                    }
                }
            }
            for (int i = 0; i < sentence.Length; i++)
            {
                for (int j = i; j < sentence.Length; j++)
                {
                    if (sentence[j] < sentence[i])
                    {
                        char temporary = sentence[i];
                        sentence[i] = sentence[j];
                        sentence[j] = temporary;
                    }
                }
            }

            //Anagram?   
            string word = string.Join("", phrase);
            string term = string.Join("", sentence);

            if (word == term)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }          
        }
    }
}
