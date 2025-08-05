using System;

namespace _04_Sequence
{
    /*
        Read in two alphabetic characters, where the first one 
        occurs before the second one in the alphabet (otherwise, 
        print 'crazy input'). Print out the complete sequence of 
        consonants between the first and second one (including bounds).

        input:
        a
        t

        output:
        bcdfghjklmnpqrst

        input:
        P
        B

        output:
        crazy input
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            char character1 = Convert.ToChar(Console.ReadLine().ToLower());
            char character2 = Convert.ToChar(Console.ReadLine().ToLower());

            if (character1 <= character2)
            {
                for (char i = character1; i <= character2; i++)
                {
                    if (i == 'b' || i == 'c' || i == 'd' ||
                        i == 'f' || i == 'g' || i == 'h' ||
                        i == 'j' || i == 'k' || i == 'l' ||
                        i == 'm' || i == 'n' || i == 'y' ||
                        i == 'p' || i == 'q' || i == 'r' ||
                        i == 's' || i == 't' || i == 'v' ||
                        i == 'w' || i == 'x' || i == 'z' )
                    {
                        Console.Write(i);
                    }                    
                }
            }
            else
            {
                Console.WriteLine("crazy input");
            } 
                
        }
    }
}
