using System;

namespace HackerRank.MonthOfCode
{
    public static class SolutionDay2
    {
        // The exercise is to calculate the meal cost. This cost is rounded to the nearest integer. 
        // For example: 15.36 becomes 15 

        // Link for exercise: https://www.hackerrank.com/challenges/30-operators/problem
        public static double MealPrice(double meal_cost, int tip_percent, int tax_percent)
        {
            // One liner, but less readable I guess?
            return Math.Round((meal_cost / 100 * tip_percent) + (meal_cost / 100 * tax_percent) + meal_cost, 0, MidpointRounding.AwayFromZero);
        }

        public static double MealPriceAlt(double meal_cost, int tip_percent, int tax_percent)
        {
            // More readable version 
            double tip = meal_cost / 100 * tip_percent;
            double tax = meal_cost / 100 * tax_percent;
            double totalCost = meal_cost + tip + tax;

            return Math.Round(totalCost, 0, MidpointRounding.AwayFromZero);
        }


        public static double MealPriceAlt2(double meal_cost, int tip_percent, int tax_percent)
        {
            // Even more readable version 

            //Calculate tip
            double tip = meal_cost / 100 * tip_percent;
            //Calculate tax
            double tax = meal_cost / 100 * tax_percent;
            //Calculate total cost
            double totalCost = meal_cost + tip + tax;

            return Math.Round(totalCost, 0, MidpointRounding.AwayFromZero);
        }

    }
}