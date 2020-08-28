using System;
using HackerRank.MonthOfCode;
using Xunit;

namespace HackerRank
{
    public class TestsDay2
    {
        [Fact]
        public void MealPrice_CalculateMealPrice()
        {
            //Arrange
            const double MEAL_PRICE_NO_TAX = 12;
            const int TIP = 2;
            const int TAX = 8;

            double expecteddMealPrice = Math.Round(MEAL_PRICE_NO_TAX +
                                                        (MEAL_PRICE_NO_TAX / 100 * TIP) +
                                                        (MEAL_PRICE_NO_TAX / 100 * TAX),
                                                    0, MidpointRounding.AwayFromZero);

            System.Console.WriteLine(expecteddMealPrice);

            //Act
            double actualMealPrice = SolutionsDay2.MealPrice(MEAL_PRICE_NO_TAX, TIP, TAX);

            //Asert
            Assert.Equal(expecteddMealPrice, actualMealPrice);
        }

        [Theory]
        [InlineData(12, 8, 2, 13)]
        [InlineData(20, 8, 2, 22)]
        [InlineData(33, 8, 2, 36)]
        public void MealPriceAlt_CalculateMealPriceWithTipAndTax(double mealCost, int tip, int tax, double expectedMealPrice)
        {
            //Act
            double actualMealPrice = SolutionsDay2.MealPriceAlt(mealCost, tip, tax);

            //Assert
            Assert.Equal(expectedMealPrice, actualMealPrice);
        }

        [Theory]
        [InlineData(12, 8, 2, 13)]
        [InlineData(20, 8, 2, 22)]
        [InlineData(33, 8, 2, 36)]
        public void MealPriceAlt2_CalculateMealPriceWithTipAndTax(double mealCost, int tip, int tax, double expectedMealPrice)
        {
            //Act
            double actualMealPrice = SolutionsDay2.MealPriceAlt2(mealCost, tip, tax);

            //Assert
            Assert.Equal(expectedMealPrice, actualMealPrice);
        }

    }
}
