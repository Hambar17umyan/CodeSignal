using System.Text;

namespace messageFromBinaryCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solution("010010000110010101101100011011000110111100100001"));
            string solution(string code)
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < code.Length; i+=8)
                {
                    string s = code.Substring(i, 8);
                    int k = Convert.ToInt32(s, 2);
                    sb.Append((char)k);
                }
                return sb.ToString();
            }

        }
    }
}
