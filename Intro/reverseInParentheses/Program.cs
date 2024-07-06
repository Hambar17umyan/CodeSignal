using System.Text;

namespace reverseInParentheses
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
        }

        static string solution(string inputString)
        {
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < inputString.Length; i++)
            {
                if (inputString[i] == '(')
                {
                    stack.Push(i);
                }
                else if (inputString[i] == ')')
                {
                    int k = stack.Pop();
                    inputString = reverse(inputString, k, i);
                }
            }
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < inputString.Length; i++)
            {
                if (inputString[i] == '(' || inputString[i] == ')')
                {
                    continue;
                }
                sb.Append(inputString[i]);
            }

            return sb.ToString();

            string reverse(string inputString, int start, int end)
            {
                StringBuilder sb = new StringBuilder(inputString);
                StringBuilder res = new StringBuilder(inputString.Substring(0, start));
                for (int i = end; i >= start; i--)
                {
                    res.Append(sb[i]);
                }
                res.Append(new StringBuilder(inputString.Substring(end + 1)));
                return res.ToString();
            }
        }
    }
}