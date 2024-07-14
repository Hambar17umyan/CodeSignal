using System.Text;

namespace lineEncoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string solution(string s)
            {
                StringBuilder res = new StringBuilder("");
                s += '!';
                char c = s[0];
                int k = 1;
                for(int i = 1; i < s.Length; i++)
                {
                    if (s[i] != s[i - 1])
                    {
                        if(k > 1)
                        {
                            res.Append(k.ToString());
                            res.Append(c);
                        }
                        else
                            res.Append(c);
                        k = 1;
                        c = s[i];
                    }
                    else
                    {
                        k++;
                    }
                }
                return res.ToString();
            }

        }
    }
}
