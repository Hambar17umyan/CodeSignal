namespace centuryFromYear
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }

        int solution(int year)
        {
            int res = year / 100;
            if(year % 100 != 0)
            {
                res++;
            }

            return res;
        }

    }
}
