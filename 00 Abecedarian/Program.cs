using System.Collections.Generic;

namespace _00_Abecedarian
{
    /*
        An abecedarian word is a word whose letters 
        are in alphabetical order. Read in a file.txt.

        Input:
        B2 => question number
        m

        Output: 
        deem
        Note: if word not found, print “not found”
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            char character = Convert.ToChar(Console.ReadLine());

            StreamReader reader = new StreamReader("file.txt");
            string text = reader.ReadToEnd().ToLower();

            string[] array = text.Split();

            List<string> list = new List<string>();

            foreach (string word in array)
            {
                if (word.EndsWith(character))
                {
                    if (!list.Contains(word))
                    {
                        list.Add(word);
                    }
                }
            }

            char temp = 'A';
            bool isAbecedarian = true;
            List<string> abecedarian = new List<string>();

            foreach (string word in list)
            {
                foreach (char c in word)
                {
                    if (temp < c || temp == c)
                    {
                        temp = c;
                        isAbecedarian = true;
                    }
                    else
                    {
                        isAbecedarian = false;
                        break;
                    }
                }

                temp = 'A';

                if (isAbecedarian)
                {
                    abecedarian.Add(word);
                }
            }

            foreach (string word in abecedarian)
            {
                Console.WriteLine(word);
            }
        }
    }
}