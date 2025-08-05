using System;
using System.IO;
using System.Text;

namespace _07_Polybius
{
    /*
        Read a secret message and decode it according to the 
        Polybius square Links to an external site.. The Polybius 
        square (developed by the Greek historian Polybius) is a 
        way of encoding messages using a square in which the 
        characters of the alphabet are replaced by numbers:

               1   2   3   4   5
           1   A   B   C   D   E
           2   F   G   H   I   J
           3   K   L   M   N   O
           4   P   Q   R   S   T
           5   U   V   W   X   Y and Z is coded as an S.

        eg: 12 11 45 becomes BAT.

        Make your program as bulletproof as possible and print 
        out the right message according to this list:
        - IndexOutOfRangeException: index out of range
        - DivideByZeroException: don't divide by zero!
        - FormatException: not the right format
        - OverflowException: just too much
        - Any other exception: crazy input

        input:
        14 15 13 35 14 15 41 35 32 55 12 24 51 44
        output:
        D E C O D E P O L Y B I U S 

        input:
        14 75 13 35 14 15
        output:
        index out of range
     */
    internal class Program
    {
        static void Main(string[] args)
        {     
            try
            {
                string[] message = Console.ReadLine().Split(' ');

                char[,] polybiusquare = { { 'A', 'B', 'C', 'D', 'E' },
                                          { 'F', 'G', 'H', 'I', 'J' },
                                          { 'K', 'L', 'M', 'N', 'O' },
                                          { 'P', 'Q', 'R', 'S', 'T' },
                                          { 'U', 'V', 'W', 'X', 'Y' }};

                string decoded = "";

                for (int i = 0; i < message.Length; i++)
                {
                    char[] characters = message[i].ToCharArray();

                    int row = characters[0] - '0';
                    int column = characters[1] - '0';

                    decoded += polybiusquare[row - 1, column - 1] + " ";
                }
                Console.WriteLine(decoded);
            }
            catch (FormatException)
            {
                Console.WriteLine("not the right format");
            }
            catch (OverflowException)
            {
                Console.WriteLine("just too much");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("don't divide by zero!");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("crazy input");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("index out of range");
            }
            catch (Exception) //(Exception ex)
            {
                Console.WriteLine("crazy input");
                //Console.WriteLine(ex.Message);
            }
        }
    }
}
