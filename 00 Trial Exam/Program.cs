using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace _00_Trial_Exam
{
    internal class Program
    {
        static string SortedNames(string word)
        {
            StreamReader read = new StreamReader("names.txt");
            string text = read.ReadToEnd();

            text = text.Replace("\"", "");
            string[] names = text.Split(",");

            bool hasAllLetters = true;

            List<string> list = new List<string>();

            foreach (string name in names)
            {
                foreach (char character in word.ToUpper())
                {
                    if (name.Contains(character))
                    {
                        hasAllLetters = true;
                    }
                    else
                    {
                        hasAllLetters = false;
                        break;
                    }
                }

                if (hasAllLetters)
                {
                    list.Add(name);
                }
            }

            list.Sort();

            string phrase = "";

            if (list.Count == 0)
            {
                phrase += "crazy input";
            }
            else
            {
                foreach (string item in list)
                {
                    phrase += item + " ";
                }
            }
            return phrase;
        }

        static int NextPalindrome(string digit)
        {
            int number = Convert.ToInt32(digit);

            if (number < 0)
            {
                Console.WriteLine("crazy input");
            }
            else
            {
                number += 1;
                string reversedStringNumber = "";

                string stringNumber = number.ToString();

                for (int i = stringNumber.Length - 1; i >= 0; i--)
                {
                    reversedStringNumber += stringNumber[i];
                }

                while (stringNumber != reversedStringNumber)
                {
                    number++;
                    reversedStringNumber = "";

                    stringNumber = number.ToString();

                    for (int i = stringNumber.Length - 1; i >= 0; i--)
                    {
                        reversedStringNumber += stringNumber[i];
                    }
                }
            }
            return number;
        }

        static void Main(string[] args)
        {
            string trial = Console.ReadLine();

            switch (trial)
            {
                case "trial1":
                    string word = Console.ReadLine(); //if it needed to be an array, e.g., cherry peach lime apricot 
                    Names names = new Names(word.ToUpper()); //Names names = new Names(word.Split(' '));
                    Console.WriteLine(names.SortedNames());

                    Console.WriteLine(SortedNames(word));
                    break;
                case "trial2":
                    string digit = Console.ReadLine();  
                    Palindrome palindrome = new Palindrome(digit);
                    Console.WriteLine(palindrome.NextPalindrome());

                    Console.WriteLine(NextPalindrome(digit));
                    break;
                default:
                    Console.WriteLine("default");
                    break;
            }
        }
    }
}
