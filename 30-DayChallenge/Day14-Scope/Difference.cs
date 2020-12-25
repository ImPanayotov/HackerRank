using System;
using System.Collections.Generic;
using System.Text;

namespace Day14_Scope
{
    public class Difference
    {
        private int[] elements;
        public int maximumDifference;

        public Difference(int[] elements)
        {
            this.elements = elements;
            MaximumDifference = maximumDifference;

        }

        public int MaximumDifference { get; set; } = 0;

        public void computeDifference()
        {
            // 1 2 5
            for (int i = 0; i < elements.Length - 1; i++)
            {
                for (int j = i + 1; j < elements.Length; j++)
                {
                    int currentMaxDiff = Math.Abs(elements[i] - elements[j]);
                    if (currentMaxDiff > maximumDifference)
                    {
                        maximumDifference = currentMaxDiff;
                    }
                }
            }
        }
    }
}
