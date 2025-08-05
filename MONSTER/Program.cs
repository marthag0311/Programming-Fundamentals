using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace MONSTER
{
    class Program
    {
        private static int NextLeapYear(int year)
        {
            int nextLeapYear = 0;

            if (DateTime.IsLeapYear(year))
            {
                nextLeapYear = year + 4; 
            }

            return nextLeapYear;
        }

        private static int SumOfDigits(int digits)
        {
            int firstSumOfDigits = 0, remainder = 0;

            while (digits != 0)
            {
                remainder = digits % 10;
                firstSumOfDigits = firstSumOfDigits + remainder;
                digits = digits / 10;
            }

            int secondSumOfDigits = 0;

            while (firstSumOfDigits > 0)
            {
                remainder = firstSumOfDigits % 10;
                secondSumOfDigits = secondSumOfDigits + remainder;
                firstSumOfDigits = firstSumOfDigits / 10;
            }

            return secondSumOfDigits;
        }

        private static bool IsFibonacci(int num)
        {
            int number = num;

            List<int> fibonacci = new List<int>();

            int first = 0;
            fibonacci.Add(first);

            int second = 1;
            fibonacci.Add(second);

            int result;

            for (int m = 0; m < number; m++)
            {
                result = first + second;
                fibonacci.Add(result);

                first = second;
                second = result;
            }

            bool isFibonacci = true;

            if (fibonacci.Contains(number))
            {
                isFibonacci = true; ;
            }
            else
            {
                isFibonacci = false;
            }

            return isFibonacci; 
        }

        static bool IsPrime(int prime)
        {
            
            if (prime <= 1)
            {
                return false;
            }

            for (int nb = 2; nb < prime; nb++)
            {
                if (prime % nb == 0)
                {
                    return false;
                }
            }

            return true;
        }

        private static int NextPrime(int prime)
        {
            if (prime <= 1)
            {
                return 2; 
            }

            int nextPrime = prime;
            bool isPrime = false; 

            while (!isPrime)
            {
                nextPrime++;

                if (IsPrime(nextPrime))
                {
                    isPrime = true;
                }
            }

            return nextPrime;
        }

        private static string ReverseCase(string input)
        {
            string text = "";

            for  (int m = 0; m < input.Length; m++)
            {
                if (Char.IsLower(input[m]))
                {
                    text += char.ToUpper(input[m]);
                }
                else if (Char.IsUpper(input[m]))
                {
                    text += char.ToLower(input[m]);
                }
                else
                {
                    text += " ";
                }
            }

            return text;
        }

        private static bool Palindrome(string input)
        {
            string text = "";
            string term = "";
            bool isPalindrome = false; 

            string phrase = input.ToLower();

            for (int m = 0; m <= phrase.Length - 1; m++)
            {
                if (Char.IsLetter(phrase[m]))
                {
                    term += phrase[m];
                }
            }

            for (int m = phrase.Length - 1; m >= 0; m--)
            {
                if (Char.IsLetter(phrase[m]))
                {
                    text += phrase[m];
                }
            }

            if (text == term)
            {
                isPalindrome = true;
            }
            else
            {
                isPalindrome = false;
            }

            return isPalindrome;
        }

        private static bool Anagram(string input)
        {
            bool isAnagram = false;

            input = input.ToLower();
            string[] text = input.Split(",");

            char[] word = text[0].ToCharArray();
            char[] wordd = text[1].ToCharArray();

            Array.Sort(word);
            Array.Sort(wordd);

            for (int m = 0; m <= word.Length - 1; m++)
            {
                for (int g = 0; g <= wordd.Length - 1; g++)
                {
                    if (word[m] == wordd[g])
                    {
                        isAnagram = true;
                    }
                    else
                    {
                        isAnagram = false;
                    }
                }
            }

            return isAnagram;
        }

        private static int AlphabetSum(string input)
        {
            int sum = 0;
            input = input.ToLower();

            for (int m = 0; m <= input.Length - 1; m++)
            {
                if (input[m] == 'a')
                {
                    sum += 1;
                }
                else if (input[m] == 'b')
                {
                    sum += 2;
                }
                else if (input[m] == 'c')
                {
                    sum += 3;
                }
                else if (input[m] == 'd')
                {
                    sum += 4;
                }
                else if (input[m] == 'e')
                {
                    sum += 5;
                }
                else if (input[m] == 'f')
                {
                    sum += 6;
                }
                else if (input[m] == 'g')
                {
                    sum += 7;
                }
                else if (input[m] == 'h')
                {
                    sum += 8;
                }
                else if (input[m] == 'i')
                {
                    sum += 9;
                }
                else if (input[m] == 'j')
                {
                    sum += 10;
                }
                else if (input[m] == 'k')
                {
                    sum += 11;
                }
                else if (input[m] == 'l')
                {
                    sum += 12;
                }
                else if (input[m] == 'm')
                {
                    sum += 13;
                }
                else if (input[m] == 'n')
                {
                    sum += 14;
                }
                else if (input[m] == 'o')
                {
                    sum += 15;
                }
                else if (input[m] == 'p')
                {
                    sum += 16;
                }
                else if (input[m] == 'q')
                {
                    sum += 17;
                }
                else if (input[m] == 'r')
                {
                    sum += 18;
                }
                else if (input[m] == 's')
                {
                    sum += 19;
                }
                else if (input[m] == 't')
                {
                    sum += 20;
                }
                else if (input[m] == 'v')
                {
                    sum += 21;
                }
                else if (input[m] == 'u')
                {
                    sum += 22;
                }
                else if (input[m] == 'w')
                {
                    sum += 23;
                }
                else if (input[m] == 'x')
                {
                    sum += 24;
                }
                else if (input[m] == 'y')
                {
                    sum += 25;
                }
                else if (input[m] == 'z')
                {
                    sum += 26;
                }
            }

            return sum;
        }

        private static int LCM(string input)
        {
            string[] nums = input.Split(",");

            int[] numbers = new int[nums.Length];

            for (int m = 0; m < numbers.Length; m++)
            {
                numbers[m] = Convert.ToInt32(nums[m]);
            }

            int a, b, temporary, lcm, gcd;

            a = numbers[0];
            b = numbers[1];

            while (b != 0)
            {
                temporary = b;
                b = a % b;
                a = temporary;
            }
            gcd = a;
            lcm = (numbers[0] * numbers[1]) / gcd;
            return lcm;
        }

        private static int GCD(string input) 
        {
            string[] nums = input.Split(",");

            int[] numbers = new int[nums.Length];

            for (int m = 0; m < numbers.Length; m++)
            {
                numbers[m] = Convert.ToInt32(nums[m]);
            }

            int a, b, temporary, gcd;

            a = numbers[0];
            b = numbers[1];

            while (b != 0)
            {
                temporary = b;
                b = a % b;
                a = temporary;
            }
            gcd = a;

            return gcd;
        }

        static void Main(string[] args)
        {
            string answer = Console.ReadLine();
            string input = Console.ReadLine();

            int number;
            if (Int32.TryParse(answer, out number))
            {
                if (number == 1)
                {
                    int year;
                    if (Int32.TryParse(input, out year))
                    {
                        Console.WriteLine(NextLeapYear(year));
                    }
                    else
                    {
                        Console.WriteLine("crazy input");
                    }
                }
                else if (number == 2)
                {
                    int digits;
                    if (Int32.TryParse(input, out digits))
                    {
                        Console.WriteLine(SumOfDigits(digits));
                    }
                    else
                    {
                        Console.WriteLine("crazy input");
                    }
                }
                else if (number == 3)
                {
                    int num;
                    if (Int32.TryParse(input, out num))
                    {
                        Console.WriteLine(IsFibonacci(num));
                    }
                    else
                    {
                        Console.WriteLine("crazy input");
                    }
                }
                else if (number == 4)
                {
                    int prime;
                    if (Int32.TryParse(input, out prime))
                    {
                        Console.WriteLine(NextPrime(prime));
                    }
                    else
                    {
                        Console.WriteLine("crazy input");
                    }
                }
                else if (number == 5)
                {
                    try
                    {
                        Console.WriteLine(ReverseCase(input));
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("crazy input");
                    }
                }
                else if (number == 6)
                {
                    try
                    {
                        Console.WriteLine(Palindrome(input));
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("crazy input");
                    }
                }
                else if (number == 7)
                {
                    try
                    {
                        Console.WriteLine(Anagram(input));
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("crazy input");
                    }
                }
                else if (number == 8)
                {
                    try
                    {
                        Console.WriteLine(AlphabetSum(input));
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("crazy input");
                    }
                }
                else if (number == 9)
                {
                    try
                    {
                        Console.WriteLine(LCM(input));
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("crazy input");
                    }
                }
                else if (number == 10)
                {
                    try
                    {
                        Console.WriteLine(GCD(input));
                    }
                    catch
                    {
                        Console.WriteLine("crazy input");
                    }
                }
                else 
                {
                    Console.WriteLine("crazy input");
                }
            }
            else
            {
                Console.WriteLine("crazy input");
            }
        }
    }
}
