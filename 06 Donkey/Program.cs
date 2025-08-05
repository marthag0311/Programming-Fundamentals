using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;
using System.Xml;

namespace _00_Practise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] answer = Console.ReadLine().Split(' ');

            char[] input = new char[answer.Length];

            for (int i = 0; i < answer.Length; i++)
            {
                input[i] = Convert.ToChar(answer[i]);
            }

            StreamReader read = new StreamReader("donkey.txt");
            string text = read.ReadToEnd();

            string word = "";
            //string[] sort;

            List<string> list = new List<string>();

            foreach (char character in text)
            {
                if (character >= 'a' && character <= 'z')
                {
                    word += character;
                }
                else
                {

                    if (word.StartsWith(input[0]) && word.EndsWith(input[1]))
                    {
                        list.Add(word);
                    }
                }
                word = "";
            }

            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list.Count; j++)
                {
                    if (String.Compare(list[j], list[i]) < 0)
                    {
                        string temporary = list[i];
                        list[i] = list[j];
                        list[j] = temporary;
                    }
                }
            }

            foreach (string item in list)
            {
                Console.WriteLine(item + " ");
            }
        }
    }
}