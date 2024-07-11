namespace arrayChange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }

        int solution(int[] inputArray)
        {
            int res = 0;
            for(int i = 1; i < inputArray.Length; i++)
            {
                if (inputArray[i] > inputArray[i - 1])
                    continue;
                res += inputArray[i - 1] - inputArray[i] + 1;
                inputArray[i] = inputArray[i - 1] + 1;
            }
            return res;
        }
    }
}
