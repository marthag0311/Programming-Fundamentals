using System;
using System.Runtime.InteropServices;

namespace _00_Revision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string trial = Console.ReadLine().ToUpper();

            switch (trial)
            {
                case "A":
                    string input = Console.ReadLine();
                    TrialA array = new TrialA(input.Split(' '));
                    Console.WriteLine(array.Reverse());
                    break;
                case "B":
                    string answer = Console.ReadLine();
                    TrialB countries = new TrialB(answer);
                    Console.WriteLine(countries.Countries());
                    break;
                case "C":
                    TrialC read = new TrialC("C");
                    Console.WriteLine(read.Email());

                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine("default");
                    break;
            }   
        }
    }
}
