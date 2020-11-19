using System;

namespace Day01_DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 4;
            double d = 4.0;
            string s = "HackerRank ";
            // Use the  operator to perform the following operations:
            // Print the sum of  plus your int variable on a new line.
            // Print the sum of plus your double variable to a scale of one decimal place on a new line.
            //Concatenate  with the string you read as input and print the result on a new line.
            int i2 = int.Parse(Console.ReadLine());
            double d2 = double.Parse(Console.ReadLine());
            string s2 = Console.ReadLine();

            Console.WriteLine(i + i2);
            double doubleResult = d + d2;
            Console.WriteLine($"{doubleResult:f1}");
            Console.WriteLine(s + s2);
        }
    }
}
