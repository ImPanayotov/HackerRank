using System;
using System.Linq;

namespace Day10_BinaryNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            string binary = Convert.ToString(n, 2);
            int max = 0;
            int curr = 0;

            for (int i = 0; i < binary.Length; i++)
            {
                if (binary[i] == '1')
                {
                    curr++;

                    for (int j = i + 1; j < binary.Length; j++)
                    {
                        if (binary[j] == '1')
                        {
                            curr++;
                        }
                        else
                        {
                            break;
                        }
                    }

                    if (curr > max)
                    {
                        max = curr;
                    }

                    curr = 0;
                }
            }

            Console.WriteLine(max);
        }
    }
}
