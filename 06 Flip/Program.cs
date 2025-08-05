using System;

namespace _06_Flip
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            string input = Console.ReadLine();
            char[,] arr = new char[input.Length, input.Length];

            //add first element
            for (int i = 0; i < input.Length; i++)
            {
                arr[0, i] = input[i];
            }

            //create array
            for (int i = 1; i < input.Length; i++)
            {
                input = Console.ReadLine();
                for (int j = 0; j < input.Length; j++)
                {
                    arr[i, j] = input[j];
                }
            }

            // { { *, _, * }, { *, _, *}, { *, *, * } };

            //flip array
            for (int i = input.Length - 1; i >= 0; i--)
            {
                for (int j = 0; j < input.Length; j++)
                {
                    Console.Write(arr[i, j]);
                }
                Console.Write("\n");
            }
        }
    }
}
