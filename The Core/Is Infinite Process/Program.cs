namespace Is_Infinite_Process
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool solution(int a, int b)
            {
                if (a > b)
                    return true;
                if ((b - a) % 2 == 1)
                    return true;
                return false;
            }

        }
    }
}
