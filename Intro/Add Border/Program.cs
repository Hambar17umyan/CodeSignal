using System.Diagnostics;
using System.Text;

namespace Add_Border
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] solution(string[] picture)
            {
                StringBuilder[] sb = new StringBuilder[picture.Length + 2];
                sb[0] = new StringBuilder(new string('*', picture[0].Length + 2));
                sb[sb.Length - 1] = sb[0];
                for (int i = 1; i < sb.Length - 1; i++)
                {
                    sb[i] = new StringBuilder();
                    sb[i].Append('*');
                    sb[i].Append(picture[i - 1]);
                    sb[i].Append('*');
                }

                string[] res = new string[sb.Length];
                for (int i = 0; i < res.Length; i++)
                {
                    res[i] = sb[i].ToString();
                }

                return res;
            }

        }
    }
}
