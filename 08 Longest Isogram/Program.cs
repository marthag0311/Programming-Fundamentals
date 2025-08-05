using System;
using System.Collections.Generic;
using System.IO;

namespace _08_Longest_Isogram
{
    /*
        A word in which no letter of the alphabet occurs 
        more than once is an isogram. Now read in a file 
        (download files: Boeken.zip Download Boeken.zip, 
        files already in CodeGrade)  and find the longest 
        isogram. Make your program as bulletproof as possible, 
        otherwise, print 'crazy input'

        input:
        MaxHavelaar.txt
        output:
        uitmaken

        input:
        LoremIpsum.txt
        output:
        interdum
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string filename = Console.ReadLine();

                StreamReader read = new StreamReader(filename);
                string text = read.ReadToEnd().ToLower();

                string word = "";
                string temp_word = "";
                bool isOne = true;
                Dictionary<char, int> characters = new Dictionary<char, int>();

                foreach (char character in text)
                {
                    if (character >= 'a' && character <= 'z')
                    {
                        temp_word += character;
                    }
                    else
                    {
                        if (word.Length < temp_word.Length)
                        {
                            foreach (char element in temp_word)
                            {
                                if (!characters.ContainsKey(element))
                                {
                                    characters.Add(element, 1);
                                }
                                else
                                {
                                    characters[element]++;
                                }
                            }

                            foreach (var pair in characters)
                            {
                                if (pair.Value > 1)
                                {
                                    isOne = false;
                                    break;
                                }
                                else
                                {
                                    isOne = true;
                                }
                            }

                            if (isOne)
                            {
                                word = temp_word;
                            }

                            foreach (var key in characters.Keys)
                            {
                                characters.Remove(key);
                            }
                        }
                        temp_word = "";
                    }
                }
                Console.WriteLine(word);
            }
            catch (FormatException)
            {
                Console.WriteLine("crazy input");
            }
            catch (OverflowException)
            {
                Console.WriteLine("crazy input");
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
