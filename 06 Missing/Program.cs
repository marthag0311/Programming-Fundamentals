using System;

namespace _06_Missing
{
    /*
        Read in an array of integers and find the missing 
        number in that array.

        Note: use of Linq-library or Array-library is forbidden!

        input:
        1 3 4 2 5 6 9 8
        output:
        7

        input:
        1 7 3 4 2 5 6 9 8
        output:
        There is no missing link!
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split(' ');

            //Int to String
            int[] integers = new int[array.Length];
            for (int idx = 0; idx < array.Length; idx++)
            {
                integers[idx] = int.Parse(array[idx]);
            }

            //Array sorting
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

            //Consecutive?
            int count = integers[0];
            bool isMissing = true;

            foreach (int number in integers)
            {
                if (count != number)
                {
                    Console.WriteLine(count);
                    isMissing = false;
                    break;
                }
                count++;
            }

            if (isMissing)
            {
                Console.WriteLine("There is no missing link!");
            }


        }
    }
}
