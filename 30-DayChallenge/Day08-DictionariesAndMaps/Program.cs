using System;
using System.Collections.Generic;

namespace Day08_DictionariesAndMaps
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, int> phoneBook = new Dictionary<string, int>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                if (input.Length == 2)
                {

                    string name = input[0].ToLower();
                    string numberStr = input[1];
                    if (numberStr.Length == 8)
                    {
                        int number = int.Parse(input[1]);
                        phoneBook.Add(name, number);
                    }
                }
            }

            while (true)
            {
                string input = Console.ReadLine();
                if (input == null)
                {
                    break;
                }
                if (phoneBook.ContainsKey(input) && input != null)
                {
                    Console.WriteLine(input + "=" + phoneBook[input]);
                }
                else
                {
                    Console.WriteLine("Not found");
                }
            }


            //            Unhandled Exception:
            //System.ArgumentNullException: Value cannot be null.
            //Parameter name: key
            //  at System.Collections.Generic.Dictionary`2[TKey, TValue].FindEntry(TKey key)[0x00008] in < 254335e8c4aa42e3923a8ba0d5ce8650 >:0
            //  at System.Collections.Generic.Dictionary`2[TKey, TValue].ContainsKey(TKey key)[0x00000] in < 254335e8c4aa42e3923a8ba0d5ce8650 >:0
            //  at Solution.Main(System.String[] args)[0x00061] in < f22c2594b7ed445f892677f19ac68660 >:0
            //[ERROR] FATAL UNHANDLED EXCEPTION: System.ArgumentNullException: Value cannot be null.
            //Parameter name: key
            //  at System.Collections.Generic.Dictionary`2[TKey, TValue].FindEntry(TKey key)[0x00008] in < 254335e8c4aa42e3923a8ba0d5ce8650 >:0
            //  at System.Collections.Generic.Dictionary`2[TKey, TValue].ContainsKey(TKey key)[0x00000] in < 254335e8c4aa42e3923a8ba0d5ce8650 >:0
            //  at Solution.Main(System.String[] args)[0x00061] in < f22c2594b7ed445f892677f19ac68660 >:0


        }
    }
}
