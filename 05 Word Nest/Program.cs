using System;
using System.Threading;

namespace _05_Word_Nest
{
    /*
        A word nest is created by taking a starting word and 
        generating a new string by placing the word inside 
        itself. This process is then repeated.

        Nesting 3 times with the word 'incredible':
        start = incredible
        1 => incredible = incre|dible => incre|incredible|dible
        2 => increincredibledible = increin|credibledible => increin|incredible|credibledible
        3 => increinincrediblecredibledible = increinincr|ediblecredibledible => increinincr | incredible | ediblecredibledible
        final => increinincrincredibleediblecredibledible
        Read in a starting word and the final word nest and return the depth of the word nest. 

        Important: use of Linq-library is forbidden!

        input:
        floor
        floor

        output:
        0

        input:
        code
            1 => code = co|de => co|code|de
            2 => cocodede = cocod|ede => cocod|code|ede
            3 => cocodcodeede = cocodc|odeede => cocodc|code|odeede
            4 => cocodccodeodeede = cocodcco|deodeede => cocodcco|code|deodeede
            5 => cocodccocodedeodeede = cocodccoco|dedeodeede => cocodccoco|code|dedeodeede
        cocodccococodededeodeede

        output:
        5
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            string start = Console.ReadLine().ToLower();
            string final = Console.ReadLine().ToLower();

            if (start == final)
            {
                Console.WriteLine(0);
            }
            else
            {
                int count = 0;

                while (final != start)
                {
                    if (final.Contains(start))
                    {
                        count++;
                        final = final.Replace(start, "");
                    }
                }
                Console.WriteLine(count);
            }
        }
    }
}
