namespace Sudoku
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool solution(int[][] grid)
            {
                if (grid.Length != 9 || grid[0].Length != 9)
                    return false;

                for (int i = 0; i < grid.Length; i++)
                {
                    var arr = new bool[10];
                    for (int j = 0; j < grid[i].Length; j++)
                    {
                        if (arr[grid[i][j]])
                            return false;
                        arr[grid[i][j]] = true;
                    }
                }
                for (int i = 0; i < grid.Length; i++)
                {
                    var arr = new bool[10];
                    for (int j = 0; j < grid[i].Length; j++)
                    {
                        if (arr[grid[j][i]])
                            return false;
                        arr[grid[j][i]] = true;
                    }
                }

                for (int i = 2; i < 9; i += 3)
                {
                    for (int j = 2; j < 9; j += 3)
                    {
                        var arr = new bool[10];
                        int x, y;

                        x = i - 2;
                        y = j - 2;
                        if (arr[grid[x][y]])
                            return false;
                        arr[grid[x][y]] = true;

                        x = i - 2;
                        y = j - 1;
                        if (arr[grid[x][y]])
                            return false;
                        arr[grid[x][y]] = true;

                        x = i - 2;
                        y = j;
                        if (arr[grid[x][y]])
                            return false;
                        arr[grid[x][y]] = true;

                        x = i - 1;
                        y = j - 2;
                        if (arr[grid[x][y]])
                            return false;
                        arr[grid[x][y]] = true;

                        x = i - 1;
                        y = j - 1;
                        if (arr[grid[x][y]])
                            return false;
                        arr[grid[x][y]] = true;

                        x = i - 1;
                        y = j;
                        if (arr[grid[x][y]])
                            return false;
                        arr[grid[x][y]] = true;

                        x = i;
                        y = j - 2;
                        if (arr[grid[x][y]])
                            return false;
                        arr[grid[x][y]] = true;

                        x = i;
                        y = j - 1;
                        if (arr[grid[x][y]])
                            return false;
                        arr[grid[x][y]] = true;

                        x = i;
                        y = j;
                        if (arr[grid[x][y]])
                            return false;
                        arr[grid[x][y]] = true;
                    }
                }

                return true;
            }

        }
    }
}
