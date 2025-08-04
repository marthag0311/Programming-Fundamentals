using System;

public class TrialA
{
	public string[] Phrase { get; set; }
	public TrialA(string[] array)
	{
		Phrase = array;
	}

	public string Reverse()
	{
        //A
        //reverse the array 
        //dont know which type of an array it will be

        string word = "";
        for (int i = Phrase.Length - 1; i >= 0; i--)
        {
            word += Phrase[i] + " ";
        }
        return word.Trim();
    }
}
