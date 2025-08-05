using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;

namespace _07_Run_length_Encoding
{
    /*
        Run-length encoding is the replacement of repeating patterns 
        of characters with the number of repetitions plus the character.
        For example, the string AaaabbbdddCCCCeeeeeffff can be compressed 
        by A3a3b3d4C5e4f (we only consider alphabetical characters for 
        this compression method)

        Make your program as bulletproof as possible and print out clear 
        error messages, according to this list: 
        - Format exception --> 'converting problem
        - Overflow exception --> 'too big for this type'
        - Any other exception --> 'crazy input'

        input:
        AaaabbbdddCCCCeeeeeffff
        output:
        A3a3b3d4C5e4f

        input:
        aaaaa12bbbbbbbbb
        output:
        crazy input
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                char[] input = Console.ReadLine().ToCharArray();

                bool isAlphabet = true;

                foreach (char character in input)
                {
                    if (character >= 'a' && character <= 'z' ||
                        character >= 'A' && character <= 'Z')
                    {
                        isAlphabet = true;
                    }
                    else
                    {
                        isAlphabet = false;
                        Console.WriteLine("crazy input");
                        break;
                    }
                }

                int count = 0;
                string temporary = "";
                List<string> strings = new List<string>();

                foreach (char character in input)
                {
                    strings.Add(character.ToString());
                }

                if (isAlphabet)
                {
                    for (int i = 0; i < strings.Count; i++)
                    {
                        if (i == 0)
                        {
                            temporary = strings[i];
                            count++;
                        }
                        else if (i == strings.Count - 1)
                        {
                            if (count == 1)
                            {
                                Console.Write($"{temporary}");
                                Console.Write($"{strings[i]}");
                            }
                            else
                            {
                                Console.WriteLine($"{count + 1}{temporary}");
                            }
                        }
                        else
                        {
                            if (temporary == strings[i])
                            {
                                count++;
                            }
                            else
                            {
                                if (count == 1)
                                {
                                    Console.Write($"{temporary}");
                                    temporary = strings[i];
                                }
                                else
                                {
                                    Console.Write($"{count}{temporary}");
                                    temporary = strings[i];
                                    count = 1;
                                }
                            }
                        }

                    }
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("converting problem");
            }
            catch (OverflowException)
            {
                Console.WriteLine("too big for this type");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("crazy input");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("crazy input");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("crazy input");
            }
            catch (Exception) //(Exception ex)
            {
                Console.WriteLine("crazy input");
                //Console.WriteLine(ex.Message);
            }
        }
    }
}