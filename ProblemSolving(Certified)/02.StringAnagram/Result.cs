using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.StringAnagram
{
    public class Result
    {
        public static List<int> stringAnagram(List<string> dictionary, List<string> query)
        {
            int letterCount = 0;
            int wordCount = 0;

            List<int> counter = new List<int>();

            for (int i = 0; i < query.Count; i++)
            {
                for (int j = 0; j < dictionary.Count; j++)
                {
                    char[] queryChars = query[i].ToCharArray();
                    char[] dictChars = dictionary[j].ToCharArray();

                    for (int k = 0; k < queryChars.Length; k++)
                    {
                        if (!dictChars.Contains(queryChars[k]))
                        {
                            break;
                        }
                        else
                        {
                            letterCount++;
                            continue;
                        }
                    }

                    if (letterCount == queryChars.Length)
                    {
                        wordCount++;
                    }

                    letterCount = 0;
                }

                counter.Add(wordCount);
                wordCount = 0;
            }

            return counter;
        }
    }
}
