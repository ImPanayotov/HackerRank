using System;
using System.Collections.Generic;
using System.Text;

namespace Day04_ClassVsInstance
{
    public class Person
    {
        public int age;
        public Person(int initialAge)
        {
            Age = initialAge;
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value < 0)
                {
                    value = 0;
                    Console.WriteLine("Age is not valid, setting age to 0.");
                }

                this.age = value;
            }
        }

        public void yearPasses()
        {
            this.Age++;
        }

        public void amIOld()
        {
            if (this.Age < 13)
            {
                Console.WriteLine("You are young.");
            }
            else if (this.Age >= 13 && this.Age < 18)
            {
                Console.WriteLine("If and, print You are a teenager."); 
            }
            else
            {
                Console.WriteLine("You are old");
            }
        }
    }
}
