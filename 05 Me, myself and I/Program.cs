using System;
using System.IO;
using System.Text.RegularExpressions;

namespace _05_Me__myself_and_I
{
    /*
        Find out if the artists are a bit self-centered or not, 
        are they talking about themselves in their lyrics or not? 
        Count the number of times they mention themselves in their 
        lyrics (files are already in CodeGrade and are located in the 
        same folder). Download files.Download Download files.

        Read in the name of an artist to find out!

        Important: use of Linq-library is forbidden!

        input:
        Nicki Minaj

        output:
        577 occurrences of Nicki Minaj

        input:
        Billie Eilish

        output:
        77 occurrences of Billie Eilish
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            string answer = Console.ReadLine();
            string input = answer.ToLower();
            string[] artist = input.Split(" ");

            string name = "";

            foreach (string term in artist)
            {
                if (Char.IsLower(term[0]))
                {
                    char character = Char.ToUpper(term[0]); //OR char.ToUpper(term[0])
                    name += character;

                    for (int i = 1; i < term.Length; i++)
                    {
                        name += term[i];
                    }
                }
                else
                {
                    foreach (char element in term)
                    {
                        name += element;
                    }
                }
            }

            string filename = name + ".txt";

            StreamReader read = new StreamReader(filename);
            string line = read.ReadLine().ToLower();

            int count = 0;

            while (line != null)
            {
                string[] array = line.Split(";");
                string lyrics = array[5];

                Regex rx = new Regex($@"{input}");
                MatchCollection occurrences = rx.Matches(lyrics);

                count += occurrences.Count;

                line = read.ReadLine();
            }
            
            Console.WriteLine($"{count} occurrences of {answer}");
            read.Close();
            
        }
    }
}
