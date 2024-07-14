namespace Is_MAC48_Address
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool solution(string inputString)
            {
                string[] arr = inputString.Split('-');
                if (arr.Length != 6)
                    return false;
                foreach (string s in arr)
                {
                    if (s.Length != 2)
                        return false;
                    if (!(s[0] >= 'A' && s[0] <= 'F') && !(s[0] >= '0' && s[0] <= '9'))
                    {
                        return false;
                    }
                    if (!(s[1] >= 'A' && s[1] <= 'F') && !(s[1] >= '0' && s[1] <= '9'))
                    {
                        return false;
                    }
                }

                return true;
            }

        }
    }
}
