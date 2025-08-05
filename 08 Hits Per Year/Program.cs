using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _08_Hits_Per_Year
{
    /*
        Read in an artist file (download files: files.zip Download files.zip, files already in CodeGrade)  and print the number of hits the artist had per year. Make your program as bulletproof as possible, otherwise, print 'crazy input'

        input:
        KatyPerry.txt
        output:
        2001: 10 hit(s)
        2005: 1 hit(s)
        2007: 4 hit(s)
        2008: 20 hit(s)
        2009: 20 hit(s)
        2010: 20 hit(s)
        2011: 16 hit(s)
        2012: 7 hit(s)
        2013: 17 hit(s)
        2014: 8 hit(s)
        2015: 5 hit(s)
        2016: 4 hit(s)
        2017: 29 hit(s)
        2018: 5 hit(s)
        2019: 12 hit(s)
        2020: 29 hit(s)
        2021: 1 hit(s)
        2022: 1 hit(s)

        input:
        TaylorSwift.txt
        output:
        1989: 13 hit(s)
        2000: 1 hit(s)
        2002: 1 hit(s)
        2004: 1 hit(s)
        2005: 1 hit(s)
        2006: 13 hit(s)
        2007: 14 hit(s)
        2008: 34 hit(s)
        2009: 11 hit(s)
        2010: 14 hit(s)
        2011: 35 hit(s)
        2012: 28 hit(s)
        2013: 4 hit(s)
        2014: 5 hit(s)
        2015: 9 hit(s)
        2016: 3 hit(s)
        2017: 24 hit(s)
        2018: 16 hit(s)
        2019: 36 hit(s)
        2020: 72 hit(s)
        2021: 2 hit(s)
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string filename = Console.ReadLine();

                StreamReader read = new StreamReader(filename);
                string line = read.ReadLine();

                Dictionary<int, int> hits = new Dictionary<int, int>();
                while (line != null)
                {
                    string[] array = line.Split(';');

                    for (int i = 0; i < array.Length; i++)
                    {
                        if (i == 3)
                        {
                            if (Int32.TryParse(array[i], out int year))
                            {
                                if (!hits.ContainsKey(year))
                                {
                                    hits.Add(year, 1);

                                }
                                else
                                {
                                    hits[year]++;
                                }
                            }
                        }                        
                    }
                    line = read.ReadLine();
                }

                foreach (var pair in hits.OrderBy(key => key.Key)) // sort by Value = OrderBy(value => value.Value)
                {
                    Console.WriteLine($"{pair.Key}: {pair.Value} hit(s)");
                }

                read.Close();
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
