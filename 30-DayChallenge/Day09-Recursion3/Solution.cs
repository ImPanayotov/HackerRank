using System;
using System.IO;

namespace Day09_Recursion3
{
    class Solution
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int result = factorial(n);

            Console.WriteLine(result);
        }

        static int factorial(int n)
        {
            if (n == 1)
            {
                return 1;
            }

            return n * factorial(n - 1);
        }
    }
}
