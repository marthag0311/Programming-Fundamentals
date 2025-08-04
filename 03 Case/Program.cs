using System;

namespace _03_Case
{
    /*
        Check whether a character entered is uppercase or lowercase. In any other case you print 'crazy input'.

        input:
        A

        output:
        uppercase

        input:
        b

        output:
        lowercase
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            char character = Convert.ToChar(Console.ReadLine());

            if (Char.IsUpper(character))
            {
                Console.WriteLine("uppercase");
            }
            else if (Char.IsLower(character))
            {
                Console.WriteLine("lowercase");
            }
            else
            {
                Console.WriteLine("crazy input");
            } 
                
        }
    }
}
