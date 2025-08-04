using System;
using System.Collections.Generic;

public class TrialB
{
	public string Phrase { get; set; }
	public TrialB(string phrase)
	{
		Phrase = phrase;
	}

	public string Countries()
	{
        //B
        //read in the name of the country with its population 
        //output the country with the highest population
        //we dont when the number of the input
        //Belgium 300
        //Spain 5000

        Dictionary<string, int> dict = new Dictionary<string, int>();

        List<string> list = new List<string>();

        while (Phrase != "") //or String.Empty
        {
            list.Add(Phrase);
            Phrase = Console.ReadLine();      
        }

        foreach (string element in list)
        {
            string[] array = element.Split(' ');
            dict.Add(array[0], int.Parse(array[1]));
        }

        int max = 0;
        string temporary = "";

        foreach (var pair in dict)
        {
            if (max < pair.Value)
            {
                max = pair.Value;
                temporary = pair.Key;
            }                
        }
        return temporary;
    }
}
