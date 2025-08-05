using System;
using System.IO;

namespace _05_Single_Ladies
{
    /*
        Read in a filename. Find all single 'ladies' (also women & girls ;)) in a given file (files are already in CodeGrade and are located in same folder). Download files.Download Download files.

        Important: use of Linq-library is forbidden!

        input:
        Beyonce.txt

        output:
        girl/girls: 953 matches found
        lady/ladies: 291 matches found
        woman/women: 203 matches found

        input:
        LadyGaga.txt

        output:
        girl/girls: 366 matches found
        lady/ladies: 849 matches found
        woman/women: 51 matches found
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            string filename = Console.ReadLine();

            StreamReader read = new StreamReader(filename);
            string text = read.ReadToEnd().ToLower();

            int girlORgirls = 0; 
            int ladyORladies = 0;
            int womanORwomen = 0;
            string single = "";

            foreach (char character in text)
            {
                if (character >= 'a' && character <= 'z')
                {
                    single += character;
                }
                else
                {
                    if (single == "girl" || single == "girls")
                    {
                        girlORgirls++;
                    }
                    else if (single == "lady" || single == "ladies")
                    {
                        ladyORladies++;
                    }
                    else if (single == "woman" || single == "women")
                    {
                        womanORwomen++;
                    }
                    single = "";
                }
            }
            Console.WriteLine("girl/girls: " + girlORgirls + " matches found");
            Console.WriteLine("lady/ladies: " + ladyORladies + " matches found");
            Console.WriteLine("woman/women: " + womanORwomen + " matches found");
            read.Close();
        }
    }
}
