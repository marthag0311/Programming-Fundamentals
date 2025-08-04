using System;
using System.Collections.Generic;
using System.IO;

namespace Names
{
    class Program
    {
        static void Main(string[] args)
        {
            // ELZBT
            // ELIZABET ELIZABETH ELIZBETH ELIZEBETH

            // TUUR
            // not found

            // KMBY
            // KEMBERLY KIMBERELY KIMBERLEY KIMBERLY KIMBERY KYMBERLY
            string characters = Console.ReadLine().ToUpper();

            StreamReader read = new StreamReader("names.txt");
            string text = read.ReadToEnd();

            text = text.Replace("\"", "");
            string[] names = text.Split(",");   

            List<string> list = new List<string>();

            bool hasLetters = true;

            foreach (string name in names)
            {
                foreach (char character in characters)
                {
                    if (name.Contains(character))
                    {
                        hasLetters = true;
                    }
                    else
                    {
                        hasLetters = false;
                        break;
                    }
                }

                if (hasLetters)
                {
                    list.Add(name);
                }
            }

            List<string> sorted = new List<string>();

            if (list.Count > 0)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    char[] array = list[i].ToCharArray();

                    List<char> onlyabb = new List<char>();

                    //string tempo = "";

                    foreach (char character in array)
                    {
                        if (characters.Contains(character))
                        {
                            //tempo += character;

                            if (!onlyabb.Contains(character))
                            {
                                onlyabb.Add(character);
                            }
                        }
                    }

                    string tempo = String.Join("", onlyabb);

                    if (tempo == characters)
                    {
                        sorted.Add(list[i]);
                    }
                }
                sorted.Sort();

                if (sorted.Count > 0)
                {
                    foreach (string element in sorted)
                    {
                        Console.Write(element + " ");
                    }
                }
                else
                {
                    Console.WriteLine("not found");
                }                
            }
            else
            {
                Console.WriteLine("not found");
            }
        }
    }
}
