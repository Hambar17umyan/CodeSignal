namespace extractEachKth
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] solution(int[] inputArray, int k)
            {
                List<int> result = new List<int>();
                for (int i = 0; i < inputArray.Length; i++)
                {
                    if ((i + 1) % k == 0)
                        continue;
                    result.Add(inputArray[i]);
                }

                int[]returnArray = result.ToArray();

                return returnArray;
            }

        }
    }
}
