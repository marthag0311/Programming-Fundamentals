using System;
using System.Diagnostics.Tracing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace _07_Character_Sum
{
    /*
        Select words consisting only of letters  (already in CodeGrade 
        files.zip Download files.zip) with a specified character sum. 
        We determine the character sum by replacing each lovercase 
        character with its corresponding place in the alphabet 
        (a = 1, b = 2 ... z = 26). Read the file first and then the 
        asked character sum. Print each unique word that meets the 
        conditions.

        Make your program as bulletproof as possible and print out 
        clear error messages, according to this list:
        - Format exception --> 'converting problem'
        - Overflow exception --> 'too big for this type'
        - FileNotFound exception --> 'file not found'
        - Any other exception --> 'crazy input'

        input:
        BTS.txt
        125
        output:
        superhero ireumeuro cheotmudaeui surprise suspicion mystery 
        processing properly yakhanjaneun yeongsudo geollyeoon hypnosis 
        asobareteru sungseokie gwangtaeknim juungkook pleasantly 
        pronounced support prettily kikiakiteru snowflakes 
        haebwassjiman conclusion mitasareru 

        input:
        Beyonce.txt
        200
        output:
        responsibilities
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string filename = Console.ReadLine();
                string input = Console.ReadLine();

                StreamReader read = new StreamReader(filename);
                string text = read.ReadToEnd().ToLower();

                int sum = 0;
                string word = "";
                string phrase = "";

                if (Int32.TryParse(input, out int characterSum))
                {
                    foreach (char character in text)
                    {
                        if (character >= 'a' && character <= 'z')
                        {
                            word += character;
                        }
                        else
                        {
                            foreach (char element in word)
                            {
                                if (element == 'a')
                                {
                                    sum += 1;
                                }
                                else if (element == 'b')
                                {
                                    sum += 2;
                                }
                                else if (element == 'c')
                                {
                                    sum += 3;
                                }
                                else if (element == 'd')
                                {
                                    sum += 4;
                                }
                                else if (element == 'e')
                                {
                                    sum += 5;
                                }
                                else if (element == 'f')
                                {
                                    sum += 6;
                                }
                                else if (element == 'g')
                                {
                                    sum += 7;
                                }
                                else if (element == 'h')
                                {
                                    sum += 8;
                                }
                                else if (element == 'i')
                                {
                                    sum += 9;
                                }
                                else if (element == 'j')
                                {
                                    sum += 10;
                                }
                                else if (element == 'k')
                                {
                                    sum += 11;
                                }
                                else if (element == 'l')
                                {
                                    sum += 12;
                                }
                                else if (element == 'm')
                                {
                                    sum += 13;
                                }
                                else if (element == 'n')
                                {
                                    sum += 14;
                                }
                                else if (element == 'o')
                                {
                                    sum += 15;
                                }
                                else if (element == 'p')
                                {
                                    sum += 16;
                                }
                                else if (element == 'q')
                                {
                                    sum += 17;
                                }
                                else if (element == 'r')
                                {
                                    sum += 18;
                                }
                                else if (element == 's')
                                {
                                    sum += 19;
                                }
                                else if (element == 't')
                                {
                                    sum += 20;
                                }
                                else if (element == 'u')
                                {
                                    sum += 21;
                                }
                                else if (element == 'v')
                                {
                                    sum += 22;
                                }
                                else if (element == 'w')
                                {
                                    sum += 23;
                                }
                                else if (element == 'x')
                                {
                                    sum += 24;
                                }
                                else if (element == 'y')
                                {
                                    sum += 25;
                                }
                                else if (element == 'z')
                                {
                                    sum += 26;
                                }
                            }

                            if (sum == characterSum)
                            {
                                phrase += word + " ";
                            }

                            word = "";
                            sum = 0;
                        }
                    }

                    int index = 0;
                    string[] notunique = phrase.Split(' ');
                    string[] unique = new string[notunique.Length];

                    for (int i = 0; i < notunique.Length; i++)
                    {
                        if (!unique.Contains(notunique[i]))
                        {
                            unique[index] = notunique[i];
                            index++;
                        }
                    }

                    foreach (string item in unique)
                    {
                        Console.Write(item + " ");
                    }

                }
                else
                {
                    Console.WriteLine("converting problem");
                }

                read.Close();
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
                Console.WriteLine("file not found");
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
