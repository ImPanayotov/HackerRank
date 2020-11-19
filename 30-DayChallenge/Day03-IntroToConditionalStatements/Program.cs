using System;

namespace Day03_IntroToConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Task
            //Given an integer, , perform the following conditional actions:

            //If is odd, print Weird
            //If is even and in the inclusive range of 2 to 5, print Not Weird
            //If is even and in the inclusive range of  6 to 20, print Weird
            //If is even and greater than 20, print Not Weird
            //Complete the stub code provided in your editor to print whether or not is weird.

            //Input Format

            //A single line containing a positive integer, .

            //Constraints

            //Output Format

            //Print Weird if the number is weird; otherwise, print Not Weird.

            int N = Convert.ToInt32(Console.ReadLine());

            if (N % 2 == 0 && N >= 2 && N <= 5)
            {
                Console.WriteLine("Not Weird");
            }
            else if (N % 2 == 0 && N >= 6 && N <= 20)
            {
                Console.WriteLine("Weird");
            }
            else if (N % 2 == 0 && N > 20)
            {
                Console.WriteLine("Not Weird");
            }
            else if (N% 2 != 0)
            {
                Console.WriteLine("Weird");
            }
        }
    }
}
