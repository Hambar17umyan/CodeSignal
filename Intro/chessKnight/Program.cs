namespace chessKnight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int solution(string cell)
            {
                int res = 0;
                int x, y;
                x = cell[0] - 'a';
                y = cell[1] - '1';
                if(x + 2 < 8)
                {
                    if (y + 1 < 8)
                        res++;
                    if (y - 1 >= 0)
                        res++;
                }
                if(x - 2 >= 0)
                {
                    if (y + 1 < 8)
                        res++;
                    if (y - 1 >= 0)
                        res++;
                }

                x += y;
                y = x - y;
                x -= y;
                if (x + 2 < 8)
                {
                    if (y + 1 < 8)
                        res++;
                    if (y - 1 >= 0)
                        res++;
                }
                if (x - 2 >= 0)
                {
                    if (y + 1 < 8)
                        res++;
                    if (y - 1 >= 0)
                        res++;
                }
                return res;
            }

        }
    }
}
