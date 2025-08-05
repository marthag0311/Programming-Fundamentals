using System;
using System.IO;

namespace _07_Multiplication
{
    /*
        Matrix multiplication is a lot of math, so ideal for 
        programming ;) You first get the dimensions of the two 
        matrices, so you can use them to read and multiply the 
        matrices themselves. Not familiar with matrix 
        multiplication? Check out this website Links to an 
        external site.for some instructions.

        Make your program as bulletproof as possible and print 
        out clear error messages, according to this list:
        - The number of columns in first matrix is not equal to the number of rows in the second matrix --> 'wrong dimensions'
        - Index out of range exception --> 'index out of range'
        - Format exception --> 'converting problem'
        - Overflow exception --> 'too big for this type'
        - Any other exception --> 'crazy input'

        input:
        2x3 3x2
        1 2 3
        4 5 6
        7 8
        9 10
        11 12

        output:
        58 64 
        139 154 


        input:
        2x2 3x2
        1 2
        4 5
        7 8
        9 10
        11 12

        output:
        check your dimensions
     */
    internal class Program
    {
        static void Main(string[] args)
        {    
            try
            {
                string[] input = Console.ReadLine().Split(' ');

                string[] dimensions1 = input[0].Split('x');
                string[] dimensions2 = input[1].Split('x');

                int[] dims1 = new int[dimensions1.Length];
                for (int i = 0; i < dimensions1.Length; i++)
                {
                    dims1[i] = int.Parse(dimensions1[i]);
                }
                int[] dims2 = new int[dimensions2.Length];
                for (int i = 0; i < dimensions2.Length; i++)
                {
                    dims2[i] = int.Parse(dimensions2[i]);
                }

                int row1 = dims1[0]; int column1 = dims1[1];
                int row2 = dims2[0]; int column2 = dims2[1];

                if (column1 == row2)
                {
                    int[,] matrix1 = new int[row1, column1];
                    for (int i = 0; i < row1; i++)
                    {
                        input = Console.ReadLine().Split(' ');

                        int[] array = Array.ConvertAll(input, Convert.ToInt32);

                        for (int j = 0; j < column1; j++)
                        {
                            matrix1[i, j] = array[j];
                        }
                    }

                    int[,] matrix2 = new int[row2, column2];
                    for (int i = 0; i < row2; i++)
                    {
                        input = Console.ReadLine().Split(' ');

                        int[] array = Array.ConvertAll(input, Convert.ToInt32);

                        for (int j = 0; j < column2; j++)
                        {
                            matrix2[i, j] = array[j];
                        }
                    }

                    int sum = 0;

                    for (int i = 0; i < matrix1.GetLength(0); i++)
                    {
                        int index = 0;

                        while (index < column2)
                        {
                            for (int j = 0; j < matrix2.GetLength(0); j++)
                            {
                                sum += matrix1[i, j] * matrix2[j, index];
                            }
                            Console.Write(sum + " ");

                            sum = 0;
                            index++;
                        }
                        Console.WriteLine();
                    }

                }
                else
                {
                    Console.WriteLine("check your dimensions");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("converting problem");
            }
            catch (OverflowException)
            {
                Console.WriteLine("too big for this type");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("crazy input");
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
