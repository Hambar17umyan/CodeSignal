namespace longestDigitsPrefix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string solution(string inputString)
            {
                for(int i = 0; i < inputString.Length; i++)
                {
                    if(inputString[i] >= '0' && inputString[i] <= '9')
                    {
                        continue;
                    }
                    return inputString.Substring(0, i);
                }
                return inputString;
            }

        }
    }
}
