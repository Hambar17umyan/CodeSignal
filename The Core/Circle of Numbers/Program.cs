namespace Circle_of_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int solution(int n, int firstNumber)
            {
                return (firstNumber + n / 2) % n;
            }

        }
    }
}
