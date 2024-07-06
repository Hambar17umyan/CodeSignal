namespace centuryFromYear
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }

        bool solution(string inputString)
        {
            for (int i = 0; i < inputString.Length; i++)
            {
                if (inputString[i] != inputString[inputString.Length - i - 1])
                {
                    return false;
                }
            }

            return true;
        }

    }
}
