using System;
using System.IO;

namespace _07_Product
{
    /*
        Read in a positive integer N and find the minimal positive 
        integer Q so that the product of the digits of Q is equal to N.

        Make your program as bulletproof as possible and print out 
        clear error messages, according to this list:
        - Format exception --> 'converting problem
        - Overflow exception --> 'too big for this type'
        - Any other exception --> 'crazy input'

        input:
        21
        output:
        37

        input:
        -10
        output:
        crazy input
     */
    internal class Program
    {
        static void Main(string[] args)
        {            
            try
            {
                int integer = Convert.ToInt32(Console.ReadLine());

                int product = 1;
                int n = integer;
                string numbers = "";

                if (integer > 0)
                {
                    while (product != n)
                    {
                        integer++;
                        product = 1;

                        numbers = integer.ToString();

                        foreach (char digit in numbers)
                        {
                            int number = digit - '0';

                            product *= number;
                        }
                    }
                    Console.WriteLine(numbers);
                }
                else
                {
                    Console.WriteLine("crazy input");
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
