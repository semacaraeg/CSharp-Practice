using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice
{
    public static class ZeroMatrix
    {
        public static void SetZeroes(int[,] matrix)
        {
            int R = matrix.GetLength(0);
            int C = matrix.GetLength(1);
            HashSet<int> rows = new HashSet<int>();
            HashSet<int> cols = new HashSet<int>();

            for (int i = 0; i < R; i++)
            {
                for (int j = 0; j < C; j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        rows.Add(i);
                        cols.Add(j);
                    }
                }
            }

            for (int i = 0; i < R; i++)
            {
                for (int j = 0; j < C; j++)
                {
                    if (rows.Contains(i) || cols.Contains(j))
                    {
                        matrix[i, j] = 0;
                    }
                }
            }
        }
    }
}
