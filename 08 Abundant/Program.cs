using System;
using System.Collections.Generic;
using System.IO;

namespace _08_Abundant
{
    /*
        Find all abundant numbers between two given inclusive 
        limits. An abundant number is a number for which the 
        sum of its proper divisors (1 included) is greater 
        than the number itself. Group the numbers by the first 
        digit and print them out. Make your program as bulletproof 
        as possible, otherwise, print 'crazy input'

        input:
        1 120
        output:
        12 18 100 102 104 108 112 114 120 
        20 24 
        30 36 
        40 42 48 
        54 56 
        60 66 
        70 72 78 
        80 84 88 
        90 96 


        input:
        250 2
        output:
        12 18 100 102 104 108 112 114 120 126 132 138 140 144 150 156 160 162 168 174 176 180 186 192 196 198 
        20 24 200 204 208 210 216 220 222 224 228 234 240 246 
        30 36 
        40 42 48 
        54 56 
        60 66 
        70 72 78 
        80 84 88 
        90 96 
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] input = Console.ReadLine().Split(' ');

                int[] ints = Array.ConvertAll(input, Convert.ToInt32);

                int start = ints[0];
                int end = ints[1];

                int sum = 0;
                List<int> abundants = new List<int>();
                List<int> one = new List<int>();
                List<int> two = new List<int>();
                List<int> three = new List<int>();
                List<int> four = new List<int>();
                List<int> five = new List<int>();
                List<int> six = new List<int>();
                List<int> seven = new List<int>();
                List<int> eight = new List<int>();
                List<int> nine = new List<int>();

                if (start < end)
                {
                    for (int i = start; i <= end; i++)
                    {
                        for (int j = 1; j < i; j++)
                        {
                            if (i % j == 0)
                            {
                                sum += j;
                            }
                        }

                        if (sum > i)
                        {
                            if (i.ToString().StartsWith('1'))
                            {
                                one.Add(i);
                            }
                            else if (i.ToString().StartsWith('2'))
                            {
                                two.Add(i);
                            }
                            else if (i.ToString().StartsWith('3'))
                            {
                                three.Add(i);
                            }
                            else if (i.ToString().StartsWith('4'))
                            {
                                four.Add(i);
                            }
                            else if (i.ToString().StartsWith('5'))
                            {
                                five.Add(i);
                            }
                            else if (i.ToString().StartsWith('6'))
                            {
                                six.Add(i);
                            }
                            else if (i.ToString().StartsWith('7'))
                            {
                                seven.Add(i);
                            }
                            else if (i.ToString().StartsWith('8'))
                            {
                                eight.Add(i);
                            }
                            else if (i.ToString().StartsWith('9'))
                            {
                                nine.Add(i);
                            }
                        }
                        sum = 0;
                    }

                    if (one.Count != 0)
                    {
                        foreach (int i in one)
                        {
                            Console.Write(i + " ");
                        }
                        Console.WriteLine();
                    }
                    if (two.Count != 0)
                    {
                        foreach (int i in two)
                        {
                            Console.Write(i + " ");
                        }
                        Console.WriteLine();
                    }
                    if (three.Count != 0)
                    {
                        foreach (int i in three)
                        {
                            Console.Write(i + " ");
                        }
                        Console.WriteLine();
                    }
                    if (four.Count != 0)
                    {
                        foreach (int i in four)
                        {
                            Console.Write(i + " ");
                        }
                        Console.WriteLine();
                    }
                    if (five.Count != 0)
                    {
                        foreach (int i in five)
                        {
                            Console.Write(i + " ");
                        }
                        Console.WriteLine();
                    }
                    if (six.Count != 0)
                    {
                        foreach (int i in six)
                        {
                            Console.Write(i + " ");
                        }
                        Console.WriteLine();
                    }
                    if (seven.Count != 0)
                    {
                        foreach (int i in seven)
                        {
                            Console.Write(i + " ");
                        }
                        Console.WriteLine();
                    }
                    if (eight.Count != 0)
                    {
                        foreach (int i in eight)
                        {
                            Console.Write(i + " ");
                        }
                        Console.WriteLine();
                    }
                    if (nine.Count != 0)
                    {
                        foreach (int i in nine)
                        {
                            Console.Write(i + " ");
                        }
                    }
                }
                else
                {
                    for (int i = end; i <= start; i++)
                    {
                        for (int j = 1; j < i; j++)
                        {
                            if (i % j == 0)
                            {
                                sum += j;
                            }
                        }

                        if (sum > i)
                        {
                            if (i.ToString().StartsWith('1'))
                            {
                                one.Add(i);
                            }
                            else if (i.ToString().StartsWith('2'))
                            {
                                two.Add(i);
                            }
                            else if (i.ToString().StartsWith('3'))
                            {
                                three.Add(i);
                            }
                            else if (i.ToString().StartsWith('4'))
                            {
                                four.Add(i);
                            }
                            else if (i.ToString().StartsWith('5'))
                            {
                                five.Add(i);
                            }
                            else if (i.ToString().StartsWith('6'))
                            {
                                six.Add(i);
                            }
                            else if (i.ToString().StartsWith('7'))
                            {
                                seven.Add(i);
                            }
                            else if (i.ToString().StartsWith('8'))
                            {
                                eight.Add(i);
                            }
                            else if (i.ToString().StartsWith('9'))
                            {
                                nine.Add(i);
                            }
                        }
                        sum = 0;
                    }

                    if (one.Count != 0)
                    {
                        foreach (int i in one)
                        {
                            Console.Write(i + " ");
                        }
                        Console.WriteLine();
                    }
                    if (two.Count != 0)
                    {
                        foreach (int i in two)
                        {
                            Console.Write(i + " ");
                        }
                        Console.WriteLine();
                    }
                    if (three.Count != 0)
                    {
                        foreach (int i in three)
                        {
                            Console.Write(i + " ");
                        }
                        Console.WriteLine();
                    }
                    if (four.Count != 0)
                    {
                        foreach (int i in four)
                        {
                            Console.Write(i + " ");
                        }
                        Console.WriteLine();
                    }
                    if (five.Count != 0)
                    {
                        foreach (int i in five)
                        {
                            Console.Write(i + " ");
                        }
                        Console.WriteLine();
                    }
                    if (six.Count != 0)
                    {
                        foreach (int i in six)
                        {
                            Console.Write(i + " ");
                        }
                        Console.WriteLine();
                    }
                    if (seven.Count != 0)
                    {
                        foreach (int i in seven)
                        {
                            Console.Write(i + " ");
                        }
                        Console.WriteLine();
                    }
                    if (eight.Count != 0)
                    {
                        foreach (int i in eight)
                        {
                            Console.Write(i + " ");
                        }
                        Console.WriteLine();
                    }
                    if (nine.Count != 0)
                    {
                        foreach (int i in nine)
                        {
                            Console.Write(i + " ");
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
