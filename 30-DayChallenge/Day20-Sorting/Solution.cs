using System;
using System.Linq;

namespace Day20_Sorting
{
    class Solution
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);

            int temp;
            int numOfSwaps = 0;

            for (int j = 0; j <= a.Length - 2; j++)
            {
                for (int i = 0; i <= a.Length - 2; i++)
                {
                    if (a[i] > a[i + 1])
                    {
                        temp = a[i + 1];
                        a[i + 1] = a[i];
                        a[i] = temp;

                        numOfSwaps++;
                    }
                }
            }

            int firstElement = a[0];
            int lastElement = a[a.Length-1];

            Console.WriteLine($"Array is sorted in {numOfSwaps} swaps.");
            Console.WriteLine($"First Element: {firstElement}");
            Console.WriteLine($"Last Element: {lastElement}");
        }
    }
}
