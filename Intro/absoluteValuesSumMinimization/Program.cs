namespace absoluteValuesSumMinimization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int solution(int[] a)
            {
                Array.Sort(a);
                if (a.Length % 2 == 0)
                {
                    int sum1 = 0;
                    int sum2 = 0;
                    foreach(int i in a)
                    {
                        sum1 += Math.Abs(i - a[a.Length / 2]);
                        sum2 += Math.Abs(i - a[a.Length / 2 - 1]);
                    }
                    return sum1 >= sum2 ? a[a.Length / 2 - 1] : a[a.Length / 2];
                }
                else return a[a.Length / 2];
            }

        }
    }
}
