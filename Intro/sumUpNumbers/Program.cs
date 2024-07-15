using System.Text;

namespace sumUpNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int solution(string inputString)
            {
                StringBuilder sb = new StringBuilder();
                inputString += '!';
                int res = 0;
                bool b = false;
                foreach (char c in inputString)
                {
                    if (c >= '0' && c <= '9')
                    {
                        sb.Append(c);
                    }
                    else
                    {
                        if (sb.Length > 0)
                        {
                            res += int.Parse(sb.ToString());
                            sb.Clear();
                        }
                    }
                }
                return res;
            }

        }
    }
}
