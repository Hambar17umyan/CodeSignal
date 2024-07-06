namespace All_Longest_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] b = new string[] { "aba", "cd", "gh", "ada", "aba", "ag", "aga" };
            string[] a = solution(b);
        }

        static string[] solution(string[] inputArray)
        {
            int sz = inputArray[0].Length;
            for (int i = 1; i < inputArray.Length; i++)
            {
                if (inputArray[i].Length > sz)
                    sz = inputArray[i].Length;
            }
            int j = 0;
            string[] ret = new string[inputArray.Length];
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i].Length == sz)
                {
                    ret[j] = inputArray[i];
                    j++;
                }
            }

            Array.Resize(ref ret, j);

            return ret;
        }

    }
}
