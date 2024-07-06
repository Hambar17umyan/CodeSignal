namespace alternatingSums
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] solution(int[] a)
            {
                int sum1, sum2;
                sum1 = sum2 = 0;
                for (int i = 0; i < a.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        sum1 += a[i];
                    }
                    else
                    {
                        sum2 += a[i];
                    }
                }

                return new int[]{ sum1, sum2 };
            }
        }



    }
}
