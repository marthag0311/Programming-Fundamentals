using System;
using System.IO;

namespace _07_Caesar
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            try
            {
                string input = Console.ReadLine();
                string message = Console.ReadLine().ToUpper();

                bool isAlphabet = true;

                foreach (char character in message)
                {
                    if (character >= 'A' && character <= 'Z')
                    {
                        isAlphabet = true;
                    }
                    else
                    {
                        isAlphabet = false;
                        break;
                    }
                }

                char[] alphabet = new char[] {'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H',
                'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V',
                'W', 'X', 'Y', 'Z'};

                if (isAlphabet)
                {

                    if (Int32.TryParse(input, out int shift))
                    {
                        string encrypted = "";

                        for (int i = 0; i < message.Length; i++)
                        {
                            //find the position of the letter in the alphabet array
                            int oldposition = Array.IndexOf(alphabet, message[i]);

                            //add/minus to find the new position
                            int newPosition = (oldposition + shift) % 26;

                            if (newPosition < 0)
                            {
                                //get the new letter in the alphabet array with the new position
                                char newLetter = alphabet[alphabet.Length + newPosition];

                                //add the encrypted letter to the encrypted string
                                encrypted += newLetter;
                            }
                            else
                            {
                                //get the new letter in the alphabet array with the new position
                                char newLetter = alphabet[newPosition];

                                //add the encrypted letter to the encrypted string
                                encrypted += newLetter;
                            }
                        }
                        Console.WriteLine(encrypted);
                    }
                    else
                    {
                        Console.WriteLine("converting problem");
                    }
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
