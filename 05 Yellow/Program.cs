using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;

namespace _05_Yellow
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            int integer = Convert.ToInt32(Console.ReadLine(), 16);
                        
            Color corresponding = ColorTranslator.FromOle(integer);
            var color = corresponding.ToKnownColor();

            if (color == 0)
            {
                Console.WriteLine("It was just colorless");
            }
            else
            {
                StreamReader read = new StreamReader("ColdPlay.txt");
                string text = read.ReadToEnd().ToLower();

                Regex rx = new Regex($@"{color}", RegexOptions.IgnoreCase);
                MatchCollection occurrences = rx.Matches(text);

                if (occurrences.Count == 0)
                {
                    Console.WriteLine($"It wasn't {color} at all");
                }
                else
                {
                    Console.WriteLine($"It was all {color} ({occurrences.Count} matches)");
                }
                read.Close();
            }
        }
    }
}
