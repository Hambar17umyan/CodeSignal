using System.Text;

namespace alphabeticShift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string solution(string inputString)
            {
                StringBuilder sb = new StringBuilder(inputString);
                for (int i = 0; i < sb.Length; i++)
                {
                    if (sb[i] == 'z')
                    {
                        sb[i] = 'a';
                        continue;
                    }
                    sb[i]++;
                }
                return sb.ToString();
            }

        }
    }
}
