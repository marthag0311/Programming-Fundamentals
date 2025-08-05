using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters;
using System.Text.RegularExpressions;
using System.Xml;

namespace _05_Z_of_Zorro
{
    /*
        Apparently, the character Z is the least used in the English 
        language, so find all (unique!) lowercase words from a given 
        file containing a Z. Print them out in the order they appear 
        in the file (files are already in CodeGrade and are located 
        in same folder)! Download files.Download Download files.

        Important: use of Linq-library is forbidden!

        input:
        BillieEilish.txt

        output:
        froze vandalize size amazing fantasize sympathize frozen 
        arizona mnoppuzzle zeds gazzo paparazzi hazey iizi kez 
        bozar crazy 

        input:
        SelenaGomez.txt

        output:
        gomez sympathize size zipper crazy hazy recognize fantasize 
        mesmerized vez realize wizards breeze amazing crazier 
        crcrcrazier jazz hypnotized civilized lazy corazon empieza 
        razona frozen zapped dizzy cuz akzel 
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            string filename = Console.ReadLine();

            StreamReader read = new StreamReader(filename);
            string text = read.ReadToEnd().ToLower();

            Regex regex = new Regex(@"[^\s]*[z][^\s]*");
            MatchCollection matches = regex.Matches(text);

            string phrase = "";

            foreach (Match match in matches)
            {
                if (!phrase.Contains(match.Value))
                {
                    phrase += match.Value + " ";
                }
            }

            string words = "";
            bool lettersOnly = true;

            string[] array = phrase.Split(" ");

            foreach (string word in array)
            {
                foreach (char element in word)
                {
                    if (char.IsDigit(element))
                    {
                        lettersOnly = false;
                        break;
                    }
                    else
                    {
                        lettersOnly = true;
                    }
                }

                if (lettersOnly)
                {
                    words += word + " ";
                }
            }

            string temporary = "";
            string noSymbols = "";

            foreach (char character in words)
            {
                if (char.IsLetter(character))
                {
                    temporary += character;
                }
                else
                {
                    if (temporary.Contains('z'))
                    {
                        if (!noSymbols.Contains(temporary))
                        {
                            noSymbols += temporary + " ";
                        }
                    }
                    temporary = "";
                }
            }

            string alphabetOnly = "";
            string[] unique = noSymbols.Trim().Split(" ");

            foreach (string word in unique)
            {
                if (Regex.IsMatch(word, @"^[a-zA-Z]+$"))
                {
                    alphabetOnly += word + " ";
                }
            }
            Console.WriteLine(alphabetOnly.Trim());            
        }
    }
}
