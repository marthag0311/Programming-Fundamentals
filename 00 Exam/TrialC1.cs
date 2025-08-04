using System;
using System.Collections.Generic;
using System.IO;

public class TrialC1
{
	public string Phrase { get; set; }
	public TrialC1(string phrase)
	{
		Phrase = phrase;
	}

	public int CountCharacters()
	{
        string speech = Console.ReadLine();

        StreamReader read = new StreamReader(Phrase);
        string line = read.ReadLine();

        string word = "";

        List<string> list = new List<string>();

        while (line != null)
        {
            string[] array = line.Split(' ');

            foreach (char character in line)
            {
                if (char.IsLetter(character))
                {
                    word += character;
                }
                else
                {
                    List<string> temp = new List<string>();
                    temp.Add(word);

                    if (word == speech)
                    {
                        list.Add(temp[0]);
                    }
                    word = "";
                }
            }
            line = read.ReadLine();
        }

        int sum = 0;
        foreach (string item in list)
        {
            sum += item.Length;
        }
        return sum;
    }
}
