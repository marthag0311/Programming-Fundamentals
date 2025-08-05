using System;
using System.Collections.Generic;
using System.IO;

namespace _08_Most_Used_Smallest_Word
{
    /*
        Read in a file (download files: Boeken.zip Download 
        Boeken.zip, files already in CodeGrade)  and find 
        the most used smallest word (at least 2 characters). 
        Make your program as bulletproof as possible, otherwise, 
        print 'crazy input'

        input:
        MaxHavelaar.txt
        output:
        ik

        input:
        LoremIpsum.txt
        output:
        in
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

                string temp_word = "";
                Dictionary<string, int> words = new Dictionary<string, int>();

                foreach (char character in text)
                {
                    if (character >= 'a' && character <= 'z')
                    {
                        temp_word += character;
                    }
                    else
                    {
                        if (temp_word.Length >= 2)
                        {
                            if (!words.ContainsKey(temp_word))
                            {
                                words.Add(temp_word, 1);
                            }
                            else
                            {
                                words[temp_word]++;
                            }
                        }
                        temp_word = "";
                    }
                }

                int max = 0;
                string word = "zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz";

                foreach (var pair in words)
                {
                    if (pair.Key.Length < word.Length && pair.Value >= max)
                    {
                        word = pair.Key;
                        max = pair.Value;
                    }
                }
                Console.WriteLine(word);

                read.Close();
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
