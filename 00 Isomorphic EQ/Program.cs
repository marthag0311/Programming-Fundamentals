using System;
using System.Collections.Generic;

namespace _00_Isomorphic_EQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //aab xxy
            //true

            //aab xyz
            //false

            //ab xxy
            //false

            string input = Console.ReadLine();

            string[] array = input.Split(' ');

            string first = array[0];
            string second = array[1];

            string tempF = "";
            string tempS = "";

            List<int> listF = new List<int>();
            List<int> listS = new List<int>();

            if (first.Length == second.Length)
            {
                for (int i = 0; i < first.Length; i++)
                {
                    if (i == 0)
                    {
                        tempF = first[i].ToString();
                    }
                    else if (tempF == first[i].ToString())
                    {
                        listF.Add(1);
                    }
                    else
                    {
                        tempF = first[i].ToString();
                        listF.Add(0);
                    }
                }

                for (int i = 0; i < second.Length; i++)
                {
                    if (i == 0)
                    {
                        tempS = second[i].ToString();
                    }
                    else if (tempS == second[i].ToString())
                    {
                        listS.Add(1);
                    }
                    else
                    {
                        tempS = second[i].ToString();
                        listS.Add(0);
                    }
                }

                string lF = string.Join("", listF);
                string lS = string.Join("", listS);

                if (lF == lS)
                {
                    Console.WriteLine(true);
                }
                else
                {
                    Console.WriteLine(false);
                }
            }
            else
            {
                Console.WriteLine(false);
            }
        }
    }
}
