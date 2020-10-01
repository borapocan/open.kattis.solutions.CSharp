using System;
using static System.Console;

namespace DiagonalDifference
{
    class Solution
    {
        static void Main(String[] args)
        {
            int sumPrimaryDiagonal = 0;

            int sumSecondaryDiagonal = 0;

            int n = int.Parse(ReadLine());

            for (int i = 0, j = n - 1; i < n; i++, j--)
            {
                var a_temp = ReadLine().Split(' ');

                var newRow = Array.ConvertAll(a_temp, int.Parse);

                sumPrimaryDiagonal += newRow[i];

                sumSecondaryDiagonal += newRow[j];
            }

            WriteLine(Math.Abs(sumPrimaryDiagonal - sumSecondaryDiagonal));
        }
    }
}
