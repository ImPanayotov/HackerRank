using System;
using System.Collections.Generic;
using System.IO;

namespace _02.StringAnagram
{
    class Program
    {
        static void Main(string[] args)
        {

            int dictionaryCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<string> dictionary = new List<string>();

            for (int i = 0; i < dictionaryCount; i++)
            {
                string dictionaryItem = Console.ReadLine();
                dictionary.Add(dictionaryItem);
            }

            int queryCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<string> query = new List<string>();

            for (int i = 0; i < queryCount; i++)
            {
                string queryItem = Console.ReadLine();
                query.Add(queryItem);
            }

            List<int> result = Result.stringAnagram(dictionary, query);

            Console.WriteLine(String.Join("\n", result));
        }
    }
}
