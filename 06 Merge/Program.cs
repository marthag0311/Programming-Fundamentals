using System;
using System.Globalization;

namespace _06_Merge
{
    /*
        Read in two arrays and merge them together in 
        descending order. Print out the new array.

        input:
        5 5 8
        9 10

        output:
        10 9 8 5 5

        input:
        6 5 4 2 1
        6 5 4 3 2 1

        output:
        6 6 5 5 4 4 3 2 2 1 1
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            string[] intake = Console.ReadLine().Split(' ');

            //String to Int
            int[] ints = new int[input.Length];
            int[] integers = new int[intake.Length];

            for (int i = 0; i < input.Length; i++)
            {
                ints[i] = int.Parse(input[i]);
            }
            for (int i = 0; i < intake.Length; i++)
            {
                integers[i] = int.Parse(intake[i]);
            }

            //Merge
            int[] array = new int[ints.Length + integers.Length];

            Array.Copy(ints, array, ints.Length);
            Array.Copy(integers, 0, array, ints.Length, integers.Length);

            //Sorting
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i; j < array.Length; j++)
                {
                    if (array[j] < array[i])
                    {
                        int temporary = array[i];
                        array[i] = array[j];
                        array[j] = temporary;
                    }
                }
            }

            //Print
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[array.Length - 1 - i] + " ");
            }
        }
    }
}
