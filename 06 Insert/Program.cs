using System;
using System.Collections.Generic;
using System.Globalization;

namespace _06_Insert
{
    /*
        Read in a sorted array and a value. Insert the value 
        in the right place and print out the new array.

        Note: use of Linq-library or Array-library is forbidden!

        input:
        1 2 3 4 6 7
        5

        output:
        1 2 3 4 5 6 7 

        input:
        -1 0 2 5 7 10
        -4

        output:
        -4 -1 0 2 5 7 10 
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split(' ');
            double value = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            double[] doubles = new double[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                doubles[i] = double.Parse(array[i]);
            }

            List<double> insert = new List<double>();

            if (value <= doubles[0])
            {
                insert.Add(value);

                foreach (double number in doubles)
                {
                    insert.Add(number);
                }
            }
            else if ((value >= doubles[doubles.Length - 1]))
            {
                foreach (double number in doubles)
                {
                    insert.Add(number);
                }
                insert.Add(value);
            }
            else
            {
                for (int i = 0; i < doubles.Length; i++)
                {
                    if (value > doubles[i] && value < doubles[i + 1])
                    {
                        insert.Add(doubles[i]);
                        insert.Add(value);                        
                    }
                    else
                    {
                        insert.Add(doubles[i]);
                    }    
                }
            }

            foreach (double number in insert)
            {
                Console.Write(number + " ");
            }

        }
    }
}
