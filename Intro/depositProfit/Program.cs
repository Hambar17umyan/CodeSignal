namespace depositProfit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int solution(int deposit, int rate, int threshold)
            {
                int res = 0;

                double amount = deposit;
                double milestone = threshold;
                while(amount < milestone)
                {
                    res++;
                    amount += (amount * rate) / 100;
                }

                return res;
            }

        }
    }
}
