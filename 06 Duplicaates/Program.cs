using System;
using System.Collections.Generic;

namespace _06_Duplicaates
{
    /*
        Read in an array of integers and count the total number of 
        duplicate elements in an array.

        Note: use of Linq - library or Array - library is forbidden!

        input:
        5 5 8 9 10
        output:
        1

        input:
        6 5 4 2 1
        output:
        0
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            int[] integers = new int[input.Length];

            for (int i = 0; i < input.Length;i++)
            {
                integers[i] = int.Parse(input[i]);
            }

            for (int i = 0; i < integers.Length; i++)
            {
                for (int j = 0; j < integers.Length; j++)
                {
                    int temporary = integers[i];
                    integers[i] = integers[j];
                    integers[j] = temporary;
                }
            }

            int count = 0;
            /*int tempo = integers[0];
            foreach (int number in integers) 4 4 4 4 2 2
            {
                if (tempo == number)
                {
                    count++;
                }
                tempo = number;
            }*/

            List<int> unique = new List<int>();
            
            foreach (int number in integers)
            {
                if (!unique.Contains(number))
                {
                    unique.Add(number);
                }
                else
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}