using System;

namespace _01_Lowercase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            string animal = Console.ReadLine().ToLower();

            Console.WriteLine($"{name}, your favorite animal is {animal}");
        }
    }
}
