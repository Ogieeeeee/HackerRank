using System;
using HackerRank.MonthOfCode;
using Xunit;

namespace HackerRank
{
    public class TestsDay4
    {
        [Fact]
        public void yearPasses_ageShouldGoUp()
        {
            //Arrange
            int expectedAge = 5;
            var p = new Person(4);

            //Act
            p.yearPasses();
            int actualAge = p.age;

            //Assert
            Assert.Equal(expectedAge, actualAge);
        }


        [Theory]
        [InlineData(-1, 1)]
        [InlineData(0, 1)]
        [InlineData(5, 6)]
        public void yearPasses_agesShouldGoUp(int age, int expectedAge)
        {
            //Arange
            var p = new Person(age);

            //Act
            p.yearPasses();
            int actualAge = p.age;

            //Asert
            Assert.Equal(expectedAge, actualAge);
        }




        [Theory]
        [InlineData(-1, "You are young.")]
        [InlineData(13, "You are a teenager.")]
        [InlineData(17, "You are a teenager.")]
        [InlineData(18, "You are old.")]
        [InlineData(100, "You are old.")]
        public void amIOld_YoungTeenagerOrOld(int age, string expectedMessage)
        {
            //Arrange
            var p = new Person(age);

            //Act
            string actualMessage = p.amIOld();

            //Assert
            Assert.Equal(actualMessage, expectedMessage);
        }

    }
}
