using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace _05_Longest_Word
{
    /*
        Read a file and find the longest word in that file 
        (files are already in CodeGrade and are located in 
        the same folder)! Download files.Download Download files.

        Important: use of Linq-library is forbidden!

        input:
        KatyPerry.txt

        output:
        southernplayalisticadillacmuzik

        input:
        BTS.txt

        output:
        owattahazunomerodīmadanokorukitaruhimo
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            string filename = Console.ReadLine();

            StreamReader read = new StreamReader(filename);
            string text = read.ReadToEnd();

            string word = "";
            string temporary = "";

            foreach (char character in text)
            {
                //normalize the character so that the character and its
                //diacritic are written as several codepoints. Then, check
                //if you have a letter followed by a diacritic/accent
                /*string codepoints = character.ToString().Normalize(NormalizationForm.FormD);
                if (codepoints.Length > 1 && char.IsLetter(codepoints[0]))
                {
                    temporary += codepoints;
                }*/
                if (Char.IsLetter(character))
                {
                    temporary += character;
                }
                else
                {
                    if (temporary.Length > word.Length)
                    {
                        word = temporary;
                    }
                    temporary = "";
                }
            }
            Console.WriteLine(word.Trim());
        }
    }
}
