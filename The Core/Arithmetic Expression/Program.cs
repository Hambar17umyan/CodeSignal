namespace Arithmetic_Expression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool solution(int a, int b, int c)
            {
                return a + b == c || a - b == c || a * b == c || (decimal)a / b == (decimal)c;
            }

        }
    }
}
