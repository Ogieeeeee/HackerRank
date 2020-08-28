using System;

namespace HackerRank.MonthOfCode
{
    public static class SolutionDay3
    {
        //In this exercise you have to print weird or not weird for the following cases:
        //
        // If n is odd, print Weird
        // If n is even and in the inclusive range of 2 to 5, print Not Weird
        // If n is even and in the inclusive range of 6 to 20, print Weird
        // If n is even and greater than 20, print Not Weird
        public static string Weird(int n)
        {
            bool nIsEven = n % 2 == 0;
            bool nIsOdd = n % 2 == 1;

            if (nIsEven)
            {
                if (n >= 2 && n <= 5) return "Not Weird";
                if (n >= 6 && n <= 20) return "Weird";
                if (n > 20) return "Not Weird";
            }
            else if (nIsOdd) return "Weird";

            return "";
        }
    }
}