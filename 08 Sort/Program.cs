using System;
using System.IO;

namespace _08_Sort
{
    /*
        Read a list of personal names (<first name> <last name>) 
        and sort them by the last name! Make your program as 
        bulletproof as possible, otherwise, print 'crazy input'

        input:
        Patty O’Furniture, Olive Yew,Aida Bugg ,Maureen Biologist,
        Teri Dactyl,Peg Legge,Allie Grater

        output:
        Maureen Biologist
        Aida Bugg
        Teri Dactyl
        Allie Grater
        Peg Legge
        Patty O’Furniture
        Olive Yew

        input:
        A. Mused,Constance Noring, Anna Dion, Lois Di Nominator

        output:
        Lois Di Nominator
        Anna Dion
        A. Mused
        Constance Noring
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] names = Console.ReadLine().Split(',');

                //FirstNameLast
                for (int i = 0; i < names.Length; i++)
                {
                    string output = "";

                    string[] parts = names[i].Trim().Split(" ");

                    for (int j = 0; j < parts.Length; j++)
                    {
                        output += parts[(j + 1) % parts.Length];

                        if (j != parts.Length - 1)
                        {
                            output += " ";
                        }
                    }
                    names[i] = output;
                }

                //Sort            
                string[] sorted = new string[names.Length];

                for (int i = 0; i < names.Length; i++)
                {
                    string temp_min = names[0];

                    foreach (string name in names)
                    {
                        if (String.Compare(name.ToLower(), temp_min.ToLower()) < 0)
                        {
                            temp_min = name;
                        }
                    }

                    sorted[i] = temp_min;

                    //Replace
                    for (int idx = 0; idx < names.Length; idx++)
                    {
                        if (names[idx] == temp_min)
                        {
                            names[idx] = "ZZZZZ";
                            break;
                        }
                    }
                }

                //FirstNameFirst
                for (int i = 0; i < sorted.Length; i++)
                {
                    string output = "";

                    string[] parts = sorted[i].Split(" ");

                    for (int j = 0; j < parts.Length; j++)
                    {
                        output += parts[(j + parts.Length - 1) % parts.Length];
                        if (j != parts.Length - 1)
                        {
                            output += " ";
                        }
                    }
                    sorted[i] = output;
                }

                foreach (string name in sorted)
                {
                    Console.WriteLine(name);
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
