using System;

namespace Day06_Let_sReview
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string str = Console.ReadLine();
                string even = string.Empty;
                string odd = string.Empty;

                for (int j = 0; j < str.Length; j++)
                {
                    if (j % 2 == 0)
                    {
                         even += str[j].ToString();
                    }
                    else
                    {
                        odd += str[j].ToString();
                    }
                }

                Console.WriteLine(even + " " + odd);
            }
        }
    }
}
