using System;
using System.Collections.Generic;
using System.IO;

namespace _08_Zero
{
    /*
        Read in a series of integers and find the two 
        elements whose sum is closest to zero. There 
        are no duplicates in the array. Make your program 
        as bulletproof as possible, otherwise, print 'crazy input'

        input:
        8 3 7 -5 4 -3 -9 6
        output:
        0
        3 -3

        input:
        -6 10 9 7 11 -8 -4 -3 5
        output:
        1
        -6 7
     */
    internal class Program
    {
        static void Main(string[] args)
        {      
            try
            {
                string[] input = Console.ReadLine().Split(' ');

                int[] ints = Array.ConvertAll(input, Convert.ToInt32);

                int sum = Math.Abs(ints[0] + ints[1]);
                int temp_sum = 0;
                int element1 = 0;
                int element2 = 0;

                for (int i = 0; i < ints.Length; i++)
                {
                    for (int j = 0; j < ints.Length; j++)
                    {
                        if (i != j)
                        {
                            temp_sum = ints[i] + ints[j];

                            if (temp_sum >= 0)
                            {
                                if (sum > temp_sum) //Math.Abs(sum) > Math.Abs(temp_sum)
                                {
                                    sum = temp_sum;
                                    element1 = ints[i];
                                    element2 = ints[j];
                                }
                            }                            
                        }
                    }
                }
                Console.WriteLine(sum);
                Console.WriteLine($"{element1} {element2}");
            }
            catch (FormatException)
            {
                Console.WriteLine("crazy input");
            }
            catch (OverflowException)
            {
                Console.WriteLine("crazy input");
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
                Console.WriteLine("crazy input");
            }
            catch (Exception) //(Exception ex)
            {
                Console.WriteLine("crazy input");
                //Console.WriteLine(ex.Message);
            }
        }
    }
}
