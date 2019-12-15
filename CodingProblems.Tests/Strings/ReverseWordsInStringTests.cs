using CodingProblems.Strings;
using System;
using Xunit;

namespace CodingProblems.Tests.Strings
{
    public class ReverseWordsInStringTests
    {
        [Fact]
        public void When_InputString_IsNull_ArgumentNullExceptionIsThrown()
        {
            Assert.Throws<ArgumentNullException>(() => StringOperations.ReverseWordsInString(null));
        }

        [Fact]
        public void When_InputString_IsValid_StringWithReversedWordsIsReturned()
        {
            string sentence = "he is a jolly good fellow";

            string result = StringOperations.ReverseWordsInString(sentence);

            Assert.Equal("fellow good jolly a is he", result);
        }

        [Fact]
        public void When_InputString_IsWhitespace_ReturnedStringIsSameWhitespace()
        {
            string sentence = "  ";

            string result = StringOperations.ReverseWordsInString(sentence);

            Assert.Equal("  ", result);
        }

    }
}
