using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.ConstrainedExecution;

namespace _00_Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string trial = Console.ReadLine().ToUpper();
            
            switch (trial)
            {
                case "A2":
                    string answer = Console.ReadLine();
                    //TrialA2 filename = new TrialA2(answer);
                    break;
                case "B1":
                    string input = Console.ReadLine();
                    TrialB1 filename = new TrialB1(input);
                    Console.WriteLine(filename.LeastAsciiValue());
                    break;
                case "C1":
                    string readin = Console.ReadLine();
                    TrialC1 namefile = new TrialC1(readin);
                    Console.WriteLine(namefile.CountCharacters());
                    break;
                default:
                    Console.WriteLine("default");
                    break;
            }

        }
    }
}
