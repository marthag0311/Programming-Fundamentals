using System;
using System.IO;

namespace _07_Polynomial
{
    internal class Program
    {
        static void Main(string[] args)
        {        
            try
            {
                string[] input = Console.ReadLine().Split(' ');

                if (Int32.TryParse(input[0], out int terms) &&
                    double.TryParse(input[1], out double xvalue))
                {
                    double sum = 0;
                    int index = 0;
                    while (index <= terms)
                    {
                        if (index % 2 == 0)
                        {
                            sum += Math.Pow(xvalue, index);
                        }
                        else
                        {
                            sum -= Math.Pow(xvalue, index);
                        }
                        index++;
                    }
                    Console.WriteLine($"{sum:f2}");
                }
                else
                {
                    Console.WriteLine("converting problem");
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
