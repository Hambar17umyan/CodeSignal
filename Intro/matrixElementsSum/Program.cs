
namespace matrixElementsSum
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }

        int solution(int[][] matrix)
        {
            int res = 0;
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if (matrix[i][j] == 0)
                    {
                        if (i < matrix.Length - 1)
                        {
                            matrix[i + 1][j] = 0;
                        }
                    }
                    else
                        res += matrix[i][j];
                }
            }
            return res;
        }
    }
}

