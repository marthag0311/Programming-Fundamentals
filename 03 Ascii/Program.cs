using System;

namespace _03_Ascii
{
    /*
        Read in a number and check if the corresponding ASCII character is an alfa character (a-z,A-Z). If so, print out the alfa character, if not print closest (in ASCII table) alfa character.

        input:
        66
        output:
        B

        input:
        93
        output:
        Z
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            string answer = Console.ReadLine();

            if (Int32.TryParse(answer, out int number))
            {
                char character = (char)number;

                int countForward = 0;
                int countBackward = 0;
                char characterForward = character;
                char characterBackward = character;

                if (character >= 'a' && character <= 'z' || 
                    character >= 'A' && character <= 'Z')
                {
                    Console.WriteLine(character);
                }
                else
                {
                    while (!(characterForward >= 'a' && characterForward <= 'z' ||
                    characterForward >= 'A' && characterForward <= 'Z'))
                    {
                        number = number + 1;

                        characterForward = (char)number;
                        countForward++;
                    }

                    while (!(characterBackward >= 'a' && characterBackward <= 'z' ||
                        characterBackward >= 'A' && characterBackward <= 'Z'))
                    {
                        number = number - 1;

                        characterBackward = (char)number;
                        countBackward++;
                    }

                    if (countForward > countBackward)
                    {
                        Console.WriteLine(characterForward);
                    }
                    else
                    {
                        Console.WriteLine(characterBackward);
                    }
                }

                

            }
        }
    }
}
