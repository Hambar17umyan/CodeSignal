namespace arrayMaxConsecutiveSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int solution(int[] inputArray, int k)
            {
                int res = 0;
                for(int i = 0; i < k; i++)
                {
                    res += inputArray[i];
                }
                int m = res;
                for (int i = k; i < inputArray.Length; i++)
                {
                    m -= inputArray[i - k];
                    m += inputArray[i];
                    res = Math.Max(res, m);
                }
                return res;
            }

        }
    }
}
