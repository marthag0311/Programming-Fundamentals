using System;
using System.Collections.Generic;

namespace _03_Even
{
    /*
        Read in three integers and take the sum of only the even numbers.

        input:
        23
        78
        10

        output:
        88

        input:
        13
        -10
        7

        output:
        -10
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            string answer = Console.ReadLine();
            string input = Console.ReadLine();
            string read = Console.ReadLine();

            List<int> numbers = new List<int>();

            if (Int32.TryParse(answer, out int number1) &&
                Int32.TryParse(input, out int number2) &&
                Int32.TryParse(read, out int number3))
            {
                numbers.Add(number1);
                numbers.Add(number2);
                numbers.Add(number3);

                int sum = 0;

                foreach (int number in numbers)
                {
                    if (number % 2 == 0)
                    {
                        sum += number;
                    }
                }

                Console.WriteLine(sum);
            }
            else
            {
                Console.WriteLine("crazy input");
            }
        }
    }
}
