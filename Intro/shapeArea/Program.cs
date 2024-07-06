namespace shapeArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }

        int solution(int n)
        {
            n--;
            int res = 1;
            res += (n * (n + 1)) * 2;
            return res;
        }

    }
}
