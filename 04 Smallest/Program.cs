using System;
using System.Collections.Generic;

namespace _04_Smallest
{
    /*
        Read in a series of numbers (stop when you reach 'X') 
        and print out the smallest element.

        input:
        1
        3
        -1
        100
        X

        output:
        -1

        input:
        6
        1
        0
        X

        output:
        0
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<double> numbers = new List<double>();

            //////////////DO WHILE LOOP////////////
            do
            {
                numbers.Add(Convert.ToDouble(input));

                input = Console.ReadLine();
            }
            while (input.ToLower() != "x");

            double temp = numbers[0];
            for (int i = 0; i < numbers.Count; i++)
            {
                if (temp > numbers[i])
                {
                    temp = numbers[i];
                }
            }
                        Console.WriteLine(temp);

            //////////////// WHILE LOOP/////////////
            /*while (input.ToLower() != "x")
            {
                numbers.Add(Convert.ToDouble(input));

                input = Console.ReadLine();
            }
            numbers.Sort();

            Console.WriteLine(numbers[0]);*/
        }
    }
}
