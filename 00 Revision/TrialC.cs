using System;
using System.IO;
using System.Security;
using System.Xml.Linq;

public class TrialC
{
	public string Phrase { get; set; }

	public TrialC(string phrase)
	{
        Phrase = phrase;
	}

	public string Email()
	{
        //C
        //file contained emails (tristan.vandevelde@thomasmore.be)
        //find the name with the largest ascii value

        //input: 
        //output: Collin Vandervorst

        string name = "";
        if (Phrase == "C")
        {
            StreamReader read = new StreamReader("names.txt");
            string line = read.ReadLine();

            int sum = 0;
            int temp = 0;
            string word = "";
            string email = "";

            while (line != null)
            {
                foreach (char ch in line)
                {
                    if (ch != '@')
                    {
                        word += ch;

                    }
                    else
                    {
                        break;
                    }

                }

                foreach (var ch in word)
                {
                    sum += Convert.ToInt32(ch);

                }


                if (temp < sum)
                {
                    temp = sum;
                    email = word;
                }
                sum = 0;
                word = "";

                line = read.ReadLine();

            }

            string output = email.Replace(".", " ");

            //string name = "";
            string[] array = output.Split(' ');

            for (int i = 0; i < array.Length; i++)
            {
                char[] charArray = array[i].ToCharArray();

                for (int j = 0; j < charArray.Length; j++)
                {
                    if (j == 0)
                    {
                        name += charArray[j].ToString().ToUpper();
                    }
                    else
                    {
                        name += charArray[j];
                    }
                }
                name += " ";
            }
        }
        return name;
    }
}
