using System;
using System.Linq.Expressions;

namespace _04_Prime_Numbers
{
    /*
        Read in a number n and print all prime numbers between 2 and n. 
        (when n < 2 print out 'crazy input'). A prime number is an 
        integer larger than 1, which has only 2 divisors: 1 and itself.

        https://en.wikipedia.org/wiki/Prime_numberLinks to an external 
        site.

        input:
        10
        output:
        2 3 5 7 

        input:
        -1
        output:
        crazy input
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            if (Int32.TryParse(input, out int number))
            {
                if (number < 2)
                {
                    Console.WriteLine("crazy input");
                }
                else
                {
                    bool isPrime = true;

                    for (int num = 2; num <= number; num++)
                    {
                        for (int i = 2; i < num; i++)
                        {
                            if (num % i == 0)
                            {
                                isPrime = false;
                                break;
                            }
                        }

                        if (isPrime)
                        {
                            Console.Write(num + " ");
                        }
                        isPrime = true;
                    }

                    //////////// OR ///////////////

                    /*
                    int count = 0; 

                    for (int num = 2; num <= number; num++)
                    {
                        for (int i = 1; i <= num; i++)
                        {
                            int result = num % i;
                            if (result == 0)
                            {
                                count++;
                            }
                        }

                        if (count <= 2)
                        {
                            Console.Write(num + " ");
                        }
                        count = 0;
                    }*/
                }
            }
            else
            {
                Console.WriteLine("crazy input");
            }
        }
    }
}
