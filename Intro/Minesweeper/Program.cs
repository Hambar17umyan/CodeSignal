namespace Minesweeper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] solution(bool[][] matrix)
            {
                int[][] res = new int[matrix.Length][];
                for (int i = 0; i < matrix.Length; i++)
                {
                    res[i] = new int[matrix[i].Length];
                }

                for (int i = 0; i < matrix.Length; i++)
                {
                    for (int j = 0; j < matrix[i].Length; j++)
                    {
                        if (matrix[i][j])
                        {
                            implement(i, j);
                        }
                    }
                }
                void implement(int i, int j)
                {
                    if (i > 0)
                    {
                        res[i - 1][j]++;
                        if (j > 0)
                        {
                            res[i - 1][j - 1]++;
                        }
                        if (j < res[i].Length - 1)
                        {
                            res[i - 1][j + 1]++;
                        }
                    }

                    if (i < res.Length - 1)
                    {
                        res[i + 1][j]++;
                        if (j > 0)
                        {
                            res[i + 1][j - 1]++;
                        }
                        if (j < res[i].Length - 1)
                        {
                            res[i + 1][j + 1]++;
                        }
                    }

                    if (j > 0)
                    {
                        res[i][j - 1]++;
                    }
                    if (j < res[i].Length - 1)
                    {
                        res[i][j + 1]++;
                    }
                }
                return res;
            }
        }
    }
}
