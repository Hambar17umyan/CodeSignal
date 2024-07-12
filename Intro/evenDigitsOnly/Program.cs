namespace evenDigitsOnly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool solution(int n)
            {
                string s = n.ToString();
                foreach (char i in s)
                {
                    if ((i - '0') % 2 != 0)
                        return false;
                }
                return true;
            }

        }
    }
}
