namespace Knapsack_Light
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int solution(int value1, int weight1, int value2, int weight2, int maxW)
            {
                if (weight1 + weight2 > maxW)
                {
                    if (weight1 > maxW)
                    {
                        if (weight2 > maxW)
                        {
                            return 0;
                        }
                        else
                        {
                            return value2;
                        }
                    }
                    else
                    {
                        if (weight2 > maxW)
                        {
                            return value1;
                        }
                        else
                        {
                            return Math.Max(value1, value2);
                        }
                    }
                }
                return value1 + value2;
            }

        }
    }
}
