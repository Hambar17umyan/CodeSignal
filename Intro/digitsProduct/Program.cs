namespace digitsProduct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int solution(int product)
            {
                if(product == 0)
                {
                    return 10;
                }
                if (product == 1)
                {
                    return 1;
                }
                List<int> list = new List<int>();
                for (int i = 9; i > 1; i--)
                {
                    while (product % i == 0)
                    {
                        product /= i;
                        list.Add(i);
                    }
                }
                if (product != 1)
                {
                    return -1;
                }
                list.Sort();
                int res = 0;
                foreach (int i in list)
                {
                    res *= 10;
                    res += i;
                }
                return res;
            }

        }
    }
}