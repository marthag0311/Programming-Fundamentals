using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_Roman_to_Decimal
{
    /*
        Read in a roman numeral n and convert it to a decimal number. (M = 1000, D = 500, C = 100, L = 50, X = 10, V = 5 and I = 1)

        Example: n = DXII --> 500 + 10 + 1 + 1 = 512 
        (tip: work with the length of a word and ElementAt())

        input:
        DXII

        output:
        512

        input:
        MDCCXXXIIII

        output:
        1734
     */
    class Program
    {
        private static Dictionary<char, int> Dict = new Dictionary<char, int>()
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

        public static int Solution1(string roman)
        {
            int number = 0;

            for (int i = 0; i < roman.Length; i++)
            {
                if (i + 1 < roman.Length && Dict[roman[i]] < Dict[roman[i + 1]])
                {
                    number -= Dict[roman[i]];
                }
                else
                {
                    number += Dict[roman[i]];
                }
            }
            return number;
        }

        public static int Solution2(string roman)
        {
            int number = 0;
            char previousChar = roman[0];
            foreach (char currentChar in roman)
            {
                number += Dict[currentChar];
                if (Dict[previousChar] < Dict[currentChar])
                {
                    number -= Dict[previousChar] * 2;
                }
                previousChar = currentChar;
            }
            return number;
        }

        public static int Solution3(string roman)
        {
            int number = 0;

            foreach (char character in roman)
            {
                number += RomanCharToNumber(character);
            }

            if (roman.Contains("IV") || roman.Contains("IX"))
            {
                number -= 2;
            }
            else if (roman.Contains("XL") || roman.Contains("XC"))
            {
                number -= 20;
            }
            else if (roman.Contains("CD") || roman.Contains("CM"))
            {
                number -= 200;
            }

            return number;
        }

        private static int RomanCharToNumber(char letter)
        {
            switch (letter)
            {
                case 'M':
                    {
                        return 1000;
                    }
                case 'D':
                    {
                        return 500;
                    }
                case 'C':
                    {
                        return 100;
                    }
                case 'L':
                    {
                        return 50;
                    }
                case 'X':
                    {
                        return 10;
                    }
                case 'V':
                    {
                        return 5;
                    }
                case 'I':
                    {
                        return 1;
                    }
                default:
                    {
                        throw new ArgumentException("Ivalid charakter");
                    }
            }
        }

        static void Main(string[] args)
        {
            string roman = Console.ReadLine().ToUpper();

            Console.WriteLine("Method 1");
            Console.WriteLine(Solution1(roman));
            Console.WriteLine();

            Console.WriteLine("Method 2");
            Console.WriteLine(Solution2(roman));
            Console.WriteLine();

            Console.WriteLine("Method 3");
            Console.WriteLine(Solution3(roman));
            Console.WriteLine();

            Console.WriteLine("Solution 1");
                        
            Dictionary<char, int> dict = new Dictionary<char, int>
            {
                {'I', 1 },
                {'V', 5},
                {'X', 10},
                {'L', 50},
                {'C', 100},
                {'D', 500},
                {'M', 1000}
            };

            int number = 0;

            for (int i = 0; i < roman.Length; i++)
            {
                if (i + 1 < roman.Length && dict[roman[i]] < dict[roman[i + 1]])
                {
                    number -= dict[roman[i]];
                }
                else
                {
                    number += dict[roman[i]];
                }
            }
            Console.WriteLine(number);
            Console.WriteLine();

            //////////////////////////////////////////////

            Console.WriteLine("Solution 2");

            number = 0;
            char previousChar = roman[0];

            foreach (char currentChar in roman)
            {
                number += dict[currentChar];
                if (dict[previousChar] < dict[currentChar])
                {
                    number -= dict[previousChar] * 2;
                }
                previousChar = currentChar;
            }
            Console.WriteLine(number);
            Console.WriteLine();

            ///////////////////////////////////////////////

            Console.WriteLine("Solution 3");

            number = 0;

            foreach (char character in roman)
            {
                switch (character)
                {
                    case 'M': 
                        number += 1000;
                        break;
                    case 'D':
                        number += 500;
                        break;
                    case 'C':
                        number += 100;
                        break;
                    case 'L':
                        number += 50;
                        break;
                    case 'X':
                        number += 10;
                        break;
                    case 'V':
                        number += 5;
                        break;
                    case 'I':
                        number += 1;
                        break;
                    default: throw new ArgumentException("Ivalid charakter");
                }                
            }

            if (roman.Contains("IV") || roman.Contains("IX"))
            {
                number -= 2;
            }
            else if (roman.Contains("XL") || roman.Contains("XC"))
            {
                number -= 20;
            }
            else if (roman.Contains("CD") || roman.Contains("CM"))
            {
                number -= 200;
            }

            Console.WriteLine(number);
            Console.WriteLine();

            ////////////// Decimal to Roman//////////////

            /*string[] ones = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
            string[] tens = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            string[] hundreds = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
            string[] thousands = { "", "M", "MM", "MMM", "MMMM" };

            if (Int32.TryParse(roman, out int number))
            {
                int thou = number / 1000;
                int temp = number % 1000;
                int hund = temp / 100;
                temp = temp % 100;
                int ten = temp / 10;
                temp = temp % 10;
                int one = temp;

                Console.WriteLine(thousands.ElementAtOrDefault(thou) + hundreds.ElementAtOrDefault(hund) + tens.ElementAtOrDefault(ten) + ones.ElementAtOrDefault(one));
            }*/
        }
    }
}
