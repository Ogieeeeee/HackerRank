using System;

namespace HackerRank.MonthOfCode
{

    //Exercise link: https://www.hackerrank.com/challenges/30-loops/problem
    public static class Loops
    {
        public static void ProductOfSomeNumberTo10(int n)
        {
            int i = 1;
            while (i <= 10)
            {
                System.Console.WriteLine($"{n} x {i} = {n * i}");
                i++;
            }

        }
    }


}