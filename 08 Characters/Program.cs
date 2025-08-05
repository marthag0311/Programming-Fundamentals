using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _08_Characters
{
    /*
        Read in a file (download files: Boeken.zip Download 
        Boeken.zip, files already in CodeGrade) and find the 
        most used vowel and consonant. Make your program as 
        bulletproof as possible, otherwise, print 'crazy input'

        input:
        MaxHavelaar.txt
        output:
        vowel e
        consonant n

        input:
        LoremIpsum.txt
        output:
        vowel u
        consonant s
     */
    internal class Program
    {
        static void Main(string[] args)
        {   
            try
            {
                Dictionary<char, int> characters = new Dictionary<char, int>();

                string filename = Console.ReadLine();

                StreamReader read = new StreamReader(filename);
                string text = read.ReadToEnd().ToLower();

                foreach (char character in text)
                {
                    if (character >= 'a' && character <= 'z')
                    {
                        if (!characters.ContainsKey(character))
                        {
                            characters.Add(character, 1);
                        }
                        else
                        {
                            characters[character]++;
                        }
                    }
                }

                int vowelmax = 0;
                char vowel = 'a';

                int consonantmax = 0;
                char consonant = 'b';

                foreach (var pair in characters)
                {
                    if (pair.Key == 'a' || pair.Key == 'e' ||
                        pair.Key == 'i' || pair.Key == 'o' ||
                        pair.Key == 'u')
                    {
                        if (pair.Value > vowelmax)
                        {
                            vowelmax = pair.Value;
                            vowel = pair.Key;
                        }
                    }
                    else
                    {
                        if (pair.Value > consonantmax)
                        {
                            consonantmax = pair.Value;
                            consonant = pair.Key;
                        }
                    }
                }
                Console.WriteLine("vowel " + vowel);
                Console.WriteLine("consonant " + consonant);
               
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
