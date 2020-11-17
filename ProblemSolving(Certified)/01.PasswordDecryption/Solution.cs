using System;
using System.IO;

namespace _01.PasswordDecryption
{
    public class Solution
    {
        static void Main(string[] args)
        {

            string s = Console.ReadLine();

            string result = Result.decryptPassword(s);

            Console.WriteLine(result);
           
        }

        
    }
}
