using System;
using System.Collections.Generic;
using System.IO;

namespace _08_Emordnilap
{
    /*
        An emordnilap is a word that results in a different 
        existing word when it is reversed! Read in a sentence 
        and print out a sorted distinct (no duplicates!) list 
        of all emordnilap-words! Check the reverse word through 
        the English word file (english.txt Download english.txt). 
        Make your program as bulletproof as possible, otherwise, 
        print 'crazy input'

        input:
        A good laugh and a long sleep are the best cures in the 
        doctors book.

        output:
        a and are sleep

        input:
        It doesnt matter who you are, what you do, or how happy 
        you consider yourself to be, there are going to be days 
        when you are going to feel completely stressed out.

        output:
        are be do it or stressed
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] input = Console.ReadLine().Replace(",", "").Replace(".", "").ToLower().Split(' ');

                StreamReader read = new StreamReader("english.txt");
                string line = read.ReadLine().ToLower();

                List<string> words = new List<string>();

                while (line != null)
                {
                    words.Add(line);

                    line = read.ReadLine();
                }

                string reversed = "";
                List<string> emordnilaps = new List<string>();

                for (int i = 0; i < input.Length; i++)
                {
                    for (int j = input[i].Length - 1; j >= 0; j--)
                    {
                        reversed += input[i][j];
                    }

                    if (words.Contains(reversed))
                    {
                        if (!emordnilaps.Contains(input[i]))
                        {
                            emordnilaps.Add(input[i]);
                        }
                    }
                    reversed = "";
                }

                for (int i = 0; i < emordnilaps.Count; i++)
                {
                    for (int j = i; j < emordnilaps.Count; j++)
                    {
                        if (String.Compare(emordnilaps[j], emordnilaps[i]) < 0)
                        {
                            string temp = emordnilaps[i];
                            emordnilaps[i] = emordnilaps[j];
                            emordnilaps[j] = temp;
                        }
                    }
                }

                foreach (string emordnilap in emordnilaps)
                {
                    Console.Write(emordnilap + " ");
                }

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
