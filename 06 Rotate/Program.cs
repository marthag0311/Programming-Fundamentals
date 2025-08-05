using System;

namespace _06_Rotate
{
    /*
        Read in an array of integers and rotate it a specified 
        number (never greater than array length!) of places to the left.

        Note: use of Linq - library or Array-library is forbidden!
        Hint: write it down, and calculate new indices of every element!

        input:
        15 5 8 19 9 10
        1

        output:
        5 8 19 9 10 15

        input:
        11 4 12 17 18 7 8 16
        2

        output:
        12 17 18 7 8 16 11 4     
        
        Method 1 
            - Store array[0] in a temporary variable "temporary"
            - Move array[1] to array[0], array[2] to array[1], ...
            - And finally "temporary" to array[0]/array[ints.Length - 1]

        Method 2 = Using temporary array
            - Input array[] = [1, 2, 3, 4, 5], number = 2, ints.Length = 7
            - Store "number" elements in a temp array
                - temporary[] = [1, 2]
            - Shift rest of the array[]
                - array[] = [3, 4, 5]
            - Store back the "number" elements
                - array[] = [3, 4, 5, 1, 2]
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            string answer = Console.ReadLine();

            if (Int32.TryParse(answer, out int number))
            {
                int[] integers = new int[input.Length];

                for (int i = 0; i < input.Length; i++)
                {
                    integers[i] = int.Parse(input[i]);
                }

                if (number >= 0 && number < input.Length)
                {                 
                    for (int i = 0; i < number; i++)
                    {
                        int temporary = integers[0];
                        for (int j = 0; j < integers.Length; j++)
                        {
                            if (j == integers.Length - 1)
                            {
                                integers[j] = temporary; 
                            }
                            else
                            {
                                integers[j] = integers[j + 1];
                            }
                        }
                    }

                    foreach (int num in integers)
                    {
                        Console.Write(num + " ");
                    }
                }
                else if (number < 0)
                {
                    for (int i = number; i < 0; i++)
                    {
                        int temporary = integers[integers.Length - 1];
                        for (int j = integers.Length - 1; j >= 0; j--)
                        {
                            if (j == 0)
                            {
                                integers[j] = temporary;
                            }
                            else
                            {
                                integers[j] = integers[j - 1];
                            }
                        }
                    }

                    foreach (int num in integers)
                    {
                        Console.Write(num + " ");
                    }
                }
                else
                {
                    Console.WriteLine("crazy input");
                }
            }
            else
            {
                Console.WriteLine("crazy input");
            }
        }
    }
}
