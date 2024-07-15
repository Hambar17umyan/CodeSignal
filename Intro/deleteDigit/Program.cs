namespace deleteDigit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int solution(int n)
            {
                string s = n.ToString();
                for(int i = 0; i < s.Length - 1; i++)
                {
                    if (s[i] < s[i + 1])
                    {
                        return int.Parse(s.Substring(0, i) + s.Substring(i + 1));
                    }
                }
                return int.Parse(s.Substring(0, s.Length - 1));
            }

        }
    }
}
