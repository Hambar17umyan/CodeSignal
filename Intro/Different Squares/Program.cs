using System.Text;

namespace Different_Squares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int solution(int[][] matrix)
            {
                if (matrix.Length == 1)
                    return 0;
                if (matrix[0].Length == 1)
                    return 0;
                var arr = new char[matrix.Length, matrix[0].Length];
                for (int i = 0; i < matrix.Length; i++)
                {
                    for (int j = 0; j < matrix[0].Length; j++)
                    {
                        arr[i, j] = (char)(matrix[i][j] + '0');
                    }
                }

                var st = new List<string>();

                for (int i = 1; i < matrix.Length; i++)
                {
                    for (int j = 1; j < matrix[0].Length; j++)
                    {
                        StringBuilder sb = new StringBuilder();
                        sb.Append(arr[i - 1, j - 1]);
                        sb.Append(arr[i - 1, j]);
                        sb.Append(arr[i, j - 1]);
                        sb.Append(arr[i, j]);
                        st.Add(sb.ToString());
                    }
                }

                st.Sort();
                int res = 1;
                for (int i = 1; i < st.Count; i++)
                {
                    if(st[i] != st[i - 1])
                        res++;
                }
                return res;
            }

        }
    }
}
