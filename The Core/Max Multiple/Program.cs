namespace Max_Multiple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int solution(int divisor, int bound)
            {
                return bound - bound % divisor;
            }

        }
    }
}
