namespace isLucky
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }

        bool solution(int n)
        {
            string s = n.ToString();
            int a = 0, b = 0;
            for (int i = 0, j = s.Length - 1; i < j; i++, j--)
            {
                a += s[i] - '0';
                b += s[j] - '0';
            }
            return a == b;
        }
    }
}
