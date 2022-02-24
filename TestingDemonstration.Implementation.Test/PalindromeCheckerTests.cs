using System;
using Xunit;

namespace TestingDemonstration.Implementation.Test
{
    public class PalindromeCheckerTests
    {
        private readonly PalindromeChecker _checker;

        public PalindromeCheckerTests()
        {
            // arrange
            _checker = new PalindromeChecker();
        }

        [Theory]
        [InlineData(true, "level")]
        [InlineData(false, "car")]
        [InlineData(true, "LEVEL")]
        [InlineData(true, "racecar")]
        [InlineData(true, "level level")]
        [InlineData(true, "123level321")]
        [InlineData(false, "")]
        public void Check_ReturnsTrueOnlyWhenPalindrome(bool expect, string word)
        {

            // act
            var result = _checker.Check(word);

            // assert
            Assert.Equal(expect, result);
        }

        [Fact]
        public void Check_StringWithSpecialCharacters_ThrowsArgumentException()
        {
            var word = "!@#$@#$";
            Assert.Throws<ArgumentException>(() => _checker.Check(word));
        }



    }
}
