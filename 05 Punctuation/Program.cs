using System;

namespace _05_Punctuation
{
    /*
        Read a sentence and correct the punctuation! 
        Replace symbols that occur multiple times with 
        just one instance of the same symbol! We consider 
        the following symbols as as punctuation symbols: 
        full stops (.), commas (,), question marks (?), 
        exclamation marks (!), colons (:),  hyphen (-), 
        parentheses ( () ), braces ({}), brackets ([]), 
        semi-colons (;), apostrophes (') and speech marks ("). 

        Important: use of Linq-library is forbidden!


        Input/Output
        input:
        Don'''t put all your eggs in one basket!!!
        output:
        Don't put all your eggs in one basket!

        input:
        Every cloud has a silver lining....
        output:
        Every cloud has a silver lining.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence = Console.ReadLine();

            string phrase = "";
            char temporary = 'a';


            foreach (char character in sentence)
            {
                if (character == '.' || character == ',' || character == '?' ||
                    character == '!' || character == ':' || character == '-' ||
                    character == '(' || character == ')' || character == '{' ||
                    character == '}' || character == '[' || character == ']' ||
                    character == ';' || character == '\'' || character == '\"')
                {
                    if (character != temporary)
                    {
                        phrase += character;
                        temporary = character;
                    }
                }
                else
                {
                    phrase += character;
                }
            }
            Console.WriteLine(phrase);
        }
    }
}
