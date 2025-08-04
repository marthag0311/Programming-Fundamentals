using System;
using System.Collections.Generic;
using System.IO;

public class TrialB1
{
	public string Phrase { get; set; }

	public TrialB1(string phrase)
	{
		Phrase = phrase;
	}

	public string LeastAsciiValue()
	{
        StreamReader read = new StreamReader(Phrase);
        string line = read.ReadLine();

        Dictionary<string, string> dict = new Dictionary<string, string>();

        while (line != null)
        {
            string[] array = line.Split(';');

            dict.Add(array[0], array[1]);
            line = read.ReadLine();
        }

        string word = "";
        Dictionary<string, string> nickname = new Dictionary<string, string>();

        foreach (var pair in dict)
        {
            foreach (char character in pair.Key)
            {
                if (character != '@')
                {
                    word += character;
                }
                else
                {
                    nickname.Add(word, pair.Value);
                    word = "";
                    break;
                }
            }
        }

        int sum = 0;
        int temp = 999999999;
        string name = "";
        Dictionary<string, int> ascii = new Dictionary<string, int>();

        foreach (var pair in nickname)
        {
            foreach (char character in pair.Key)
            {
                sum += (int)character;
            }

            if (temp >= sum)
            {
                temp = sum;
                name = pair.Value;
            }
        }
        return name.Trim();
    }
}
