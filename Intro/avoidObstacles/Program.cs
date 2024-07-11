namespace avoidObstacles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int solution(int[] inputArray)
            {
                Array.Sort(inputArray);
                int res = inputArray[inputArray.Length - 1] + 1;
                bool[] isObsticle = new bool[res];
                foreach(int i in inputArray)
                {
                    isObsticle[i] = true;
                }
                for (int i = res; i >= 1; i--)
                {
                    bool b = true;
                    for(int j = 0; j <= inputArray[inputArray.Length - 1]; j+=i)
                    {
                        if (isObsticle[j])
                        {
                            b = false;
                            break;
                        }
                    }
                    if(b)
                        res = i;
                }
                return res;
            }

        }
    }
}
