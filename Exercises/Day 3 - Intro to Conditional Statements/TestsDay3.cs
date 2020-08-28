using System;
using HackerRank.MonthOfCode;
using Xunit;

namespace HackerRank
{
    public class TestsDay3
    {
        [Theory]
        [InlineData(1, "Weird")]
        [InlineData(3, "Weird")]
        [InlineData(5, "Weird")]
        [InlineData(7, "Weird")]
        [InlineData(17, "Weird")]
        [InlineData(18, "Weird")]
        [InlineData(21, "Weird")]
        [InlineData(2, "Not Weird")]
        [InlineData(4, "Not Weird")]
        [InlineData(22, "Not Weird")]
        [InlineData(50, "Not Weird")]
        [InlineData(100, "Not Weird")]
        [InlineData(10_000, "Not Weird")]

        public void Weird_ReturnWeirdOrNotWeird(int n, string expected)
        {
            //Act
            string actualWeirdOrNot = SolutionDay3.Weird(n);
            //Assert
            Assert.Equal(expected, actualWeirdOrNot);
        }

    }
}
