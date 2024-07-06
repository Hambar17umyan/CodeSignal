namespace adjacentElementsProduct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        int solution(int[] inputArray)
        {
            int res = inputArray[0] * inputArray[1];
            for (int i = 2; i < inputArray.Length; i++)
            {
                if (inputArray[i] * inputArray[i - 1] > res)
                    res = inputArray[i] * (inputArray[i - 1]);
            }
            return res;
        }

    }
}
