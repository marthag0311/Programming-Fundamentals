using System;
using System.Runtime.CompilerServices;

namespace _06_Ending
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().ToLower().Split(' ');

            string word = input[0];
            string phrase = input[1];

            string wordReversed = "";
            string phraseReversed = "";

            for (int i = word.Length - 1; i >= 0; i--)
            {
                wordReversed += word[i];
            }
            for (int i = phrase.Length - 1; i >= 0; i--)
            {
                phraseReversed += phrase[i];
            }

            char[] first = wordReversed.ToCharArray();
            char[] second= phraseReversed.ToCharArray();

            string ending = "";
            string endingReversed = "";

            if (second.Length > first.Length)
            {
                for (int i = 0; i < first.Length; i++)
                {
                    for (int j = i; j < second.Length; j++)
                    {
                        if (first[i] == second[j])
                        {
                            ending += first[i];
                            break;
                        }
                        else
                        {
                            break;
                        }
                    }   
                }
                for (int i = ending.Length - 2; i >= 0; i--)
                {
                    endingReversed += ending[i];
                }
                Console.WriteLine(endingReversed);
            }
            else
            {
                for (int i = 0; i < second.Length; i++)
                {
                    for (int j = i; j < first.Length; j++)
                    {
                        if (second[i] == first[j])
                        {
                            ending += first[i];
                            break;
                        }
                        else
                        {
                            break;
                        }
                    }
                }

                for (int i = ending.Length - 2; i >= 0; i--)
                {
                    endingReversed += ending[i];
                }
                Console.WriteLine(endingReversed);
            }    

        }
    }
}