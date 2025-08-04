using System;

namespace _03_Roots
{
    /*
        Find all roots of a quadratic equation. 
        The standard form of a quadratic equation 
        is: ax² + bx + c = 0

        We calculate the roots by the formula x = (-b ± √D) / (2a) 
        where the ± sign indicates that there will be two roots:
            - root1 = (-b + √(D)) / (2a)
            - root2 = (-b - √(D)) / (2a)

        The term D with the formula b^2-4ac is known as the 
        discriminant of a quadratic equation. It specifies 
        the nature of roots:
            - if D > 0, roots are real and different 
              (print root1 and root2, round to 2 digits)
            - if D == 0, roots are real and equal 
              (print one root, round to 2 digits)
            - if D < 0, roots are complex complex and 
              different (print 'no real solution')

        input:
        2
        5
        -3

        output:
        0.5 -3

        input:
        1
        1
        12

        output:
        no real solution     
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            string answer = Console.ReadLine();
            string input = Console.ReadLine();
            string read = Console.ReadLine();

            if (Int32.TryParse(answer, out int a) &&
                Int32.TryParse(input, out int b) &&
                Int32.TryParse(read, out int c))
            {
                int d = (int)(Math.Pow(b, 2) - 4 * a * c);

                if (d > 0)
                {
                    double x1 = (double)((-b + Math.Sqrt(d)) / (2 * a));
                    double x2 = (double)((-b - Math.Sqrt(d)) / (2 * a));

                    Console.Write($"{x1:f2} ");
                    Console.Write($"{x2:f2}");
                }
                else if (d == 0)
                {
                    double x = (double)((-b + Math.Sqrt(d)) / (2 * a));

                    Console.WriteLine($"{x:f2}");
                }
                else if (d < 0)
                {
                    Console.WriteLine("no real solution");                                        
                }
                else
                {
                    Console.WriteLine("no real solution");
                }
            }
            else
            {
                Console.WriteLine("no real solution");
            }
        }
    }
}
