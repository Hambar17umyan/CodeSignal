namespace firstDigit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char solution(string inputString)
            {
                foreach (char c in inputString)
                {
                    if(c >= '0' && c <= '9')
                    {
                        return c;
                    }
                }
                return '0';
            }

        }
    }
}
