namespace Extra_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int solution(int a, int b, int c)
            {
                return a == b ? c : (a == c ? b : a);
            }

        }
    }
}
