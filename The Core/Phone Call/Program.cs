namespace Phone_Call
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int solution(int min1, int min2_10, int min11, int s)
            {
                int res = 0;
                if (s < min1)
                    return 0;

                res = 1;
                s -= min1;
                
                if(s >= min2_10 * 9)
                {
                    res = 10;
                    s -= min2_10 * 9;
                }
                else
                {
                    res += s / min2_10;
                    return res;
                }

                res += s / min11;

                return res;
            }

        }
    }
}
