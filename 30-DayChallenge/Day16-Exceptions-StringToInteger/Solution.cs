using System;

namespace Day16_Exceptions_StringToInteger
{
    class Solution
    {
        static void Main(string[] args)
        {
            string S = Console.ReadLine();

            try
            {
                Console.WriteLine(int.Parse(S));
            }
            catch (Exception)
            {
                Console.WriteLine("Bad String");
            }
        }
    }
}
