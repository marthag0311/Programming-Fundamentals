using System;

namespace _04_Next_Fibonacci
{
    /*
        Read a Fibonacci number and find the next Fibonacci number. 
        The Fibonacci sequence is a series of numbers: 
        0, 1, 1, 2, 3, 5, 8, 13, 21, 34, ... where the following 
        number is found by adding up the two numbers before it:

        - 2 is found by adding the two numbers before it (1 + 1), 
        - 3 is found by adding the two numbers before it (1 + 2), 
        - 5 is (2 + 3), and so on!

        input:
        13
        output:
        21

        input:
        610
        output:
        987
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            if (Int32.TryParse(input, out int number))
            {
                int nextFibonacci = 0;
                int first = 0;
                int second = 1;
                                
                while (nextFibonacci != number)
                {
                    nextFibonacci = first + second;// 0 1, 

                    first = second; //1
                    second = nextFibonacci; //1
                }

                nextFibonacci = first + second;
                Console.WriteLine(nextFibonacci);

            }
            else
            {
                Console.WriteLine("crazy input");
            }
        }
    }
}
