using System;
using System.Collections.Generic;
using System.IO;

class Names
{
    public string Item { get; set; } //public string[] Item { get; set; }

    public Names(string word) //public Names(string[] word)
    {
        Item = word;
    }

    public string SortedNames()
    {
        StreamReader read = new StreamReader("names.txt");
        string text = read.ReadToEnd();

        text = text.Replace("\"", "");
        string[] names = text.Split(",");

        bool hasAllLetters = true;

        List<string> list = new List<string>();

        foreach (string name in names)
        {
            foreach (char character in Item)
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
}
