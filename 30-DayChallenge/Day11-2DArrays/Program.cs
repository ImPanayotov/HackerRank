using System;
using System.Collections.Generic;
using System.Linq;

namespace Day11_2DArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[6][];

            for (int i = 0; i < 6; i++)
            {
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }

            int maxSum = int.MinValue;

            for (int row = 0; row < arr.Length - 2; row++)
            {
                for (int col = 0; col < arr[row].Length - 2; col++)
                {
                    int currSum = arr[row][col] + arr[row][col + 1] + arr[row][col + 2] + arr[row + 1][col + 1] + arr[row + 2][col] + arr[row + 2][col + 1] + arr[row + 2][col + 2];

                    if (currSum > maxSum)
                    {
                        maxSum = currSum;
                    }
                }
            }

            Console.WriteLine(maxSum);
        }
    }
}
