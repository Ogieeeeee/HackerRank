using System;

namespace HackerRank.MonthOfCode
{

    public static class StringIndexes
    {

        public static void printEvenAndOddIndexes(string [] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                string even = "";
                string odd = "";
                string result = "";

                for (int j = 0; j < a[i].Length; j++)
                {
                    if (j % 2 == 0) even += a[i][j];
                    else if (j % 2 == 1) odd += a[i][j];
                }
                result = even + " " + odd;
                Console.WriteLine(result);
            }

        }
    }
}