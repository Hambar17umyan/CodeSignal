using System.Text;

namespace buildPalindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solution("abcdcba"));
            string solution(string st)
            {

                if (isPalindrome(st))
                    return st;

                string s = "";

                for(int i = 0; i < st.Length; i++)
                {
                    s += st[i];

                    if (isPalindrome(st + Reverse(s)))
                        return st + Reverse(s);
                }
                return st + Reverse(st);
            }

            bool isPalindrome(string sb)
            {
                for(int i = 0, j = sb.Length - 1;  i < j; i++, j--)
                {
                    if (sb[i] != sb[j])
                        return false;
                }
                return true;
            }

            string Reverse(string s)
            {
                StringBuilder sb = new StringBuilder();
                for(int i = s.Length - 1; i >= 0; i--)
                    sb.Append(s[i]);
                return sb.ToString();
            }

        }
    }
}
