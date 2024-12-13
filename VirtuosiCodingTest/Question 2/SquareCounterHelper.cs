using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtuosiCodingTest.Question_2
{
    public static class SquareCounterHelper
    {
        public static int CountSquares(int n)
        {
            int totalSquares = 0;

            // Iterate over all possible square sizes
            for (int size = 1; size <= n; size++)
            {
                // Add the number of squares of the current size
                totalSquares += (n - size + 1) * (n - size + 1);
            }

            return totalSquares;
        }
    }
}
