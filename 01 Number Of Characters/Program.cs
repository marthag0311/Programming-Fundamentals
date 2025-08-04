using System;

namespace Number_of_characters
{
    /*
        Read the name of a person and print '<name>, your name has <number> characters'.

        Input/Output
        input:
        Elke
        output:
        Elke, your name has 4 characters

        input:
        Tristan
        output:
        Tristan, your name has 7 characters
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine().ToLower();

            int count = 0;
            for (int i = 0; i < name.Length; i++)
            {
                if (name[i] >= 'a' && name[i] <= 'z')
                {
                    count++;
                }
            }
            Console.WriteLine($"{name}, your name has {count} characters");
        }
    }
}
