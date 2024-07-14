namespace digitDegree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int solution(int n)
            {
                string s = n.ToString();
                int count;
                for(count = 0; s.Length > 1; count++)
                {
                    int k = 0;
                    for(int i = 0; i < s.Length; i++)
                    {
                        k += s[i] - '0';
                    }
                    s = k.ToString();
                }
                return count;
            }

        }
    }
}
