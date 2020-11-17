using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.PasswordDecryption
{
    public class Result
    {
        /*
     * Complete the 'decryptPassword' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

        public static string decryptPassword(string s)
        {
            int lenght = s.Length;
            char[] charArr = s.ToCharArray();
            List<char> charList = s.ToList();

            for (int i = 0; i < lenght; i++)
            {
                if (char.IsLower(charList[i]) && char.IsUpper(charList[i + 1]))
                {
                    char temp = charList[i];
                    charList[i] = charList[i + 1];
                    charList[i + 1] = temp;
                    charList.Insert((i + 2), '*');
                    i++;
                }
                else if (char.IsDigit(charList[i]))
                {
                    char temp = charList[i];
                    charList[i] = '0';
                    charList.Insert(0, temp);
                    i++;
                }
            }

            string result = string.Join("", charList);
            return result.ToString();
        }
    }
}
