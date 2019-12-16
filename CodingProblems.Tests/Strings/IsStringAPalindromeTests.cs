using CodingProblems.Strings;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CodingProblems.Tests.Strings
{
    public class IsStringAPalindromeTests
    {
        [Fact]
        public void When_InputString_IsNull_ArgumentNullExceptionIsThrown()
        {
            Assert.Throws<ArgumentException>(() => StringOperations.IsStringAPalindrome(null));
        }

        [Fact]
        public void When_InputString_IsValidPalindromeWithOddNumberOfCharacters_BooleanTrueIsReturned()
        {
            string sentence = "nitin";

            Assert.True(StringOperations.IsStringAPalindrome(sentence));
        }

        [Fact]
        public void When_InputString_IsValidPalindromeWithEvenNumberOfCharacters_BooleanTrueIsReturned()
        {
            string sentence = "poop";

            Assert.True(StringOperations.IsStringAPalindrome(sentence));
        }

        [Fact]
        public void When_InputString_IsNotAPalindrome_BooleanFalseIsReturned()
        {
            string sentence = "notapalindrome";

            Assert.False(StringOperations.IsStringAPalindrome(sentence));
        }

        [Fact]
        public void When_InputString_IsWhitespace_BooleanFalseIsReturned()
        {
            Assert.Throws<ArgumentException>(() => StringOperations.IsStringAPalindrome(" "));
        }
    }
}
