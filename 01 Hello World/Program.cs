using System;

namespace _01_Hello_World
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Read in firstname");
            string name = Console.ReadLine();
            //Console.WriteLine("Read in surname");
            string surname = Console.ReadLine();

            Console.WriteLine($"Hello {name} {surname}");
        }
    }
}
