namespace arrayMaximalAdjacentDifference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int solution(int[] inputArray)
            {
                int res = 0;
                for (int i = 1; i < inputArray.Length; i++)
                {
                    res = Math.Max(Math.Abs(inputArray[i] - inputArray[i - 1]), res);
                }
                return res;
            }

        }
    }
}
