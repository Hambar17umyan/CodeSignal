using System.Text;

namespace longestWord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = solution("Ready, steady, go!");
            Console.WriteLine(a);
            string solution(string text)
            {
                text += '!';
                int res = 0;
                int k = 0;
                StringBuilder rs = new StringBuilder();
                StringBuilder sb = new StringBuilder();
                foreach (char c in text)
                {
                    if ((c > 'Z' || c < 'A') && (c > 'z' || c < 'a'))
                    {
                        if (res < k)
                        {
                            rs = sb;
                            res = k;
                        }
                        k = 0;
                        sb = new StringBuilder();
                    }
                    else
                    {
                        sb.Append(c);
                        k++;
                    }
                }
                return rs.ToString();
            }

        }
    }
}
