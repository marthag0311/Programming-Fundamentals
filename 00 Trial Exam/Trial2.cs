using System;

class Palindrome
{
    public string Phrase { get; set; }

    public Palindrome(string digit)
	{
        Phrase = digit;
    }

    public int NextPalindrome()
    {
        int number = Convert.ToInt32(Phrase);

        if (number < 0)
        {
            Console.WriteLine("crazy input");
        }
        else
        {
            number += 1;
            string reversedStringNumber = "";

            string stringNumber = number.ToString();

            for (int i = stringNumber.Length - 1; i >= 0; i--)
            {
                reversedStringNumber += stringNumber[i];
            }

            while (stringNumber != reversedStringNumber)
            {
                number++;
                reversedStringNumber = "";

                stringNumber = number.ToString();

                for (int i = stringNumber.Length - 1; i >= 0; i--)
                {
                    reversedStringNumber += stringNumber[i];
                }
            }
        }
        return number;
    }
}
