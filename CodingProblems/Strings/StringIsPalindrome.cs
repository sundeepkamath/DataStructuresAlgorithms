using System;
using System.Collections.Generic;
using System.Text;

namespace CodingProblems.Strings
{
    public partial class StringOperations
    {
        //O(n/2) => O(n) complexity as Big-O notation ignores constant terms
        public static bool IsStringAPalindrome(string inputString)
        {
            if (string.IsNullOrWhiteSpace(inputString))
                throw new ArgumentException("Input string cannot be null or whitespace");

            bool stringIsPalindrome = true;

            for(int i=0, j=inputString.Length - 1; i < j; i++, j--)
            {
                if (inputString[i] != inputString[j])
                    return false;
            }

            return stringIsPalindrome;
        }
    }
}
