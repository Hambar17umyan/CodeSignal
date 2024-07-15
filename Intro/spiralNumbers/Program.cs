namespace spiralNumbers
{
    internal class Program
    {
        enum Dirrection
        {
            RD,
            DL,
            LU,
            UR
        }
        static void Main(string[] args)
        {
            solution(3);
            int[][] solution(int n)
            {
                int[][] ans = new int[n][];
                for (int i = 0; i < n; i++)
                {
                    ans[i] = new int[n];
                }
                Dirrection dirrection = Dirrection.RD;

                int m = n * n;
                int x = 0;
                int y = 0;
                for (int i = 1; i <= m; i++)
                {
                    ans[x][y] = i;
                    if (dirrection == Dirrection.RD)
                    {
                        if(y == n - 1 || ans[x][y + 1] != 0)
                        {
                            x++;
                            dirrection = (Dirrection)(((int)dirrection + 1) % 4);
                            continue;
                        }
                        y++;
                    }
                    else if (dirrection == Dirrection.DL)
                    {
                        if (x == n - 1 || ans[x + 1][y] != 0)
                        {
                            y--;
                            dirrection = (Dirrection)(((int)dirrection + 1) % 4);
                            continue;
                        }
                        x++;
                    }
                    else if (dirrection == Dirrection.LU)
                    {
                        if (y == 0 || ans[x][y - 1] != 0)
                        {
                            x--;
                            dirrection = (Dirrection)(((int)dirrection + 1) % 4);
                            continue;
                        }
                        y--;
                    }
                    else
                    {
                        if (x == 0 || ans[x - 1][y] != 0)
                        {
                            y++;
                            dirrection = (Dirrection)(((int)dirrection + 1) % 4);
                            continue;
                        }
                        x--;
                    }
                }

                return ans;
            }

        }
    }
}
