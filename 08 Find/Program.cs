using System;
using System.Globalization;
using System.IO;

namespace _08_Find
{
    /*
        Find all duck numbers from a sequence and print them out in sorted order. A duck number is a number that contains a 0 in (but not starts with a 0!). Make your program as bulletproof as possible, otherwise, print 'crazy input'.

        input:
        apple,8.09,90,1,2,3.5,7
        output:
        8.09 90

        input:
        1,02,apple,1,12.03,this is true,true,8
        output:
        12.03  
     */
    internal class Program
    {
        static void Main(string[] args)
        {            
            try
            {
                string[] input = Console.ReadLine().Split(',');

                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i].Contains(' '))
                    {
                        string[] array = input[i].Split(' ');

                        foreach(string item in array)
                        {
                            if (!item.StartsWith('0') &&
                            item.Contains('0'))
                            {
                                double number = Convert.ToDouble(item, CultureInfo.InvariantCulture);
                                Console.Write(number + " ");
                            }
                        }
                    }
                    else
                    {
                        if (!input[i].StartsWith('0') &&
                            input[i].Contains('0'))
                        {
                            double number = Convert.ToDouble(input[i], CultureInfo.InvariantCulture);
                            Console.Write(number + " ");
                        }
                    }
                }
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
