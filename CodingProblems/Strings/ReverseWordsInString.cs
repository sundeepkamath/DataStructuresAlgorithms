using System;
using System.Collections.Generic;
using System.Text;

namespace CodingProblems.Strings
{
    //Time complexity: O(n)
    public class StringOperations
    {
        public static string ReverseWordsInString(string inputString)
        {
            if (inputString == null)
                throw new ArgumentNullException();

            string reversedString = string.Empty;

            string[] words = inputString.Split(' ');
            for (int i = words.Length - 1; i >= 0; i--)
            {
                reversedString += $" {words[i]}";
            }

            return reversedString.Substring(1); //since the first character is the whitespace
        }
    }
}
