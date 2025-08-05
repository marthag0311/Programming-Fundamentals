using System;
using System.IO;
using System.Text.RegularExpressions;

namespace _06_Sum
{
    internal class Program
    {
        /*
            Read in a file name and find all the numbers in that 
            file and add them up. Important, exclude the numbers 
            from years (eg 2018) and dates (eg 2018-09-10)! 

            Note: files files.zip Download files.zipare already 
            in CodeGrade and use of Linq-library or Array-library 
            is forbidden!

            input:
            Beyonce.txt

            output:
            10877

            input:
            LadyGaga.txt

            output:
            3743
         */
        static void Main(string[] args)
        {
            string filename = Console.ReadLine();
                                 
            StreamReader read = new StreamReader(filename);
            string line = read.ReadLine();

            int sum = 0;

            while (line != null)
            {
                string[] phrases = line.Split(";");

                Regex dates = new Regex(@"\d{4}\-(0?[1-9]|1[012])\-(0?[1-9]|[12][0-9]|3[01])*");

                Regex years = new Regex(@"^(19|20)[0-9][0-9]");

                Regex regex = new Regex(@"\b\d+\b");

                foreach (string phrase in phrases)
                {                    
                    if (!dates.IsMatch(phrase) && !years.IsMatch(phrase))
                    {
                        MatchCollection matches = regex.Matches(phrase);

                        foreach (Match match in matches)
                        {
                            if (!years.IsMatch(match.Value))
                            {
                                if (Int32.TryParse(match.Value, out int number))
                                {
                                    sum += number;
                                }
                            }
                        }
                    }
                }
                line = read.ReadLine();
            }
            Console.WriteLine(sum);
        }
    }
}