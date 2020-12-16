using System;
using System.Collections.Generic;
using System.Text;

namespace Day12_Inheritance
{
    public class Student : Person
    {
        private int[] testScores;

        public Student(string firstName, string lastName, int id, int[] scores) : base(firstName, lastName, id)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = id;
            testScores = scores;
        }


        public char Calculate()
        {
            int avgSum = 0;
            for (int i = 0; i < testScores.Length; i++)
            {
                avgSum += testScores[i];
            }
            avgSum /= testScores.Length;
            char grade = ' ';

            if (avgSum < 40)
            {
                grade = 'T';
            }
            else if (avgSum >= 40 && avgSum < 55)
            {
                grade = 'D';

            }
            else if (avgSum >=55 && avgSum < 70)
            {
                grade = 'P';

            }
            else if (avgSum >= 70 && avgSum < 80)
            {
                grade = 'A';

            }
            else if (avgSum >= 80 && avgSum < 90)
            {
                grade = 'E';

            }
            else if (avgSum >= 90 && avgSum <= 100)
            {
                grade = 'O';

            }

            return grade;
        }
    }
}
