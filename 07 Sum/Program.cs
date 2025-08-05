using System;
using System.IO;

namespace _07_Sum
{
    /*
        Read in an integer N and find the sum of all squared integers between 1 and N (exclusive).

Make your program as bulletproof as possible and print out clear error messages, according to this list:
- Format exception --> 'converting problem
- Overflow exception --> 'too big for this type'
- Any other exception --> 'crazy input'

 

Input/Output
input:
10
output:
285

input:
-3
output:
5
     */
    internal class Program
    {
        static void Main(string[] args)
        {            
            try
            {
                int number = Convert.ToInt32(Console.ReadLine());

                int sum = 0;

                if (number < 1)
                {
                    for (int i = number + 1; i < 1; i++)
                    {
                        int squared = (int)(Math.Pow(i, 2));

                        sum += squared;
                    }
                    Console.WriteLine(sum);
                }
                else
                {
                    for (int i = 1; i < number; i++)
                    {
                        int squared = (int)(Math.Pow(i, 2));

                        sum += squared;
                    }
                    Console.WriteLine(sum);
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
