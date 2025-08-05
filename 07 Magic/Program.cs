using System;
using System.IO;

namespace _07_Magic
{
    /*
        Read a 2D array and calculate the sum per column. If all 
        sums are equal, you are dealing with a magic matrix! The 
        first number to read is the number of rows, after that you 
        can just read in every row!

        Make your program as bulletproof as possible and print out 
        the right message according to this list:
        - IndexOutOfRangeException: index out of range
        - DivideByZeroException: don't divide by zero!
        - FormatException: not the right format
        - OverflowException: just too much
        - Any other exception: crazy input

        input:
        3
        2 7 0
        8 4 1
        1 0 10
        output:
        It's magic! 
        explanation
        2 + 8 + 1 = 11
        7 + 4 + 0 = 11
        0 + 1 + 10 = 11
        all columns have a sum of 11 so 'it's magic'

        input:
        2
        11 11 18 15 2
        13 13 1 4 6
        output:
        No magic here!
     */
    internal class Program
    {
        static void Main(string[] args)
        {            
            try
            {
                int rows = Convert.ToInt32(Console.ReadLine());

                int columns = 0;

                int[,] array2D = new int[rows, columns];

                for (int i = 0; i < rows; i++)
                {
                    string[] inputLine = Console.ReadLine().Split(" ");

                    if (columns == 0)
                    {
                        columns = inputLine.Length;
                        array2D = new int[rows, columns];
                    }

                    for (int j = 0; j < columns; j++)
                    {
                        array2D[i, j] = Convert.ToInt32(inputLine[j]);
                    }
                }
                int sum = 0;
                int[] sums = new int[columns];

                for (int i = 0; i < array2D.GetLength(1); i++)
                {
                    for (int j = 0; j < array2D.GetLength(0); j++)
                    {
                        sum += array2D[j, i];
                    }
                    sums[i] = sum;
                    sum = 0;
                }

                bool isEqual = true;

                for (int i = 0; i < sums.Length - 1; i++)
                {
                    if (sums[i] != sums[i + 1])
                    {
                        isEqual = false;
                        break;
                    }
                }

                if (isEqual)
                {
                    Console.WriteLine("It's magic!");
                }
                else
                {
                    Console.WriteLine("No magic here!");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("not the right format");
            }
            catch (OverflowException)
            {
                Console.WriteLine("just too much");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("don't divide by zero!");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("crazy input");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("index out of range");
            }
            catch (Exception) //(Exception ex)
            {
                Console.WriteLine("crazy input");
                //Console.WriteLine(ex.Message);
            }

        }
    }
}
