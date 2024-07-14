namespace differentSymbolsNaive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int solution(string s)
            {
                bool[] isPresent = new bool[26];
                foreach(char c in s)
                {
                    isPresent[c - 'a'] = true;
                }
                int res = 0;
                foreach(bool b in isPresent)
                {
                    if (b)
                    {
                        res++;
                    }
                }
                return res;
            }

        }
    }
}
