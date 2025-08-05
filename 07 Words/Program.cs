using System;
using System.IO;
using System.Linq;

namespace _07_Words
{
    /*
        Select words consisting only of letters in a certain file 
        (already in CodeGrade files.zip Download files.zip) of a 
        certain length that also contain specific characters. Read 
        the file first, then the characters, and finally the number 
        of characters. Print each unique word that meets the conditions.

        Make your program as bulletproof as possible and print 
        out clear error messages, according to this list:
        - Format exception --> 'converting problem'
        - Overflow exception --> 'too big for this type'
        - FileNotFound exception --> 'file not found'
        - Any other exception --> 'crazy input'

        input:
        BTS.txt
        doeas
        8
        output:
        ssodanae smeraldo absorbed shadowed dwaesseo saedorok soredake handsome safegood 

        input:
        Beyonce.txt
        yz
        6
        output:
        swizzy
     */
    internal class Program
    {
        static void Main(string[] args)
        {      
            try
            {
                string filename = Console.ReadLine();
                string characters = Console.ReadLine();
                string input = Console.ReadLine();

                StreamReader read = new StreamReader(filename);
                string text = read.ReadToEnd().ToLower();

                string word = "";
                string phrase = "";
                bool contains = true;

                if (Int32.TryParse(input, out int length))
                {
                    foreach (char character in text)
                    {
                        if (character >= 'a' && character <= 'z')
                        {
                            word += character;
                        }
                        else
                        {
                            foreach (char item in characters)
                            {
                                if (word.Contains(item))
                                {
                                    contains = true;
                                }
                                else
                                {
                                    contains = false;
                                    break;
                                }
                            }

                            if (contains)
                            {
                                if (word.Length == length)
                                {
                                    phrase += word + " ";
                                }
                            }
                            word = "";
                        }
                    }

                    int index = 0;
                    string[] notUnique = phrase.Split(' ');
                    string[] unique = new string[notUnique.Length];

                    for (int i = 0; i < notUnique.Length; i++)
                    {
                        if (!unique.Contains(notUnique[i]))
                        {
                            unique[index] = notUnique[i];
                            index++;
                        }
                    }

                    foreach (string element in unique)
                    {
                        Console.Write(element + " ");
                    }
                }
                else
                {
                    Console.WriteLine("converting problem");
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
                Console.WriteLine("file not found");
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
