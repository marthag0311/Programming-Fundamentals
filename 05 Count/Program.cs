using System;

namespace _05_Count
{

    /*
        Read in a string and count the vowels, consonants, 
        digits, and other characters (exclude spaces!).

        Important: use of Linq-library is forbidden!

        input:
        Don't put all your eggs in 1 basket!

        output:
        consonants: 17
        vowels: 9
        digits: 1
        other: 2

        input:
        Every cloud has a silver lining.

        output:
        consonants: 16
        vowels: 10
        digits: 0
        other: 1
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            string phrase = Console.ReadLine().ToLower();

            int consonants = 0;
            int vowels = 0;
            int digits = 0;
            int other = 0;

            for (int i = 0; i < phrase.Length; i++)
            {
                if (phrase[i] >= 'a' && phrase[i] <= 'z')
                {
                    if (phrase[i] == 'a' || phrase[i] == 'e' ||
                        phrase[i] == 'i' || phrase[i] == 'o' ||
                        phrase[i] == 'u')
                    {
                        vowels++;
                    }
                    else
                    {
                        consonants++;
                    }
                }  
                else if (phrase[i] >= '0' && phrase[i] <= '9')
                {
                    digits++;
                }
                else if (phrase[i] != ' ')
                {
                    other++;
                }
            }

            Console.WriteLine("consonants: " + consonants);
            Console.WriteLine("vowels: " + vowels);
            Console.WriteLine("digits: " + digits);
            Console.WriteLine("other: " + other);
        }
    }
}
