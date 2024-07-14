namespace Elections_Winners
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int solution(int[] votes, int k)
            {
                int res = 0;
                int m = 0;
                bool mult = false;
                foreach (int v in votes)
                {
                    if (v > m)
                    {
                        m = v;
                        mult = false;
                    }
                    else if(v == m)
                    {
                        mult = true;
                    }
                }
                if (k == 0)
                {
                    return mult ? 0 : 1;
                }
                foreach (int vote in votes)
                {
                    if (vote + k > m)
                        res++;
                }
                return res;
            }

        }
    }
}
