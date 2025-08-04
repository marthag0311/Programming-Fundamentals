namespace _00_Sum_of_a_Digit
{
    /*
        Output the sum of a digit.

        Input:
        7024

        Output: 
        13

     */
    internal class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int sum = 0;

            foreach (char character in number)
            {
                int difference = character - '0';
                sum += difference;
            }
            Console.WriteLine(sum);
        }
    }
}