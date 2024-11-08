namespace Tennis_Set
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool solution(int score1, int score2)
            {
                int a, b;
                a = Math.Max(score1, score2);
                b = Math.Min(score1, score2);
                if (a == 6)
                {
                    if (b < 5)
                    {
                        return true;
                    }
                    return false;
                }
                else if (a == 7)
                {
                    if (b < 7 && b >= 5)
                        return true;
                    return false;
                }
                else
                {
                    return false;
                }
            }

        }
    }
}
