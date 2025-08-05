using System;

namespace _06_Second
{
    /*
        Read in an array of numbers (separated by a space), and find 
        the second largest element.

        Note: use of Linq-library or Array-library is forbidden!

        input:
        6 2 18 17 18 17 18 15 17 2 4 12 18 18 18
        output:
        17

        input:
        16 11 17 7 2 17 17 17 17 17 16 16 16
        output:
        16
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split(' ');

            int[] integers = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                integers[i] = int.Parse(array[i]);
            }

            for (int i = 0; i < integers.Length; i++)
            {
                for (int j = i; j < integers.Length; j++)
                {
                    if (integers[j] < integers[i])
                    {
                        int temporary = integers[i];
                        integers[i] = integers[j];
                        integers[j] = temporary;
                    }
                }
            }

            int last = 0;
            int second = 0;

            for (int i = 0; i < integers.Length; i++)
            {
                if (last < integers[i])
                {
                    /*if (second != last)
                    {
                        second = last;
                    }*/
                    second = last;
                    last = integers[i];
                }
            }

            /*int tempo = 0;
            List<int> unique = new List<int>();

            for (int i = 0; i < integers.Length; i++)
            {
                if (tempo != integers[i])
                {
                    unique.Add(integers[i]);
                }
                tempo = integers[i];
            }*/

            Console.WriteLine(second);
        }
    }
}
